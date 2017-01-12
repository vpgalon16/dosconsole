using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.TaskCommand
{
    public class FileManipulator : Command_Info
    {
        /*
         * This method is meant on copying or moving file(s) to destination folder 
         */
        public void CopyMoveDelRen(string filename, string destFolder, int flag)
        {
            try
            {
                // Preparing the filename
                string actFilename;
                if (filename.IndexOf(":") != -1)
                    actFilename = filename;
                else
                    actFilename = Environment.CurrentDirectory + "\\" + filename;

                // Preparing the destination folder
                string actDestFolder;
                if (destFolder.IndexOf(":") != -1)   // Means with full path
                    actDestFolder = destFolder;
                else
                    actDestFolder = Environment.CurrentDirectory + "\\" + destFolder;

                // To get the filename without directory
                string basename = Path.GetFileName(@actFilename);
                // To get the directory only excluded the filename
                string fullPath = Path.GetDirectoryName(@actFilename);
                
                // Get all the files from specified directory and wildcards
                string[] files = Directory.GetFiles(@fullPath, @basename);
                foreach (string file in files)
                {
                    string destDir = @actDestFolder + "\\" + Path.GetFileName(@file);
                    if (flag == COPY)     // To copy the file
                        System.IO.File.Copy(@file, @destDir, true);
                    else if (flag == MOVE)     // To move the file
                        System.IO.File.Move(@file, @destDir);
                    else if (flag == DELETE)     // To delete the file
                        System.IO.File.Delete(@file);
                    else if (flag == RENAME)     // To rename the file
                    {
                        string newDest;
                        if (destDir.IndexOf("*") != -1) // means with wildcard or multiple file renamed
                        {
                            string sourceFullPath = Path.GetDirectoryName(@file);
                            string sourceBasename = Path.GetFileName(@file);
                            string[] splitNameSource = sourceBasename.Split('.');

                            string destFullPath = Path.GetDirectoryName(@actDestFolder);
                            string destBasename = Path.GetFileName(@actDestFolder);
                            string[] splitNameDest = destBasename.Split('.');

                            newDest = @destFullPath + "\\" + splitNameSource[0] + "." + splitNameDest[1];
                            System.IO.File.Move(@file, newDest);
                        }
                        else   // means single file..
                        {
                            newDest = @actDestFolder;
                            System.IO.File.Move(@file, newDest);
                        }
                    }
                }
                if (flag == COPY)
                    Console.WriteLine("     {0}  file(s) copied\n", files.Length);
                else if (flag == MOVE)
                    Console.WriteLine("     {0}  file(s) moved\n", files.Length);
                else if (flag == DELETE)
                    Console.WriteLine("     {0}  file(s) deleted\n", files.Length);
                else if (flag == RENAME)
                    Console.WriteLine("     {0}  file(s) renamed\n", files.Length);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Destination directory cannot be found: {0}\n", ex.Message);
            }
            catch (Exception e)
            {
                if (flag == COPY)
                    Console.WriteLine("Error in copying file: {0}\n", e.Message);
                else if (flag == MOVE)
                    Console.WriteLine("Error in moving file: {0}\n", e.Message);
                else if (flag == DELETE)
                    Console.WriteLine("Error in moving file: {0}\n", e.Message);
                else if (flag == RENAME)
                    Console.WriteLine("Error in renaming file: {0}\n", e.Message);
            }
        }

    }
}