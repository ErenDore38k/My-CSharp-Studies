//try - catch Mekanizması Kritik Yapalım
//Try - catch yapılanması olası hatanın ihtimal olduğu kodları durmadan kontrol eden maliyetli bir yapıdır.
// Dolasıyla try içerisinde kontrol edilen kodlar luzumsuz yere tüm kodlar olmamalıdır
//Sadece olası hata verebilecek kodları barındıran bir yaklaşım sergilememiz kontrol maliyeti açısından daha verimli ve performanslı
//olacaktır.

Console.WriteLine("Lütfen birinci sayiyi giriniz :");
int sayi1 = 0, sayi2 = 0;
try
{

    sayi1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Lütfen ikinci sayiyi giriniz :");
    sayi2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Toplam : " + (sayi1 + sayi2));

}
catch
{
    Console.WriteLine("Lütfen doğru bir ifade giriniz .");
    return;

}