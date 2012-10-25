﻿
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Prototype
{
    class scoresave
    {
        static void Main()
        {

            // These examples assume a "C:\Users\Public\TestFolder" folder on your machine.
            // You can modify the path if necessary. 

            // Example #1: Write an array of strings to a file. 
            // Create a string array that consists of three lines. 
            string[] lines = { "First line", "Second line", "Third line" };
            System.IO.File.WriteAllLines(@"C:\score.txt", lines);


            // Example #2: Write one string to a text file. 
            string text = "A class is the most powerful data type in C#. Like structures, " +
                           "a class defines the data and behavior of the data type. ";
            System.IO.File.WriteAllText(@"C:\WriteText.txt", text);

            // Example #3: Write only some strings in an array to a file. 
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\WriteLines2.txt"))
            {
                foreach (string line in lines)
                {
                    if (line.Contains("Second") == false)
                    {
                        file.WriteLine(line);
                    }
                }
            }

            // Example #4: Append new text to an existing file 
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\WriteLines2.txt", true))
            {
                file.WriteLine("Fourth line");
            }
        }
    }
}

*/