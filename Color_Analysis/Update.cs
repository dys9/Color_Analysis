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
        public const string server_date_path = @"D:\server_data";
        public const string client_date_path = @"D:\이대현\WORK_SPACE\Project_C#\Color_Analysis\Color_Analysis\client_data";

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

        private List<string> ListInDir(string Path)
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

        public List<string> GetDiffrentDir()
        {
            List<string> DirServer = ListInDir(this.server_data_path);
            List<string> DirClient = ListInDir(this.client_data_path);

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
                System.Windows.Forms.MessageBox.Show("DirServer & DirClient Count is not Same!");
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

        public void GetDataFromServer(List<string> DiffrentDir)
        {

        }
    }


}