using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        public string name = "";
        public string newname = "";
        public void Input()
        {
            Console.WriteLine("Please enter your name");
            name = Console.ReadLine();
        }

        public void Dispaly()
        {
            for(int i = 0; i < name.Length ; i++)
            {
                char c = name[i];
                newname +=  Convert.ToChar(c + 1);
            }


            Console.WriteLine(newname);
        }

    }
}


 