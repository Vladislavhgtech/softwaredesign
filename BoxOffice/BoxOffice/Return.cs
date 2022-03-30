using System;
using System.Collections.Generic;
using System.Text;

namespace BoxOffice
{
    class Return
    {
        public static void R()
        {
            while (true)
            {
                Console.WriteLine("Для возврата товара введите его артикул. Для выхода - esc");
                string line = Console.ReadLine();
                if (line == "esc")
                    break;
                else
                {
                    Console.WriteLine("Введите количество возвращаемого товара данного артикула");
                    string Value = Console.ReadLine();
                    DataBase.Corect(true, Convert.ToInt32(line), Convert.ToInt32(Value));
                }
            }
        }
    }
}
