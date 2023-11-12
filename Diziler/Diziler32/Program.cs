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