//Algoritmada Manevra Yapmamızı Sağlayan Komutlarda Neyin Nesi

/*Kodu durdurmak,devamını okumamak,var olan bir döngüden cıkış yapmak yahut komple metodu sonlandırmak yani kodun yönlendirmek için 
 *kullanılan komutlardır. 
 *Manevratik komutlar yapamayacağımız şeyleri yapmamızı sağlayan komutlar değildir.
 *Yapabileceğimiz manevraları/kodun yönlendirmelerini daha efektif yapmamızı sağlar.
 *4 Tane manevratik komutumuz var : break,Contınue , return, go to olmak üzere 4 tanedir.
 */




/*Break komumtu 2 yerde kullanılmaktadır : Switch Case ve döngülerde kullanılan bir keyworddür.
 *Foreach de de kullanırız iterasyon olmasına rağmen ..
 *İç içe döngülerde de kullanabiliriz.
 *Break komutu aslında şartlı durumlarda kullanım yapılır.
 *Kullanıldığı yapıdan cıkış yapılmasını / kullandığı yapıyı sonlandırmaya yarayan bir keyworddür.
 */


//Switch yapılanmasında aşağıdaki gibi bir kulllanım yaparız.
switch (10)
{
    case 5:
        Console.WriteLine("Doğru Veri girişi");
        break;
    case 10:
        Console.WriteLine("Doğru veri Girişi");
        break;
    case 12:
        Console.WriteLine("Doğru veri girişi");
        break;
    }
