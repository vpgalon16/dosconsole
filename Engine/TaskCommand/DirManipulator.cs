using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Engine.TaskCommand
{
    public class DirManipulator
    {
        /*
         * This method is meant for folder or directory creation. 
         */
        public void CreateDir(string name)
        {
            // Specify the directory you want to manipulate.
            string path = @name;

            try
            {
                // Determine whether the directory exists.
                if (Directory.Exists(path))
                {
                    Console.WriteLine("This folder[{0}] alreday exists.", path);
                    return;
                }

                // Try to create the directory.
                DirectoryInfo di = Directory.CreateDirectory(path);
                Console.WriteLine("This folder[{0}] was created successfully at {1}.", path, Directory.GetCreationTime(path));
            }
            catch (Exception e)
            {
                Console.WriteLine("The folder[{0}] creation has been failed: {1}", path, e.Message);
            }
        }

        /*
         * This method is meant for folder or directory deletion. 
         */
        public void RemoveDir(string name)
        {
            // Specify the directory you want to manipulate.
            string path = @name;

            try
            {
                // To delete directory.
                Directory.Delete(path);
                Console.WriteLine("Deletion of this folder[{0}] has been successful.", path);
            }
            catch (Exception e)
            {
                Console.WriteLine("This folder[{0}] deletion has been failed: {1}", path, e.Message);
            }
        }

        /*
         * This method is meant for folder or directory listing. 
         */
        public void ListDir(string ext)
        {
            // Get current folder.
            string path = Environment.CurrentDirectory;
            try
            {
                // Get files in current directory with input extension
                string[] dirs = Directory.GetFiles(@path, ext);
                Console.WriteLine("\nDirectory of {0}\n", path);
                foreach (string fullpathFile in dirs)
                {
                    string filename = Path.GetFileName(fullpathFile);
                    Console.WriteLine("      " + filename);
                }

                DirectoryInfo direc = new DirectoryInfo(path);
                DirectoryInfo[] subDirs = direc.GetDirectories();
                if (subDirs.Length > 0)
                {
                    foreach (DirectoryInfo subDir in subDirs)
                    {
                        Console.WriteLine("<DIR> " + subDir.Name);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}\n", e.Message);
                Engine.TaskCommand.Usage Usage = new Engine.TaskCommand.Usage();
                Usage.dir_info();
            }
        }

        /*
         * This method is meant for changing folder or directory. 
         */
        public void ChangeDir(string name)
        {
            try
            {
                string newPath;
                string curPath = Environment.CurrentDirectory;
                newPath = Path.GetFullPath(Path.Combine(@curPath, @name));
                Environment.CurrentDirectory = @newPath;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}\n", e.Message);
            }
        }
    }
}
