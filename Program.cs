using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите А: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите B: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите действие:");
           
            ConsoleKeyInfo Key = Console.ReadKey();


          
            char selection = Key.KeyChar;
            switch (selection)
            {
                case '+':

                    int x = a;
                    int y = b;

                    int z = x + y;
                    Console.WriteLine(z);
                    break;

            }
            Console.ReadKey();
        }
    }
}
