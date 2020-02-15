using System;
using System.IO;

namespace Document_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like the name of the document to be?");
            Console.WriteLine("-------------");
            Console.ReadLine();

            // enter user input
            Console.WriteLine("Enter the file name: ");
            string file_name = Console.ReadLine();

            // adding a .txt extension if it isn't already there

            if (string.IsNullOrEmpty(Path.GetExtension(file_name)))
            {
                file_name += ".txt";
            }

            else
                {

                }
            Console.WriteLine("/n-----------");
            Console.WriteLine("Enter the file contents; ");
            string file_contents = Console.ReadLine();


            // opening the file
            FileStream Document_Challenge;
            StreamWriter writer;
            TextWriter oldOut = Console.Out;
            try
            {
                Document_Challenge = new FileStream(file_name, FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter(Document_Challenge);

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: Unable to access {0}.");
                Console.WriteLine(e.Message);
                return;

            }

            // writing to the file
            int characterCount = file_contents.Length;
            Console.SetOut(writer);
            Console.WriteLine("{0}", file_contents);
            Console.SetOut(oldOut);
            writer.Close();
            Document_Challenge.Close();
            Console.WriteLine("{0} was successfully save. The document contains {1} characters.", file_name, characterCount);

            Console.WriteLine("Press Enter to exit.........");
            Console.ReadLine();
        }
    }
}
