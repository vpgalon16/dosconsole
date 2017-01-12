using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.TaskCommand
{
    public class Usage
    {
        public void usage_info()
        {
            Console.WriteLine("");
            Console.WriteLine("Usage: ");
            Console.WriteLine("");
            Console.WriteLine("    - Change Directory");
            Console.WriteLine("       CD.. ");
            Console.WriteLine("       CD [Target Folder Full Path] i.e C:\\test");
            Console.WriteLine("       CD [Target Folder Name] i.e test");
            Console.WriteLine("");
            Console.WriteLine("    - Copying or Moving File(s) from source to target folder");
            Console.WriteLine("       COPY || MOVE [Source Folder]\\* [Destination Folder]");
            Console.WriteLine("       COPY || MOVE [Source Folder]\\*.* [Destination Folder]");
            Console.WriteLine("       COPY || MOVE [Source Folder]\\*.[ext] [Destination Folder]");
            Console.WriteLine("       COPY || MOVE [Source Folder]\\[Exact Filename] [Destination Folder]");
            Console.WriteLine("       COPY || MOVE [Source Folder]\\[Filename].* [Destination Folder]");
            Console.WriteLine("");
            Console.WriteLine("    - Deleting File(s) from a folder");
            Console.WriteLine("       DEL [Source Folder]\\*");
            Console.WriteLine("       DEL [Source Folder]\\*.*");
            Console.WriteLine("       DEL [Source Folder]\\*.[ext]");
            Console.WriteLine("       DEL [Source Folder]\\[Exact Filename]");
            Console.WriteLine("       DEL [Source Folder]\\[Filename].*");
            Console.WriteLine("");
            Console.WriteLine("    - List all Files/Directories in selected directory");
            Console.WriteLine("       DIR *");
            Console.WriteLine("       DIR *.*");
            Console.WriteLine("       DIR *.[ext]");
            Console.WriteLine("       DIR [Filename].*");
            Console.WriteLine("       DIR [Exact Filename]");
            Console.WriteLine("");
            Console.WriteLine("    - Renaming File / Directory  or File(s) / Directories ");
            Console.WriteLine("       RENAME *.[old ext] *.[new ext]");
            Console.WriteLine("       RENAME [Old File] [New File]");
            Console.WriteLine("");
            Console.WriteLine("    - Make Directory or Creating new folder");
            Console.WriteLine("       MD [Directory Name]  i.e MD test");
            Console.WriteLine("       MD [Fullpath folder and Directory Name] i.e MD C:\\test");
            Console.WriteLine("");
            Console.WriteLine("    - Remove Directory or Deleting existing folder");
            Console.WriteLine("       RD [Directory Name] i.e RD test");
            Console.WriteLine("       RD [Fullpath folder and Directory Name] i.e RD C:\\test");
            Console.WriteLine("");
        }
        public void dir_info()
        {
            Console.WriteLine("");
            Console.WriteLine("Usage: ");
            Console.WriteLine("");
            Console.WriteLine("    - List all Files/Directories in selected directory");
            Console.WriteLine("       DIR *");
            Console.WriteLine("       DIR *.*");
            Console.WriteLine("       DIR *.[ext]");
            Console.WriteLine("       DIR [Filename].*");
            Console.WriteLine("       DIR [Exact Filename]");
            Console.WriteLine("");
        }
    }
}