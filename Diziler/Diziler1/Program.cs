//Dizi Nedir? Ne Amaca Hizmet Eder? Bir Programcı Açısından Neye Yarar?

/*Tek bir değişken altında birden fazla "aynı türde" değeri toplamamızı sağlayan veri kümelerine dizi denmektedir.
 *ARRAYS (DİZİLER) görüldüğü üzere dizilere ARRAYS 'da denilmektedir.
 *Diziler içerisinde birden fazla aynı türde değer tutabilen yapılardır.
 *Prosedürel programlamanın temel veri kümeleridir.Yani yazılımsal boyutta, yazılım adına RAM'de birden fazla değeri tek bir değişken altında
 *bir veri kümesi halinde tutabilirler.
 *Diziler, veri kümeleri oldukları için, içlerindeki birden fazla veri üzerinde kümesel işlemler yapmamızı sağlayabilirler.
 *Diziler ,prosedürel programlamanın temel yapıları oldukları için daha gelişmiş yapılar olan koleksiyonlarında temelini teşkil etmektedirler
 *ve gelişmelerine katkı bulunmaktadırlar.
 *Diziler Referans türlü değerlerdir.Yani nesnel yapılardır.Özlerinde classtırlar.
 *Yapısal olarak RAM'de Heap'te tutulurlar.
 *Dizi içerisine her türlü değer koyulabilir.(Değer türlü ve Referans Türlü).
 *Bir dizi sade ve sadece tek bir türde değer alabilir.(ya hep refarans türlü değişken koy ya ad hep değer türlü koy.)
 *Örnek vermek gerekirse senin değerin türü int ise içerisinde ki tüm değerlerin türü de int olmalıdır.
 *Dizi içerisine koyulan değerler işlevsel olarak aynı mahiyette olmalıdır. Örnek olarak sen bir sınıftaki öğrencilerin yaşını tutuyorsan 
 *içerisine müdürün maaşını eklemeyeceksin ya hep öğrencilerin yaşı yada hep müdürün maaşı şeklinde olmalıdır. Yaş dizisine maaş bilgisi
 *aynı türde olduğu halde verilmemeli.
 *Diziler içerisinde eleman/değer eklendikçe bunları serseri bir şekilde depolamaz düzenki bir şekilde sıralı depolayacaktır.
 *Dizilerde eklenen elemanlar index ismini verdiğimiz numaralarla ardışık bir şekilde numaralandırılırlar.
 *index no: Her bir elemana verilen ardışık sayı. 0 dan başlar n-1 e kadar . 10 elemanlı bir değerde son indeks sayısı 9 dur.
 * 
 *Dizi : type [] a 
 *Bir değişken tanımlanırken türünün yanında [] bu operatörü koyarsak o değişken o türde bir dizi değişkeni olacaktır. Bu operatöre
 *İNDEXER ismi verilmektedir.
 *Dİzi tanımlama prototifi : type[] name = new type[5] şeklindedir.
 *new : Bir dizi nesnesi oluşturmamızı sağlar. 
 *index, indexer kavramı dizilerden gelir.Aklımıza dizileri getirecektir.
 */


//Dizi Nasıl Tanımlanır? - 1

/*Tek bir değişken altında birden fazla "aynı türde" değeri toplamamızı sağlayan veri kümelerine dizi denmektedir.
Dizi Tanımlama örneği= type[] a = new type[20]; Şeklinde olmalıdır.
ÖRNEK: int[] yaslar = new int[12]; şeklinde olmalıdır. 
Örnek2 : double[]notlar = new double[25]; şeklinde olmalıdır.
ÖRnek3 : İnt[] maaslar = new int[12]; Şeklinde olmalıdır.
*Dizi tanımlama sürecinde eleman sayısı mecburi girilmek zorundadır.yani çalışacak değer adedi tanımlama aşamasında bildirilmelidir.
*Bu durum bir sınırlılıktır.
*Eleman sayısı negatif olamamz. Ama 0 olabilir.
*Dizilerde tanımlama yaparken eleman sayısının bildirilmesi zorunluluğu bir sınırlılıktır.
*Bir dizi tanımlaması yapıldığı an bellekte o diziyi kullansakda kullanmaksakda verilen eleman sayısı kadar alan tahsisinde bulunur.
*Dizilerde tanımlama yapıldığı an alan tahsisinde bulunulması bizim için pekte doğru bir durum değildir.
*Kullanılmadığı halde diziler direkt olarak bellekten belirtilen eleman sayısı kadar alan tahsisinde bulunulması bir sınırlılıktır.
*Diziler alan tahsisi yapıldığında ilgili alanlara türüne uygun default değerleri atarlar.
*/

int[] yaslar = new int[5];
yaslar[0] = 25;
yaslar[1] = 30;
yaslar[2] = 40;
yaslar[3] = 18;
yaslar[4] = 50;
for (int i = 0; i < yaslar.Length; i++)
{
    Console.WriteLine(yaslar[i]);
}

