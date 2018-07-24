﻿using System;
using System.Threading;
using System.Threading.Tasks;
using System.IO;


namespace Delegate_event
{
    class Async3
    {
        static void Main()
        {
            var testThread = new AsyncAwaitExample();
             testThread.DoWork();

            while (true)
            {
                Console.WriteLine("Doing work on the Main Thread !!");
            }
        }
    }

    public class AsyncAwaitExample
    {
        public async Task DoWork() => await Task.Run(() =>
        {
            int counter;

            for (counter = 0; counter < 1000; counter++)
            {
                Console.WriteLine(counter);
            }
        });

    }
}