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

        public List<string> ListInDir()
        {
            if (System.IO.Directory.Exists(server_date_path))
            {
                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(server_date_path);

                List<string> listInDir = new List<string>();
                foreach(var item in di.GetDirectories())
                {
                    var info = new FileInfo(item.FullName);
                    if (info != null)
                    {
                        listInDir.Add(info.Name + "\r\n" + info.LastWriteTime);
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

        public bool IsDiffrent(string Spath, string Cpath)
        {
            return true;
        }
    }


}