using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BoxOffice
{
    class DataBase
    {

        public static List<Product> ReadStock()
        {
            FileStream file1 = new FileStream("C:/Users/vld85/source/repos/BoxOffice/BoxOffice/dbStock.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            List<Product> Pr = new List<Product>();
            int art, st;
            while (!reader.EndOfStream)
            {
                art = Convert.ToInt32(reader.ReadLine());
                st = Convert.ToInt32(reader.ReadLine());
                Product p1 = new Product();
                p1.Article = art;
                p1.Stock = st;
                Pr.Add(p1);
            }
            reader.Close();
            return Pr;
        }
        public static void WriteStock(List<Product> Pr)
        {
            FileStream file2 = new FileStream("C:/Users/vld85/source/repos/BoxOffice/BoxOffice/dbStock.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file2);
            foreach (Product i in Pr)
            {
                writer.WriteLine(i.Article);
                writer.WriteLine(i.Stock);
            }
            writer.Close();
            Console.ReadLine();
        }
        public static void Corect(bool Type, int Art, int Value)
        {
            List<Product> Pr = ReadStock();
            if (Type)
            {
                bool flag = false;
                foreach (Product i in Pr)
                {
                    if (i.Article == Art)
                    {
                        i.Stock += Value;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Product p1 = new Product();
                    p1.Article = Art;
                    p1.Stock = Value;
                    Pr.Add(p1);
                }
            }
            else
            {
                bool flag = false;
                foreach (Product i in Pr)
                {
                    if (i.Article == Art)
                    {
                        i.Stock -= Value;
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    Console.WriteLine("Товара с таким артикулом нет на складе");
                }
            }
            WriteStock(Pr);
        }

    }
}
