//String Türü ve String Gerçeği

/*
 *String; referans türlü olduğu halde programlama dilinde bir keyword barındıran tek değerdir.
 *string referans türlü olduğu için HEAP kısmında tutulur.
 */






//Null - Empty Durumları, Farkları
/*
 *Null: Bir değişken /nullabe değişken /referans eğer ki null alıyorsa bu durum ilgili değişkenin herhangi bir alanı tahsis 
 *etmediği anlamına gelir.Yani tanımlanmış bir değişken STACK üzerinde tanımlı olsa da 
 *HEAP üzerinde bir değeri referans etmediğinden null olacaktır.
 *Arsa yok.
 *Değer Türlü değişkenler null alamazlar.
 *Null alabilen türler sadece referans türlerdir.
 *Değer türlü değişkenlerin null alabilmesi için nullable(?) olmaları gerekmektedir.
 *Örnek : int? a = null;
 *Null bellekte yer kaplamaz.
 *Null olan bir değer üzerinde işlem yapmaya çalıştığımızda run time hatası meydana gelir.
 *  ******************************************************************************
 *  
 *Empty: Bir değişken /nullable/referans eğer ki empty ise bu değişkenin değeri yok anlamına gelir.Lakin alan tahsisinde 
 *bulunulmuştur. 
 *Arsa var lakin ev yok!
 *Tümm değerlere empty atanabilir.
 *Alan tahsisinde bulunduktan sonra ilgili alana bir değer koymamak empty durumudur.
 *Empty dendiğinde akla string'e "" değerinin verilmesi gelsin yeterrr.
 *string a = ""; Bu örnek gelmeli akla. 
 *Veya string a2 = string.empty de gelebilir her iki yolda doğrudur.
 *  
 *Örnek : string b = null;
 *bool b = false; Bu örnek empty örneğidir.
 *int [] x = new int[55];
 *Empty her ne kadar değer olmasada bellekte yer kaplayacak ve bir alan tahsisinde bulunmuş olacaktır.
 *Empty olan bir değer üzerinde işlem gerçekleştirilebilir.
 */








//String İfadelerde IsNullOrEmpty Kontrolü

//Elimizdeki string ifadelerin işleme tabi tutulmadan önce kesinlikle kontrol edilmesi gerekmektedir.
//string x = ""; // Yandaki örnek empty 
//string x2 = string.Empty; // Yandaki de empty'dir. Her iki kullanım şeklide geçerli ve doğrudur.
/*
string x = "";
if(x!= "")
{

}

if (x != string.Empty)
{

}
Yukarıda ki her 2 if bloğu ile yapma da doğrudur.
*/
/*
string x = "";
if(x!= string.Empty && x!= null)
{
    // Operasyon ... 
}
*/


//IsNullOrEmpty Fonksiyonu ; Elimizdeki string ifadenin null yahut empty olup olmama durumları hakkında bir check yapar ve geriye
//bool türde bir sonuç döner.
//Eğer ki değer null yada empty ise geriye true değilse false dönecektir.
/*
string x = "";
    if (string.IsNullOrEmpty(x))
{
    // Operasyon..
}
*/








//String İfadelerde IsNullOrWhiteSpace Kontrolü
/*
 *IsNullOrWhiteSpace Fonksiyonu: Elimizdeki string ifadenin, null,empty yahut boşluk karakterlerinden ibaret olma durumunda
 *geriye bool türünde true değerini döndüren bir fonksiyondur..
 *Şeklinde boş olmayan ancak içerisini boşluklarla doldurulmuş olan değişkenlerde olacaktır. 
 */
/*
string x = "    ";
if (!string.IsNullOrWhiteSpace(x))
{
    // Gerekli operasyon...
}
*Bu kontrol hem null durumunu hem empty durumunu hem de içiboş, boşluk olan değerler üzerinde sağlanacaktır.
*/





//String RAM(Heap) İlişkisini İnceleyelim
/*
 *Bir değişkenin referans türlü olması demek STACK'teki bir referansın HEAP'teki bir nesneyi referans etmesi demektir. 
 *string ifadeler belleğim HEAP kısmında tutulurlar. string ifadelerin değeri referanas türlü olduğundan bir nesnedir. 
 *nesne de HEAP'te tutulur.dolayısıyla string değerler beleğin HEAP'inde tutulurken string değişkenler referans 
 *olduklarından dolayı STACK'te tutulacaktırlar.
 */






//String Özünde Bir char Dizisidir!

/*String ifadeler esasında bir char dizisidir.Yani yazılım açısından string ifade yoktur.Esasında karakterlerin bir araya 
 *gelmiş hali vardır.Dolayısıyla karakterleri bir araya getirebilecek yegane şey dizidir.String ifadeler yazılımsal açıdan
 *bilgisayarda bir char dizisi olarak tarif edilmekte ve o şekilde tutulmaktadır.
 *String ifadeler özünde bir char dizisi/yani dizi olmasından dolayı referans türlü değişkenlerdir.Çünkü diziler referans
 *türlüdürler.Yani nesnedirler.Yani heapte tutulurlar.
 *String ifadeler char dizisi olduklarından dolayı yapısal olarak her bir karakter baştan sona otomatik indexlenmektedir.
 *Dolayısıyla string bir ifade üzerinde bizler indexer operatörünüde kullanabilmekteyiz.
 *String özünde bir char dizisi olabilir amma velakin yapısal olarak yinede string olduğu için  Array referansına atılamaz
 *,Array ile karşılanamaz.
 */

string metin = "Şampiyon Galatasaray";
Console.WriteLine(metin[3]);
Console.WriteLine(metin.Length);