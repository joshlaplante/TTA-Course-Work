using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_File_Transfer_Drill
{
    // first define a Times class that will hold the current time and the time 24 hours previously
    
    public class Times
    {
        public DateTime Now;
        public DateTime Limit;

        // to instantiate a times object, we will just pass in the current time using DateTime.Now

        public Times(DateTime TimeNow)
        {
            // which set the current time, and the limit time which is 24 hours back by using the AddDays method in reverse

            Now = TimeNow;
            Limit = TimeNow.AddDays(-1);
        }

    }


    class FileTransfer
    {
        // this method is the bulk of actual functionality. it will copy the files from one folder to another if they have been modified in the last 24 hours, 
        // and the one parameter is an object of the Times class defined above.

        public static void MoveFiles(Times Time)
        {
            // first set the source and destination paths

            string Source = @"C:\Users\joshl_000\Desktop\Folder A";
            string Destination = @"C:\Users\joshl_000\Desktop\Folder B";

            // if the source path is a directory, then we do the following

            if (System.IO.Directory.Exists(Source))
            {
                // create a string array holding the files within the source directory

                string[] SourceFiles = System.IO.Directory.GetFiles(Source);

                // now loop through each of those files

                foreach (string SourceFile in SourceFiles)
                {
                    // first set the full path of the current file 
                    string FullPath = Path.Combine(Source, SourceFile);

                    // now create a new datetime that holds the last modified time for the current file

                    DateTime FileModifiedTime = File.GetLastWriteTime(FullPath);

                    // now, if that modified time is within the last 24 hours, we do the following

                    if (Time.Now > FileModifiedTime && FileModifiedTime > Time.Limit)
                    {
                        // get just the filename of the current file

                        string FileName = Path.GetFileName(SourceFile);

                        // combine that file name with the destination path

                        string DestinationFile = Path.Combine(Destination, FileName);

                        // and lastly, copy the source file to the destination, with overwriting on in case the destination directory has a file with
                        // the same name.

                        File.Copy(SourceFile, DestinationFile, true);
                    }

                    
                }

            }
        }

        // actual execution begins here

        static void Main(string[] args)
        {
            // first we create an object of the Times class, remembering to give it the current time as an argument

            Times CheckTimes = new Times(DateTime.Now);

            // and then we simply call the MoveFiles method defined above with that Times class object as the argument

            MoveFiles(CheckTimes);


            //Wait for user to acknowledge result
            Console.WriteLine("Press Enter to terminate...");
            Console.Read();
        }
    }
}
