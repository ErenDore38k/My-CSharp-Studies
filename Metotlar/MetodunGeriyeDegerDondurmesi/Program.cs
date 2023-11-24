
/*
 *Metodun Geriye Değer Döndürmesi Ne Demektir?
 *Metot en küçük program parçacığıdır.
 *Prensib:Bir metot bir iş yapmalı. 
 *Bir metodun geriye değer döndürmesi demek,içerisinde yapılan işlem neticesinde üretilen sonuçların ekrana yazılması
 *demek değildir. Yani çıktı vermesi demek değildir.
 *Metodun geriye döndürdüğü değer programatik olarak yakalanıp,algoritmanın akışında farklı yönlendirmelere sebebiyet 
 *verebilen değerdir.
 

static public void Topla(int Sayi1, int Sayi2)
        {
            int Toplam = Sayi1 + Sayi2;
            Console.WriteLine(Toplam);
        }
        static void Main(string[] args)
        {
            Topla(3, 5);
        }
Bu şekilde değer döndürmeden de ekrana çıktı verebiliriz. 



Eğer ki fonksiyonumuzun içindeki değer ile bir algoritmik çalışma yapacak isek bir değer döndürmemiz doğru olacaktır. ↓


        static public bool PersonelEkle(string Ad, string Soyad, int Yas)
        {
            if (Yas >= 18)
            {   // Veri Tabanına eklendi.
                return true;
            }
            else
            {
                Console.WriteLine("18 yaşından küçükler kayıt olamaz!");
                return false;
            }
        }
        static void Main(string[] args)
        {
            bool Kayit = PersonelEkle("Eren", "Döre", 20);
            if (Kayit)
                Console.WriteLine("Kaydınız gerçekleşti.");
        }

 */






using System;

namespace functions
{

    class Program
    {
        static void Main(string[] args)
        {
            Topla(3,5);
        }

       static public int Topla(int sayi1,int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine(sonuc);
            return sonuc;
        } 
    }
}