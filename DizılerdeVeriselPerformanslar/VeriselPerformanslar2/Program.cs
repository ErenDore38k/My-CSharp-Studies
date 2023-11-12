//Dizilerde Verisel Açıdan Maliyetleri İnceleyelim

/*
int[] sayılar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
int[] sayılar2 = sayılar[2..7];
sayılar2[0] *= 10;
//SAyılar2 ayrı bir dizi olduğu için sayılar2'nin 0.imdeksinde yapacağım işlem sayılar2 dizisine etki edecek sayılar dizisinde
//etki etmemiş olacak. 
*/





//ArraySegment Türü Nedir?
//Bir dizinin bütününden ziyade belirli bir kısmına yahut parçasına ihtiyaç dahilinde ilgili diziyi kopyalamak yerine (ki görece
//oldukça maliyetli bir operasyondur) bağımsız bir referans ile erişmemizi ve böylece salt bir şekilde temsil etmemizi sağlayan
//bir yapıdır.




//ArraySegment Türü İle Dizinin Belli Bir Alanını Referans Etmek

/*

int[] sayılar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

ArraySegment<int> segment1 = new ArraySegment<int>(sayılar); // Dizinin tüm elemanlarını temsil eder.

ArraySegment<int> segment2 = new ArraySegment<int>(sayılar,2,5); // Bu ise 30,40,50,60,70 değerlerini tutuyor.
segment1 [0] *= 10;
segment2[0] *= 10;

*/




//ArraySegment Slicing(Dilimleme) Özelliği

//Bir dizi üzerinde birden fazla parçada çalışacaksan eğer herbir parçayı ayrı bir ArraySegment olarak tanımlayabiliriz.
//Bu tanımlamaların dışında diziyi tek bir ArraySegment ile referans edip ilgili parçaları o segment üzerinden talep edebiliriz.
//Yani ilgili diziyi tek bir segment üzerinden daha rahat bir şekilde parçalayabiliriz. Bu durumda bize yazılımsal açıdan
//efektiflik kazandırmış olacaktır.

int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

ArraySegment<int> segment = new ArraySegment<int>(sayilar);

ArraySegment<int> segment1 = segment.Slice(0, 3);
ArraySegment<int> segment2 = segment.Slice(3, 4);
ArraySegment<int> segment3 = segment.Slice(6, 4);

for (int i = 0; i < segment1.Count; i++)
{
    Console.WriteLine(segment1[i]);
}
Console.WriteLine("*");
for (int i = 0; i < segment2.Count; i++)
{
    Console.WriteLine(segment2[i]);
}
Console.WriteLine("*");

for (int i = 0; i < segment3.Count; i++)
{
    Console.WriteLine(segment3[i]);
}
