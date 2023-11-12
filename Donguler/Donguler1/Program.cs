//Programlamada Nedir Bu Döngüler? Ne Amaçla Kullanılır?
//Temelde 3 tane döngümüz vardır : for döngüsü, while döngüsü, do while döngüsü olmak üzere.


//‘Hangi Döngü Nerede Kullanılır’ Yanlış Bir Sorudur! Doğru Soru ‘Hangi Döngü Nereye Yakışır’

/*Ardışık bir sayım işlemi'nin döngüsü yapılacaksa for döngüsü daha yatkındır/yakısır.
 *Sonsuz bir yapılanma söz konusu ise while/do while daha yakısır kullanmak.
  Bu 3 döngü birbirleri'nin yerine kullanılabilir ama her duruma her olaya ayrı bir şekilde yakışan döngüler vardır.
 *Hangi döngü nerede kullanılmalıdır? sorusu YANLIŞ bir sorudur.Doğru soru , hangi döngü nereye /hangi senaryoya daha çok yakışır.
 *Bir senaryo/durum örneği vermem gerekirse 1den 100 e kadar arıdışık sayma işlemi yapmak istersek for dönügüsünü kullanmak daha doğru olur.
 *İkinci senaryo ise sonsuz işlem durum gerektiren örnekler de while döngüsünü kullanmak daha doğru olacaktır.
 *Bu döngülerin hepsi bir kombinasyona bağlı bir şekilde çalıştıkları için en nihayetinde birbirlerinin yerine kullanılabilirler.
 *Döngü kelimesinin ingilizce karşılığı loop dur.
 */

//For Döngüsünü İnceleyelim

/*Prosedürel programlamada döngü yapılarından biriside for döngüsüdür. Genellikle ardışık işlemlerde kullanılan bir döngü yapılanmasıdır.
 * PROTOTİPİ : 
  for( başlangıç değeri değişkeni ; Şart yazılır buraya ; genellikle başlangıç değerini arttırma azaltma )
{
For döngüsünde ki scope ise : Şart true oldukça bu scope tetiklenecek ve döngü çalıştırılmış olacaktır.

}

*Ardışık algoritmalarda genellikle bir ilk değere ihtiyaç vardır. İlk değeri tanımlamak zorunlu değildir.
*Şart parametresinde : Herhangi bir şart/koşul ifadesi tanımlanabilir.Lakin genellikle ilk değer olarak tanımlanan değişken durumu burada 
*kontrol edilir.Yani bir şarta bağlanır. Şart true oldugu sürece döngü tetiklenecektir.
*Genellikle başlangıç değerini arttırma azaltma parametresinde ise : Herhangi bir değişken üzerinde işlem yapabiliriz. Genellikle başlangıç değeri
*üzerinde bir arttırma yahut bir azaltma işlemi yapılır. Amma velakin bir değerinin dışında diğer arttırma ve azaltma işlemleride ihtiyaca 
*binanen yapılmaktadır. Ve illaki kullanmak zorunda da değiliz.
*/

for (int sayi = 1; sayi < 10; sayi++)
{
    Console.WriteLine("İyi günler Türkiye");
}

/*1) Akış ilk olarak başlangıç değişkeni tanımlama kısmına girecektir.Eğer ki bir değişken tanımlama ifadesi varsa ilgili değişkeni 
 *tanımlayacaktır.
 *2) Ardından koşula gidecek ve koşulu değerlendirecektir.
 *3) Eğer ki koşul true ise döngüye girecektir.
 *4) YOk eğer koşul true değil ise döngüden çıkacaktır.
 *3.1) Koşul kontrol edildikten sonra döngü ilgili değeri arttıracak parametreye gidecek ve yapılan aritmetik işlemi değişkene
 *uyguluyacaktır.
 *3.2) Sayısal değeri arttırılmış ya da azaltılmış olan değişkenden sonra yeniden koşulu kontrol edecek ve ardından true ise 3 değilse 4.
 *adımlar tekrar edilecektir.
 */













