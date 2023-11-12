//ArrayList Boxing - Unboxing Durumlarından Dolayı Sınırlılıklar


//ArrayList, verilen datayı boxing işlemine tabi tutar.
//ArrayList içerisindeki herhangi bir veriyi talep ettiğimizde o veri object olarak gelecektir.Dolayısıyla kendi türünde işlem
// yapabilmek için unboxing işlemine tabi tutmamız gerekir.
//İndexer koleksiyonlarda kullanılmıyor gibi görüksede koleksiyonlarda da değer okurken kullandığımız bir aracıdır. 
//Dizilerde ise bildiğimiz gibi sürekli kullandığımız bir operatördür.
//ArrayList object olarak veri almaktadır. Bizler herhangi bir object’e değer atadığımızda bu işleme boxing demekteyiz.
//Benzer mantıkla boxing edilmiş değeri de kendi türünde elde etmek için de unboxing işlemi yapmaktayız.
//Add fonksiyonu ile de yaptığımız işlem aslında boxing işlemi yapmaktadır.
//ArrayList içerisindeki herhangi bir veri talep edildiğinde, o veri object olarak gelecektir.
//Dolayısıyla kendi öz türünde işlem yapabilmek için unboxing işlemine tabi tutmamız gerekir. Bu durumunda dizilerde olduğu 
//gibi bir handikap olduğu söyleyebiliriz.
//Bu sınırlılığı ise ileride Generic olarak öğreneceğimiz koleksiyonlar sayesinde aşılacaktır.
//Generic koleksiyonları da tıpkı ArrayList için yaptığımız varsayım gibi, ArrayList’teki bu sınırlılıklardan dolayı da Generic 
//koleksiyonları oluşturulmuş diye düşünmemizde bir sakınca olmayacaktır.
//ArrayList object’te çalıştığı için casting maliyeti ortaya çıkmaktadır.
//Koleksiyonlarda Length yerine Count property'si kullanılmaktadır. Tüm koleksiyonlarda.
//ArrayList'te tutulan değeri kullanabilmek için casting edilmesi gerekir!
/*
using System.Collections;
int toplam = 0;
ArrayList yaslar = new ArrayList();  // Koleksiyonlarda tanımlama yaparken 
yaslar.Add(123);                     // Koleksiyonlarda değer atama yaparken

for (int i = 0; i < yaslar.Count; i++)
{
    toplam += (int)yaslar[i];
}
*/




//ArrayList Collection Initializers(Koleksiyon İlklendirici)

//Dizilerdeki gibi tanımlama sırasında değer atama işlemi yapılabilir.
//ArrayList Object ile çalıştığı için atanan değerlerin türlerinin farklı olmasını önemsemez.

using System.Collections;

ArrayList takım = new ArrayList() { "Muslera", "Boey" };
for (int i = 0; i < takım.Count; i++)
{
    Console.WriteLine(takım[i]);
}