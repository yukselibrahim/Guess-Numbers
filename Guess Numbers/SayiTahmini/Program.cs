using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SayiTahmini
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random a = new Random();
            int sayi = a.Next(1, 101);

            for (int hak = 5; hak > 0; hak--)
            {
                Console.WriteLine("Bir Sayı Tuttum Hadi Bil Bakalım Sana " + hak + " Hak Veriyorum: ");
                int tahmin = Convert.ToInt32(Console.ReadLine());

                if (tahmin == sayi)
                {
                    Console.WriteLine("Efferim Sana Bildin :)");
                    break;
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Elini Korkak Alıştırma Arttır Biraz Daha");
                }
                else if (tahmin > sayi)
                {
                    Console.WriteLine("Yavaş Biraz Düşür Sayıyı");
                }
                if (hak == 1)
                {
                    Console.WriteLine("\nHadi Neyse 5 Saniye Bekle Sonra Tekrar Dene Bu Kıyağımı Unutma ;)\n");
                    Thread.Sleep(5000);
                    hak = hak + 5;
                }
            }

            Console.WriteLine("Yine Bekleriz.");
            Console.ReadLine();
        }
    }
}
