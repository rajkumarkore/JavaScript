﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO4
{
    class MainClass
    {
        static void Main(string[] args)
        {
            log4net.Config.BasicConfigurator.Configure();

            // CreateTable table = new CreateTable();
            //table.CreateTableMethod();

            //InsertData insert = new InsertData();
            //insert.OpenConnection();
            //insert.Insert();

            ShowData data = new ShowData();
            data.OpenConnection();
            data.GetData();

            Console.WriteLine("Press any key to exit!");
            Console.Read();
        }
    }
}