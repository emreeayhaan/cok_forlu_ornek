using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            //yeni dizi oluştur dizinin sınırını kullanıcı belirlesin dizinin tüm elemanlarını random atsın aynı dizide küçükten büyüğe sırala ve ekrana yazdır
            int a = Convert.ToInt32(Console.ReadLine());
            Random r = new Random();
            int[] d = new int[a];
            for (int i = 0; i < d.Length; i++)
            {
                d[i] = r.Next(100);
                Console.WriteLine(d[i]);
            }
            for (int i = 0; i < d.Length; i++)
            {
                for (int j = 0; j < d.Length; j++)
                {
                    if(d[i]<d[j])
                    {
                        int gd = d[i];
                        d[i] = d[j];
                        d[j] = gd;
                    }
                }
            }
            Console.WriteLine("////////////");
            for (int i = 0; i < d.Length; i++)
            {
                Console.WriteLine(d[i]);
            }
        }
    }
}
