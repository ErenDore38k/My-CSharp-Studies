//try - catch finally Bloğu

//finally bloğu try-catch yapılanmasında hata alınsada alınmasada her 2   durumda da tetiklenmesi/çalıştırılması gereken kodları yazdığımız
//bloktur.

try
{
    // Hata verebilecek kodlar buraya 
    Console.WriteLine(" Try");
}
catch
{
    // Hata alındıkdan sonra yapılacak işlemler buraya
    Console.WriteLine("catch");
}
finally
{
    // her iki durumda da çalışmasını istediğimiz kodlar buraya..
    Console.WriteLine("finally");
}

//eğer catch bloğuna düşseydik catch ve finally yazıları ekrana yazıdırılacaktı. Düşmediğimiz için try ve finally yazdırıldı.
//Eskiden çok kullanılırdı şimdi pek tercih edilmiyor.
