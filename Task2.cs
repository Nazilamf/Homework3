using System;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var result = CountChar('h', "hehhlho");
            Console.WriteLine(result);

        }


        static int CountChar(char cr , string str)
        {
            int count=0;
            for (int i = 0; i < str.Length; i++)
            {
                if (cr == str[i])
                    count++;

            }
            return  count;
        }







    }



}
