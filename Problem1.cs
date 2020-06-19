using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizinin eleman sayısı alınıyor

            Console.WriteLine("Kümenin Eleman Sayısını Giriniz:");
            int elemansayisi = Convert.ToInt32(Console.ReadLine());
            var kume = new string[elemansayisi];

            //Dizinin elemanları alınıyor
            for (int i = 0; i < elemansayisi; i++)
            {
                Console.WriteLine(String.Format("{0}.Eleman : ", i));
                kume[i] = Console.ReadLine();
            }

            //Alt kümelerinin bulunması
            var altkume = AltKumeBul(kume);

            // Maksimum toplamın bulunmasıı
            var sayi = AltKumeMaxToplama(altkume);
            Console.WriteLine("Maksimum Toplam: " + sayi);
            Console.ReadKey();
        }

        // Max toplam değerini bulma
        public static int AltKumeMaxToplama(List<string> altkume)
        {
            string[,] alt = new string[4, altkume.Count];
            int toplam = 0;
            int Max=-2147483648;
            foreach (var v in altkume)
            {
                if (v != "")
                {
                    var x = v.Split(',');
                    var l = x.Length;
                    toplam = x.Sum(s => Convert.ToInt32(s));
                    if(toplam>Max)
                        {
                        Max = toplam;
                        }
                }

            }
            return Max;
        }
        // Alt kümeleri bulma
        public static List<string> AltKumeBul(string[] kume)
        {
            int elemansayisi = kume.Length;
            int alkumesayisi = AltKumeSayisiHesap(elemansayisi);
            List<string> t = new List<string>();
            string[,] altkume = new string[elemansayisi, alkumesayisi];
            t.Add("");
            foreach (var s in kume)
            {

                int x = t.Count();
                for (int y = 0; y < x; y++)
                {
                    if (y == 0)
                    {
                        Console.WriteLine("AltKümeler: \n {" + t[y] + s + "}");
                        t.Add(t[y] + s);

                    }
                    else
                    {
                        Console.WriteLine("AltKümeler: \n{" + t[y] + "," + s + "}");
                        t.Add(t[y] + "," + s);
                    }
                }
            }
            return t;
        }

        //Alt küme sayısını bulma
        public static int AltKumeSayisiHesap(int elemansayisi)
        {
            return (int)Math.Pow(2, elemansayisi);
        }
    }
}
