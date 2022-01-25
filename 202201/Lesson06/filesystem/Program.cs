using System;
// Access file system
using System.IO;

namespace filesystem
{
    class Program
    {
        // specify a path to the file you want to write
        const string PATH_TO_FILE = @"C:\file.txt";

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            // add two lines to the file
            WriteToFile("Hello IBT Class!");
            WriteToFile("We are programming!");

            // call once since it will read the entire file
            ReadFile();
        }

        // reads from a file and prints to the console  
        public static void ReadFile()
        {
            // always check whether file exists
            // Option 1
            // if (File.Exists(PATH_TO_FILE) == false) {
            //     File.Create(PATH_TO_FILE);
            // }

            // Option 2
            FileInfo file = new FileInfo(PATH_TO_FILE);
            if (file.Exists == false)
            {
                file.Create();
            }

            using (StreamReader reader = new StreamReader(PATH_TO_FILE))
            {
                string line = reader.ReadLine();
                // if NOT null or empty then
                while (!String.IsNullOrEmpty(line))
                {
                    Console.WriteLine(line);
                    // read next line
                    // it will return null when reader reaches end of file
                    line = reader.ReadLine();
                }
                // ALWAYS CLOSE!!
                reader.Close();
            }
        }

        // appends text to a file
        public static void WriteToFile(string text)
        {
            // always check whether file exists
            // Option 1
            if (File.Exists(PATH_TO_FILE) == false) {
                File.Create(PATH_TO_FILE);
            }

            // Option 2
            // FileInfo file = new FileInfo(PATH_TO_FILE);
            // if (file.Exists == false)
            // {
            //     file.Create();
            // }

            // Use Directory or DirectoryInfo for directories

            // use a stream class - ALWAYS CLOSE/DISPOSE STREAM CLASSES!
            // set append to true to add to the file instead of destroying it every time
            using (StreamWriter writer = new StreamWriter(PATH_TO_FILE, true))
            {
                writer.WriteLine(text);
                // VERY IMPORTANT!!!
                writer.Close();
            }
        }
    }
}
