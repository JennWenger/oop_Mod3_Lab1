﻿// Ensure that the System namespace is in scope
using System;
using System.Globalization;
using System.IO;

namespace Mod3_Lab1
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Creates StreamReader object called "streamReaderObject" 
            // Assigns its value to null
            StreamReader streamReaderObject = null;

            try
            {
                // Assigns "streamReaderObject" to read from a text file named "file1"
                streamReaderObject = new StreamReader("file1.txt");

                // Reads all characters from the current position to the end of the stream
                // Stores in String variable "contents"
                String contents = streamReaderObject.ReadToEnd();

                // Closes StreamReader
                streamReaderObject.Close();

                // Writes the amount of text elements in the text file to the Console
                Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
            }

            // Code to handle any errors
            catch (FileNotFoundException)
            {
                // Informs user there is no file created
                Console.WriteLine("The file cannot be found.");
            }

            //Invoking the dispose method in finally block
            //Note that code in finallyblock will always execute
            finally
            {
                //Checks if object is not null
                if (streamReaderObject != null)
                    //Calls upon dispose method
                    //Releases all resources used by the Textreader object
                    streamReaderObject.Dispose();
            }
        }
    }
}
