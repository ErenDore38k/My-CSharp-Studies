//try - catch Hata Parametreleri

//Çalışma zamanında alınan hataya dair bizlere bilgi veren/taşıyan parametrelerdir....
//Run Time'da hata alındğında bunu editör üzerinde görebilmekteyiz. Burada görülen DivideByZeroException bizim aldığımız karşılaştığımız
//hatanın türünü ifade etmektedir. Alınan hatanın yapısına/ fıtratına göre hata türü fırlatılacaktır.

int s1 = 0, s2 = 10; //Bir sayıyı sıfıra bölmeye kalktığımızda DivideByZeroException hata türünü göreceğiz . 
int a = s2/s1;


object x = null;
x.ToString();    // Null olan bir değeri  üzerinde dönüştürme  çalışma/işlem yapmaya kalktığımız için  NullReferenceException hatasını alacağız
// En popüler olan hata türlerinden biridir.


int.Parse("stknkdkd"); //Elimizdeki herhangi bir metinsel ifadeyi sayısal bir ifadeye convert/ parse ederken de FormatException hatasını
//alırız.Bu hata uygun olmayan format anlamındadır.

try
{
    int k1 = 0, k2 = 10;
    int z = k2 / k1;
}
catch (Exception ex) // Bu parametre üzerinden bizler alınan hataya dair bilgiler edinebilmekte ve gerekli loglama vs gibi operasyonları gerçekleştirebilmekteyiz.
// (Exception ex) bu parametre catch bloğuna yazılmak/tanımlanmak zorunda değildir.eğer ki tanımlama yapılırsa hataya dair bilgi alabiliriz.
// yok eğer tanımlama yapılmazsa hata neticesinde catch çalışacak lakin bilgi alamayacağız.
{
    Console.WriteLine(" Mesaj :" + ex.Message);
}





