using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 2;
            int userNumber;
            bool compositeNumber = false;
            Console.WriteLine("Введите число: ");
            userNumber = int.Parse(Console.ReadLine());



            while (n <= userNumber - 1) 
            {
                if (userNumber % n == 0)
                {
                    compositeNumber = true;
                    break;
                  
                }
                n++;
            }
            if (compositeNumber == false) 
            {
                Console.WriteLine("Число является простым.");

            }
            else 
            {
                Console.WriteLine("Число является составным.");
            }
                Console.ReadKey();


                








            
        }
    }
}
