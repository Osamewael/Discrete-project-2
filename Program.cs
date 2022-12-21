using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discrete_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, y, sum = 0;
            Console.Write("Enter the  start number :");
            int start = int.Parse(Console.ReadLine());

            Console.Write("Enter the end number:");
            int end = int.Parse(Console.ReadLine());
            
            for (int number = start; number <= end; number++)
            {
                
                for (int number2 = 1; number2 <= end; number2++)
                {
                     
                    if (number % number2 == 0 && number != number2)
                    {
                        
                        sum += number2;
                    }
                }
                
                if (sum == number)
                {
                    Console.WriteLine(number);
                    Console.WriteLine("is perfect number ");
                }
                
                sum = 0;
            }
        }   
    }
}
