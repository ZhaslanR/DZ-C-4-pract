using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        private static int counter = 0;
        static void Main(string[] args)
        {
            ToDo();
            Console.ReadLine();
        }
        private static void ToDo()
        {
            int[] mas = new int[5];
            try
            {
                for (int i = 0; i <= 5; i++)
                {
                    mas[i] = counter++;
                    Console.WriteLine(mas[i]);
                }
            }
            catch (IndexOutOfRangeException exception)
            {
                Console.WriteLine(exception.Message);
                throw;
            }
        }
    }
}
