using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Color_Analysis
{
    public class Update
    {
        private string _server_data_path;
        public string server_data_path
        {
            get { return _server_data_path; }
            set { _server_data_path = value; }
        }

        private string _client_data_path;
        public string client_data_path
        {
            get { return _client_data_path; }
            set { _client_data_path = value; }
        }

        public Update(string Spath, string Cpath)
        {
            this.server_data_path = Spath;
            this.client_data_path = Cpath;
        }

        private List<string> GetDirNames(string Path)
        {
            if (System.IO.Directory.Exists(Path))
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(Path);

                List<string> listInDir = new List<string>();
                foreach(var item in di.GetDirectories())
                {
                    var info = new FileInfo(item.FullName);
                    if (info != null)
                    {
                        listInDir.Add(info.Name + "\n" + info.LastWriteTime);
                    }
                    else
                    {
                        return null;
                    }
                }

                return listInDir;
            }
            else
            {
                return null;
            }
        }

        public List<string> GetChangedDir()
        {
            List<string> DirServer = GetDirNames(this.server_data_path);
            List<string> DirClient = GetDirNames(this.client_data_path);

            if (DirServer.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("DirServer List is Null!");
                return null;
            }
            if (DirClient.Count == 0)
            {
                System.Windows.Forms.MessageBox.Show("DirClient List is Null!");
                return null;
            }
            if (DirServer.Count != DirClient.Count)
            {
                System.Windows.Forms.MessageBox.Show("DirServer & DirClient Count is not Same!\r\n" +
                    "Set Only Color, Lens, Law, Light Folders");
                return null;
            }

            DirServer.Sort();
            DirClient.Sort();
            List<string> DiffrentDir = new List<string>();

            for (int i = 0; i < DirServer.Count; i++)
            {
                string[] sd = DirServer[i].Split('\n');
                string[] cd = DirClient[i].Split('\n');

                if (sd.Length == cd.Length)
                {
                    if (!sd[1].Equals(cd[1]))
                    {
                        DiffrentDir.Add(sd[0]);
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Split Result's Length is not Same!");
                    return null;
                }
            }

            return DiffrentDir;
        }

        public List<string> GetChangedFileNames(string Folder)
        {
            if (Folder == null)
            {
                System.Windows.Forms.MessageBox.Show("Dir is Null!");
                return null;
            }
            if (!System.IO.Directory.Exists(client_data_path + Folder))
            {
                System.Windows.Forms.MessageBox.Show("Client's " + Folder + " is Empty.");
                return null;
            }
            if (!System.IO.Directory.Exists(server_data_path + Folder))
            {
                System.Windows.Forms.MessageBox.Show("Server's " + Folder + " is Empty.");
                return null;
            }

            System.IO.DirectoryInfo Sdi = new System.IO.DirectoryInfo(server_data_path + Folder);
            System.IO.DirectoryInfo Cdi = new System.IO.DirectoryInfo(client_data_path + Folder);

            List<string> ChangedFileNames = new List<string>();
            List<string> TempFileNames = new List<string>();

            foreach (System.IO.FileInfo Sinfo in Sdi.GetFiles())
            {
                TempFileNames.Add(Sinfo.Name);
                foreach (System.IO.FileInfo Cinfo in Cdi.GetFiles())
                {
                    if (Sinfo.Name.Equals(Cinfo.Name))
                    {
                        TempFileNames.Remove(Sinfo.Name);
                        if (!Sinfo.LastWriteTime.Equals(Cinfo.LastWriteTime))
                        {
                            ChangedFileNames.Add(Sinfo.Name);
                        }
                    }
                }
            }

            if (TempFileNames.Count != 0)
            {
                ChangedFileNames.AddRange(TempFileNames);
            }
            
            return ChangedFileNames;
        }

        public bool GetDataFromServer(string Folder, string ChangedFile)
        {
            if (Folder == null & ChangedFile == null)
            {
                System.Windows.Forms.MessageBox.Show("string Folder & ChangedFile is null!");
                return false;
            }
            
            if (System.IO.Directory.Exists(this.server_data_path + Folder) && System.IO.Directory.Exists(this.client_data_path + Folder))
            {
                string sourceFile = System.IO.Path.Combine(server_data_path + Folder, ChangedFile);
                string destFile = System.IO.Path.Combine(client_data_path + Folder, ChangedFile);

                System.IO.File.Copy(sourceFile, destFile, true);
                return true;
            }
            return false;
        }
    }
}