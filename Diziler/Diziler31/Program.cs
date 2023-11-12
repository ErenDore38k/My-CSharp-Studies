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