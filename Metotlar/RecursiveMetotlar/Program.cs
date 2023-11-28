
/*
 *Recursive(Tekrarlamalı/Özyinelemeli) Metotlar
 *Recursive Fonksiyon:Kendi içerisinde kendini çağıran/tetikleyen fonksiyonlardır.
 *Türkçe karşılığı olarak ise özyinelemeli veya tekrarlamalı fonksiyonlarda diyebiliriz.
 *Recursive fonksiyonlar bir yaklaşımdır.
 *Recursive fonksiyon tecrübeyle sabit olan bir konudur.
 *Recursive fonksiyon anlaşılması,kullanılması ve anlatılması zordur.
 *Recursive fonksiyonlar ne amaçla kullanılmaktadır?
 *Öngürülemeyen,derinliği tahmin edilemeyen,sonu bilinmeyen durumlarda tercih edilebilir.
 *Döngülerin kullanıldığı her nokta recursive fonksiyonlar kullanılabilir.Amma velakin recursive fonksiyonların kullanıldığı her 
 *yer de döngü KULLANILAMAZ.Döngü öngürülebilir ama recursive fonksiyonlar öngürülemez.
 *
 * 
 */


//Soru:Belirli değer aralığındaki 5'in katı olan tüm sayıları toplayan recursive fonksiyonu yazalım.
Console.WriteLine(Topla(10, 20));
int Topla(int baslangic,int bitis)
{
    if (baslangic % 5 == 0)
        return baslangic + Topla(++baslangic,bitis);
    if(baslangic < bitis)
    return Topla(++baslangic, bitis); //Başlangıçın mod 5 i sıfıra eşit değilse yapılacak eylem.
    return 0;
}




/*
X();

void X(int a=1)
{
    Console.WriteLine("Merhaba");
    if (a < 3)
    {
        X(++a);
    }

    
    Console.WriteLine("Dünya");
}
*/

/*
X();

void X(int a = 1)
{
    Console.WriteLine("Merhaba");
    if ( a < 3)
    {
        X(++a);

    }
    

}

*/



