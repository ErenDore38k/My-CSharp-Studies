

/*
 *C#'ta out Keyword'ü Nedir? Ne Amaçla Kullanılmaktadır?
 *Out keyword'ü metotların Parametreleri üzerinden dışarıya değer göndermemizi sağlayan bir keyworddür.
 *Bir metotun parametreleri varsayılan olarak İnput'tur.Haliyle metotlarda tanımlanmış parametreler direkt olarak içeriye değer
 *almaya odaklanırlar.Eğer ki bir metodun parametresi dışarıya değer çıkaracaksa o parametrenin out keywordüyle işaretlenmesi
 *gerekmektedir.
 *Out parametresi barındıran bir metodu kullanırken, out parametrelerden gelecek olan değerleri karşılayacak degişkenler tanımlanmalı
 */
/*
 * Böyle bir kullanımda olabilir.
int _b = 0;
string _d = "";
int a = X( out _b,123,out _d);
*/
int a = X(out int _b, 123, out string _d);
Console.WriteLine(_d);
Console.WriteLine(_b);
int X(out int b,int c ,out string d)
{
    //Bir metot out parametre(ler) barındırıyorsa o parametrelere kendi içerisinde değer atanması gerekmektedir. Aksi takdirde derleyici hatası 
    //alınacaktır.
    b = 25;
    d = "hilmi";
    return 0;

}

/*
//Try Parse 
Bu out keyword’ünü kullanan C# fonksiyonlarına örnek olarak TryParse metodu verilebilir.
Bu metot Parse metodu ile dönüştürme işlemi yaparken dönüşümün hedef türe uygun olup olmadığını kontrol ederek runtime hatası
alınmaması adına bool bir değer return ediyor aynı zamanda da out bir parametre olarak tür dönüşümünü uygunsa gerçekleştirip
çıktı olarak veriyor.
Text string değişkeni integer türüne uygun olduğu için başarı ile dönüştürülecek ve TryParse metodu hem kontrol için bir
true değer döndürecek hem de out parametresi ile dönüşümü çıktı olarak verecek.


string a = "123";
int.TryParse(a, out int r);

if (int.TryParse(a,out int r)) 
{

}
else
{

}
*/