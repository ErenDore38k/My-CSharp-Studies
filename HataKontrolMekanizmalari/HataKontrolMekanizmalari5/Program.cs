//try - catch Hata Türleri

//Bütün hata türleri Exception tarafından karşılanabilir.
//Exception tüm hata türlerinin atasıdır.



try
{
    int s1 = 0, s2 = 10;
    int a = s2 / s1;
}
catch (Exception ex) // Bu parametre üzerinden bizler alınan hataya dair bilgiler edinebilmekte ve gerekli loglama vs gibi operasyonları gerçekleştirebilmekteyiz.
//(Exception ex) bu parametre catch bloğuna yazılmak/tanımlanmak zorunda değildir.eğer ki tanımlama yapılırsa hataya dair bilgi alabiliriz.
//yok eğer tanımlama yapılmazsa hata neticesinde catch çalışacak lakin bilgi alamayacağız.
{
    Console.WriteLine(" Mesaj :" + ex.Message);
}

/*catch bloğu bir parametre tanımlanmazsa eğer tümm hataları karşılayabilen bir bloktur.Eğer ki parametre tanımlanır ve bu parametrenin
 *türü exception'sa yine tüm hataları karşılıyabilecektir.
 *Eğer ki,  parametre  exception değil özelleştirilmiş bir hataya indirgenmişse böyle bir durumda sadece ilgili türe ait hataları yakalayabilecek
 *karşılıyabilecektir.
 *catch bloğu eğer ki bir türe özgü ise (genel olmayan ) böyle bir durumda sadece o türden hataları yakalayabilen bir yapı haline gelmektedir.
 *Dolayısıyla try-catch bloğu hangi parametre tanımlandıysa o parametrenin yakalayabileceği türdeki hataları manupüle etmekte eğer ki
 *parametrenin dışında farklı bir türde hata fırlatılırsa try-catch bloğu ilgili hatayı manipüle etmeyecek ve fiziksel olarak uygulamayı
 *patlatıp sonlandıracaktır.
 *Çözüm olarak bu durumda birden fazla catch bloğu ile diğer türdeki parametreleri kontrol etmek olacaktır.
 *Dikkat edersek catch bloğu parametre'nin türüyle bağdaşmaktadır..
 */