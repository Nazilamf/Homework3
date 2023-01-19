using System;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            int[] numbers = { 45, 12, 6, 7, 95, 11 };
            int num = 2;
            var result = FindIndex(numbers,num);
            Console.WriteLine(result);  
        }

        static int FindIndex(int[] arr, int num)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (num == arr[i])
                {
                    
                    return i;
                    
                }
               
            }

                return -1;
          
            


        }



    }
}
