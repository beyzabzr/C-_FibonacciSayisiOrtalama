using System;
using System.Net;

namespace fibonacciSayiOrtalamasi
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("***FIBONACCI SAYI ORTALAMASI***");
            Console.WriteLine("Ortalamasini istediginiz fibonacci derinliğini giriniz: ");

            int depth = Convert.ToInt32(Console.ReadLine());

            //Girilen derinlik 0'a esit ya da kucuk ise programi kapatir 
            if (depth <= 0)
            {
                Console.WriteLine("Lutfen pozitif bir sayi giriniz.");
                return;
            }

            //Derinlige kadar olan fibonacci sayilarini gosterir
            FibonacciHesaplama hesaplama = new FibonacciHesaplama();
            double ort = hesaplama.OrtalamaHesaplama(depth);

            //Sonucu gosterir
            Console.WriteLine($"Fibonacci sayisinin ilk {depth} ortalamasi: {ort}");
        }

        class FibonacciHesaplama
        {
            private int Fibonacci(int n)
            {
                //Fibonacci sayilarini bulur
                if (n <= 0)
                {
                    return n;
                }

                int a = 0, b = 1, temp = 0;
                for (int i = 2; i <= n; i++)
                {
                    temp = a + b;
                    a = b;
                    b = temp;
                }

                return b;
            }
            public double OrtalamaHesaplama(int ort)
            {
                //Girilen derinlige kadar olan fibonacci sayilarinin ortalamasini bulur
                double toplam = 0;
                for (int i = 1; i <= ort; i++)
                {
                    int fibonacci = Fibonacci(i);
                    Console.WriteLine($"{i}. Fibonacci Sayisi: {fibonacci}");
                    toplam += fibonacci;
                }
                return toplam / ort;
            }
        }
    }
}