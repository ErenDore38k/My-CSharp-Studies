// Regular Expressions(Düzenli İfadelerde) Neyin Nesi?

/*
 *Regular Expressions : Metinsel yapılanmalarda belirli koşulları sağlayabilen ifadelerdir.
 *Metinsel ifade içerisinde ihtiyaca istinaden düzenlenir.
 *ÖRNEK: Bir metinsel ifade içerisinde @ karakteri geçen bütün aralıkları elde etmek istediğimizi varsayalım.
 *bassdseda@asm1123113'sdfs@vssfsfdggdgd
 *Dikkat ederseniz bu değerlerdeki karakerlerin uzunluğu ve ne olduğu önemli değildirr.Yeter ki  @ karakteri olsun.
 *Peki bu aralıkları nasıl elde edeceğiz? @ karakteri geçen tüm aralıkları elde etmenin çeşitl yolları olabilir.
 *Ancak şartlar arttıkça işlemi koda dökmek zorlaşacaktır.
 *MİSAL Milyonlarca  Email adresi olduğunu düşünelim. Biliyoruz ki Email belli bir formatı vardır.
 *Her Email adresi mutlaka @ ve ardından .(nokta) karakteri barındırır.Eğer birden fazla nokta varsa noktalardan biri 
 *mutlaka @ karakterinden sonra olmalıdır..
 *Örn erendore38k@gmail.com gibi 
 *Haliyle bir karakter dizisinin Email adresi olup olmadığını test etmek oldukça zor olacaktır.
 *Bu yüzden C# da bu tür düzenli ifadeleri temsil edebilmek için Regular Expressions operatörleri getirilmiştir.
 *Bu operatörler eşliğinde elde edilen verinin tasarlanan metinsel düzene uyup uymadığı değerlendirilebilmektedir.
 *Regular ifadeler System.Text.Expressions  namespace'i altındaki Regex sınıfı tarafından temsil edilmektedir.
 *Regular Expressions'lar ufak tefek farklılık olsa dahi hemen hemen tüm programlama dilllerinde olan evrensel yapılanmalardır.
 *Düzenli ifadeler başlı başına bir konudur.  YA HAYAT KURTARIRLAR YA DA ÖMÜR TÖRPÜLERLER
 * 
 */




//Regular Expressions Operatörleri ^ Operatörü, Regex Sınıfının Kullanımı

// ^Operatörü : Satır başının istenilen ifadeyle başlamasını sağlar.
// ^9  : Bu örnek hep 9 ile başlayacak. ^9bxkxbvk olsa da dahil. 9 ile başlamazsa uygun olmaz düzenli ifadelere.

using System.Text.RegularExpressions;

string metin = "123456velinaci";
Regex regex = new Regex("^1");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);
