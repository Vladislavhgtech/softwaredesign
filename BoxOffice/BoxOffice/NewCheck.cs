using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOffice
{
    class NewCheck
    {
        public static void N()
        {
            while (true)
            {
                Console.WriteLine("Для продажи товара введите его артикул. Для выхода - esc");
                string line = Console.ReadLine();
                if (line == "esc")
                    break;
                else
                {
                    Console.WriteLine("Введите количество покупаемого товара данного артикула");
                    string Value = Console.ReadLine();
                    DataBase.Corect(false, Convert.ToInt32(line), Convert.ToInt32(Value));
                }
            }
        }
    }
}
