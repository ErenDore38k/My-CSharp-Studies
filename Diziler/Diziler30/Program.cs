//Çok Boyutlu Diziler
/*
 *Tek boyutlu dizi = int[] notlar = new int[3]; Gibidir.
 * Çok boyutlu diziler oyun programlamada yahut yüksek istatiksel çalışmalarda kullanılan bir yapıdır. 
 */



//Çok Boyutlu Dizi Tanımlama
/*
 *int[] notlar Tek boyutlu bir dizi örneği.
 *int [,] notlar 2 boyutlu bir dizi(Çift) örneği.
 * int[,,,] notlar 4 Boyutlu bir dizi örneği.
 * 2 virgül = 3 Boyutlu dizi
 * 6 virgül = 7 Boyutlu dizi
 * 15 virgül = 16 Boyutlu dizi.
 *Çok boyutlu dizilerde indexer içerisinde virgül[,] ile tanımlama yapılmaktadır.
 *Virgül sayısının +1 fazlası dizinin derecesini  verecektir.
 * 2 Dereceliden fazla olan dizileri günlük hayatta tahayyül etmek pek mümkün olmasada programatik olarak insa edebilmekteyiz.
 */

int[,] sayilar = new int[3, 5];// 2 Boyutlu bir dizi örneği tanımlama 
//2boyutlu diziler x ve y koordinatlarıyla tahayyul edebileceğimiz dizilerdir.



// Tanımlanmış Çok Boyutlu Diziye Değer Atama
/*
int[,,,] sayılar = new int[2, 3, 4, 5];
sayılar[0, 0, 0, 0] = 16;
sayılar[0, 0, 0, 1] = 15;
sayılar[0, 0, 0, 2] = 36;
sayılar[0, 0, 0, 3] = 66;
sayılar[0, 0, 0, 4] = 26;
*/


//Çok Boyutlu Dizilerde Değer Atama Farklı Varyasyon

//Alttaki örnek 2 boyutlu diziye yöneliktir.
int[,] sayılar =
{
    {3,5,7 },
    {4,6,8 },
    {5,10,9 },
    {30,36,12 }
};

for (int i = 0; i < sayılar.GetLength(0); i++)
{
    //Her bir elemanı yazdırmak için iç içe döngü
    for (int j = 0; j < sayılar.GetLength(1); j++)
    {
        Console.Write(sayılar[i, j] + " \n");
    }
}

/*GetLength metodu, bir dizinin belirli bir boyutunun uzunluğunu (kaç eleman içerdiğini) almak için kullanılır.
*İki boyutlu bir dizide, GetLength(0) ifadesi genellikle dizinin ilk boyutunun (satırların) uzunluğunu, GetLength(1) ifadesi ise
*ikinci boyutunun (sütunların) uzunluğunu verir.
*Bu yöntem, çok boyutlu dizilerle çalışırken belirli boyutların uzunluklarına erişmek için kullanılır.
*/
