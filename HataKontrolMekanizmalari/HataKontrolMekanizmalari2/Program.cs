//try - catch Mekanizması Teorik Anlatım

/*Çalışma zamanında alınan olası hataları kontrol etmemizi, karsılamamızı , manipüle etmemizi sağlayan bir yapılanmadır.
 *try -catch yapılanması uygulama sürecinde yaşanan olası hatayı kullanıcıya hissettirmeksizin farklı bir durum ya da olağan bir mesaj gibi
 *göstermemizi sağlayan ve bunun yanında patlamaya/hataya dair bizlere bilgi sunan ve böylece bu bilgiler eşliğinde kayıtlar/log
 *oluşturmamızı sağlayan bir programmatik yapılanmadır.
 *try - catch mekanizmasının amacı : 
 *1) Kullanıcıya alınan hatayı hissettirmemek. 
 *2) Alınan hatanın nedenine dair kullanıcıyı bilgilendirmek . 
 *3) İşletim sistemleri aykırı durum yaşandığında uygulamayı sonlandırmak isterler ve sonlandırırlar . try- catch yapılanması ile alınan hataya
 *dair bir manipülasyon gerçekleştiriliyor ve uygulamanın kapanmadan devem edilmesi sağlanabiliyor.
 * PROTOTİPi İskelteti 
 * Try 
 * {
 * Olası çalışma zamanı hatalarını verebilecek kodları buraya yazıyoruz.
 * } 
 * catch
 * {
 *try içerinde olası hata söz konusuysa kodun akışı orada kesilecek ve catch bloğundan devam edecektir.
 * 
 * }
 */




//try - catch Mekanizması Pratik Anlatım

/*
try
{
    // Olası çalışma zamanı hatalarını barındırıan/ verebilecek olan kodları buraya yazıyoruz.
}
catch
{
    // try içerisinde bir hata söz konusu olduğunda catch bloğu tetiklenecektir.
    // hataya dair; log, kullanıcı bilgilendirme, kontorollü kapanış vs. 
}
*/

try
{
    Console.WriteLine("Lütfen birinci sayiyi giriniz :");
    int sayi1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Lütfen ikinci sayiyi giriniz :");
    int sayi2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Toplam : " + (sayi1 + sayi2));

}
catch
{
    Console.WriteLine("Lütfen doğru bir ifade giriniz .");

}
