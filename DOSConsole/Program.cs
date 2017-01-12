using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine;

namespace DOSConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DOS Console application (2017). \nEnable to execute file manipulation commands via DOS console app.");
            for (; true;)
            {
                string currFolder;
                Console.WriteLine("");
                if (Environment.CurrentDirectory.Substring(Environment.CurrentDirectory.Length - 1, 1) != "\\")
                    currFolder = @Environment.CurrentDirectory + "\\";
                else
                    currFolder = @Environment.CurrentDirectory;

                Console.Write(@currFolder);
                string keydata = Console.ReadLine();
                string[] commands = keydata.Split(' ');
                string input = commands[0].ToUpper();
                // This is to display the usage of this app
                if (input == "HELP")
                {
                    Engine.TaskCommand.Usage Usage = new Engine.TaskCommand.Usage();
                    Usage.usage_info();
                }
                // Copying or Moving File(s) from source to target folder
                else if (input == "COPY")
                {
                    if (commands.Length == 1)
                        Console.WriteLine("Please enter files to copy..");
                    else if (commands.Length == 2)
                        Console.WriteLine("Please enter destination folder to copy..");
                    else
                    {
                        Engine.TaskCommand.FileManipulator fileCopy = new Engine.TaskCommand.FileManipulator();
                        fileCopy.CopyMoveDelRen(commands[1], commands[2], 1);
                    }
                }
                else if (input == "MOVE")
                {
                    if (commands.Length == 1)
                        Console.WriteLine("Please enter file(s) to move a file..");
                    else if (commands.Length == 2)
                        Console.WriteLine("Please enter destination folder to move a file..");
                    else
                    {
                        Engine.TaskCommand.FileManipulator fileCopy = new Engine.TaskCommand.FileManipulator();
                        fileCopy.CopyMoveDelRen(commands[1], commands[2], 2);
                    }
                }
                // Deleting File(s)from a folder
                else if (input == "DEL")
                {
                    if (commands.Length == 1)
                        Console.WriteLine("Please enter file(s) to delete..");
                    else
                    {
                        Engine.TaskCommand.FileManipulator fileCopy = new Engine.TaskCommand.FileManipulator();
                        fileCopy.CopyMoveDelRen(commands[1], "", 3);
                    }
                }
                // Renaming File / Directory  or File(s) / Directories
                else if (input == "RENAME")
                {
                    if (commands.Length == 1)
                        Console.WriteLine("Please enter file(s) to rename the file..");
                    else if (commands.Length == 2)
                        Console.WriteLine("Please enter destination filename to rename the file..");
                    else
                    {
                        Engine.TaskCommand.FileManipulator fileCopy = new Engine.TaskCommand.FileManipulator();
                        fileCopy.CopyMoveDelRen(commands[1], commands[2], 4);
                    }
                }
                // List all Files/Directories in selected directory
                else if (input == "DIR" || input == "LL" || input == "LS")
                {
                    string extension;
                    if (commands.Length == 1)
                        extension = "*.*";
                    else
                        extension = commands[1];
                    Engine.TaskCommand.DirManipulator listDIR = new Engine.TaskCommand.DirManipulator();
                    listDIR.ListDir(extension);
                }
                // Change Directory
                else if (input == "CD")
                {
                    string folderName;
                    if (commands.Length == 1 || commands[1] == "")
                        folderName = "";
                    else
                        folderName = commands[1];

                    Engine.TaskCommand.DirManipulator changeDIR = new Engine.TaskCommand.DirManipulator();
                    changeDIR.ChangeDir(folderName);
                }
                // This is to create or make directory
                else if (input == "MD")
                {
                    if (commands.Length == 1 || commands[1] == "")
                        Console.WriteLine("Please enter correct directory name to create..");
                    else
                    {
                        Engine.TaskCommand.DirManipulator makeDIR = new Engine.TaskCommand.DirManipulator();
                        makeDIR.CreateDir(commands[1]);
                    }
                }
                // This is to remove directory
                else if (input == "RD")
                {
                    if (commands.Length == 1 || commands[1] == "")
                        Console.WriteLine("Please enter correct directory name to delete..");
                    else
                    {
                        Engine.TaskCommand.DirManipulator delDIR = new Engine.TaskCommand.DirManipulator();
                        delDIR.RemoveDir(commands[1]);
                    }
                }
                // This is to exit the console app..
                else if (input == "EXIT") break;
                // Carry on if nothing entered...
                else if (input == "PWD")
                {
                    Console.WriteLine(currFolder);
                }
                else if (input == "" || input == " ")
                {
                }
                else  // Entered invalid code
                {
                    Console.WriteLine("Invalid console command --> [{0}] \nPlease enter correct console command.\n", input);
                }
            }
        }
    }
}
