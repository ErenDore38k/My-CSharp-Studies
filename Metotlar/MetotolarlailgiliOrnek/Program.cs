


using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Threading;

class Program
{
    static void Main()
    {
        

        //Alttaki kodu ekledim çünkü başta ilk çalışırken siyah ekran veriyordu.
        Console.BackgroundColor = ConsoleColor.DarkCyan;
        Console.Clear();
        

        string kelime = "CODE";
        Console.Clear();

        // Yazı rengi siyah olarak belirlendim.
        Console.ForegroundColor = ConsoleColor.Black;

        // Belirlenen renk listesi oluşturuldu
        ConsoleColor[] belirlenenRenkler = { ConsoleColor.Blue, ConsoleColor.DarkCyan, ConsoleColor.DarkBlue };

        int renkIndex = 0; // Renk listesindeki indeksi takip etmek için bir değişken

        while (true)
        {
            foreach (char harf in kelime)
            {
                // Belirlenen renkler sırayla kullanılıyor
                Console.BackgroundColor = belirlenenRenkler[renkIndex];
                renkIndex = (renkIndex + 1) % belirlenenRenkler.Length; // Bir sonraki rengi almak için indeksi güncelle

                Console.Write(harf);
                Thread.Sleep(1000);
                Console.Clear();
            }
            Console.Clear();

            // Yazı rengi siyah, arka plan rengi beyaz olarak belirlendi
            Console.BackgroundColor = ConsoleColor.White;
            

            // Harfler bir arada bütün olarak yazdırıldı(CODE)
            Console.WriteLine(kelime);

            // Bir süre bekleyip tekrar başa dönmesini sağlamak için
            Thread.Sleep(2000);
            Console.Clear();//Bunu ekledim en son CODE yazdıktan sonra temiz bir şekilde C harfini yazsın diye.
            

        }
    }
}




















