using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;

namespace JSON.json
{
    class Program
    {
        public string name { get; set; }

        public int age { get; set; }

        public override string ToString()
        {
            return string.Format("Name: {0} \nAge: {1}", name, age);
        }
    }

    class Peson
    {
        static void Main(string[] args)
        {
            //deserialize JSON from file

            String JSONstring = File.ReadAllText("JSON.json");
                       
            Program p1 =  JsonConverter.DeserializeObject<Program>(JSONstring);
            Console.WriteLine(p1);

            //output JSON file

            // Program p2 = new Program() {name = "Ben",age = 58};


        }
    }
}
}
