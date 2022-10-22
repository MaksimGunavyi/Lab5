using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_3
{
    class Program
    {
        static void Main()
        {
            DocWork worker = new DocWork();
            Console.WriteLine("Відбулася активація базового функціоналу програми.");
            Console.WriteLine("\n");
            Console.WriteLine("Для доступу до версій про або експерт - необхідні ключі доступу:");
            Console.WriteLine("Введіть ключ доступу від версії про або експерт. \nКод повинен містити чотири цифри від 0 до 9. \n");
            string product_key = Console.ReadLine();
            int key = Convert.ToInt32(product_key);

            switch (key)
            {
                case 1234:
                    DocWork pro = new ProDocWork();
                    Console.WriteLine("Вітаємо з успішним придбанням Про версії");
                    break;
                case 4321:
                    ProDocWork expert = new ExpertDocWork();
                    Console.WriteLine("Вітаємо з успішним придбанням Експерт версії");
                    break;
            }
            Console.ReadKey();
        }
    }
}