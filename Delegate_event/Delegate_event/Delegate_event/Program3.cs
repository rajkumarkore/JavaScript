﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Delegate_event
{
    class Program3
    {
        public static void Main()
        {
            // Start the HandleFile method.
            Task<int> task = HandleFileAsync();

            // Control returns here before HandleFileAsync returns.
            // ... Prompt the user.
            Console.WriteLine("Please wait patiently " +
                "while I do something important.");

            // Do something at the same time as the file is being read.
            string line = Console.ReadLine();
            Console.WriteLine("You entered (asynchronous logic): " + line);

            // Wait for the HandleFile task to complete.
            // ... Display its results.
            task.Wait(); //system arrgigate error
            var x = task.Result;
            Console.WriteLine("Count: " + x);

            Console.WriteLine("[DONE]");
            Console.ReadLine();
        }

        static async Task<int> HandleFileAsync()
        {
            string file = @"D:\\BizRunTime\\Delegate_event\\Delegate_event\\Delegate_event\\om.txt";
            Console.WriteLine("HandleFile enter");
            int count = 0;

            // Read in the specified file.
            // ... Use async StreamReader method.
            using (StreamReader reader = new StreamReader(file))
            {
                string v = await reader.ReadToEndAsync();

                // ... Process the file data somehow.
                count += v.Length;

                // ... A slow-running computation.
                //     Dummy code.
                for (int i = 0; i < 10; i++)
                {
                    int x = v.GetHashCode();
                    if (x == 0)
                    {
                        count--;
                    }
                }
            }
            Console.WriteLine("HandleFile exit");
            return count;
        }
    }

}

