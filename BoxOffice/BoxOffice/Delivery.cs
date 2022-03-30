using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOffice
{
    class Delivery
    {
        public static void D()
        {
            while (true)
            {
                Console.WriteLine("Для приема поставки товара введите его артикул. Для выхода - esc");
                string line = Console.ReadLine();
                if (line == "esc")
                    break;
                else
                {
                    Console.WriteLine("Введите количество приехавшего товара данного артикула");
                    string Value = Console.ReadLine();
                    DataBase.Corect(true, Convert.ToInt32(line), Convert.ToInt32(Value));
                }
            }
            //throw new System.NotImplementedException();
        }

    }
}
