using System;
using System.Reflection.Metadata.Ecma335;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            int[] Numbers = { 48, 62, 12, 2, 89 };
            var minNumber = FindMin(Numbers);
            Console.WriteLine(minNumber);

        }

        static int FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                 {
                   min = arr[i]; 
                 }

            }
            return min;
        }
        
        

    }
} 
            
                





            







        

    



