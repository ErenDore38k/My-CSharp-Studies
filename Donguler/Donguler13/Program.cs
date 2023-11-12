//While Döngüsünü İnceleyelim

/*
while (Buraya şartı yazıyoruz.) Şart doğrulandıkça tetiklenir.
{
Bu kısma da yapılacak işlemleri yazıyoruz.
}

*While döngüsü sadece şarta bağlı bir döngüdür. Şart doğrulandıkça tetiklenecektir.
*for'a nazaran daha ilkel ve sade bir döngüdür.
*While döngüsü programlamanın ilk tasarlanmış döngüsüdür.
*Genellikle sonsuz döngülerde yahut süreci bilinmeyen durumlarda kullanılan bir döngüdür. Amma velakin istediğiniz yerde kullanabilirsiniz.
*/




//While Döngüsünü For İle Kıyaslayalım

//While döngüsünde for gibi çalışabilmek için kombinasyonu kendimiz oluşturmalıyız.
//While döngüsü şart false olana kadar tetiklenecektir.

int _i = 0;   //Yandaki _i ile tanımlama yaparsak for daki gibi algılanacak .
while (_i < 10)
{
    Console.WriteLine(_i);
    _i++;
}