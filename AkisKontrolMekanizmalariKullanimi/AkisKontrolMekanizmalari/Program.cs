
//Akış Kontrol Mekanizmaları Nelerdir? Ne Amaçla Kullanılırlar?
/*Akış kontrol mekanizmaları , kodun akış sürecinde belirli şartlara göre farklı yönlendirmeleri yapmamızı ve farklı 
 *algoritmaları , kodları yapılanmaları çalıştırmamızı sağlayan mekanizmalardır. 
 *2 TANE MEKANİZMA VARDIR : if-else ve switch 
 *Yazılım kodunun akış sürecinde şarta göre yönlendirilmesini sağlamaktadır. 
 *Algoritmalarda ciddi manada kullanılan yapılanmalardır. O yüzden yazılımcılar için olmazsa olmazdır. 
 *Akış kontrol mekanizmalarında if-else yahut switch yapılanmaları aynı işi farklı şekilde yapmamızı sağlayan
 *birbirinden farklı yapılanmalardır. 
 *İkisi arasında teknik olarak fark olsa da işleyiş kullanım açısından bir fark yoktur. 
 *Uzaya füzede atsan akış kontrol mekanizmalarına ihtiyaç duyarsın . 
 */


//SWITCH - CASE
/*Switch case , kodun akışında belirli bir şarta göre yönlendirme yapmamızı (farklı algoritma calıştırmamızı / farklı 
 *operasyon gerçekleştirmemizi / tetiklememizi ) sağlayan yapılanmadır. 
 *Switch case yapılanması sadece bir değişkenin değerini sadece eşitlik durumlarını kontrol ederken kullanılabilir.
 *Sadece eşitlik durumu check edilecekse o zaman switch kulllanılabilir. 
 *Kontrol edilen değerin türü ne ise case bloklarında da aynı türde değerlerle kontrol edilmelidir.
 *Switch parantezinde kontrol edilen değer bir değişken yahut sabit/statik bir değer olabilirken 
 *case bloklarındaki değerler kesinlikle sabit/statik olmak zorudadır. Caselerdeki değerler değişkenlerden alınmaz!!!
 *Default case bloklarından hiçbiri eşleştirmeye uymuyorsa eğer varsa default bloğu tetiklenir..
 *Case bloklarının sıralaması ve default'un yerleştirildiği yer önemli değildir.
 */

string adi = "Ahmet";
switch (adi)
{
    case "Ahmet":
        Console.WriteLine(" Adı Ahmet");
        break;
    case "Ali":
        Console.WriteLine(" Adı Ali ");
        break;
    case "Hilmi":
        Console.WriteLine(" Adı Hilmi ");
        break;
    default:
        Console.WriteLine(" Hiçbiri değil ");
        break;
}