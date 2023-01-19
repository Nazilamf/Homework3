using System;
using System.Drawing;
using System.Text;
using System.Threading;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var result = TurnOver("salam");
            Console.WriteLine(result);

        }

        static string TurnOver(string str)
        {
            string newstr = "";
            for (int i = str.Length-1; i >= 0; i--)
                 
            {
                newstr += str[i];
            }

            return newstr;



        }



    }
}
