using System;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var result = IsDigit('1');
            Console.WriteLine(result);
        }


        static bool IsDigit(char num)
        {            
            char[] digits = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
            {
                for(int i = 0; i < digits.Length; i++)
                {
                    if (digits[i] == num)
                    {
                        return true;
                    }
                }
            
               return false;
            }   
            

         

    
        }
    }









}

