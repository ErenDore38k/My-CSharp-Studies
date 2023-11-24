
/*
 *Metotlarda Optional Parameters(İsteğe Bağlı Parametreler) 
 *Parametreli bir metot kullanılırken/çağrılırken/tetiklenirken parametrelerine türlerine uygun değerler gönderilmek 
 *ZORUNLUDUR. 
 *Eğer ki bir metodun parametrelerine zorunlu bir şekilde değer göndermek istemiyorsak parametreye değeri isteğimize göre/
 *opsiyonel olarak göndermek istiyorsak o parametrenin bu durumu karşılayabilecek bir özellikte olması gerekmektedir.
 *işte bu özelliğe opsiyonel parametreler denmektedir.
 *
 *Bir parametrenin opsiyonel olması demek o parametrenin varsayılan/default değeri olması demektir.
 *Metot parametrelerine =(assing) operatörü ile bir değer atanırsa eğer o parametreye varsayılan değeri atanmış olur.
 *Haliyle opsiyonel parametre haline getirilmiş olunur.
 *Tüm parametreler opsiyonel olabilir.
 *
 *Birden fazla parametre içerisinde bir kısmı opsiyonel olabilir mi?
 *CVP:Birden fazla parametre durumunda opsiyonel olanlar SAĞ tarafta tanımlanmalıdır.
 */


using System;

namespace functions
{
    class Program
    {
        static void Main(string[] args)
        {
            X(15); // Yandaki gibi sadece a ya değer verip diğerlerine vermeyebiliriz.
            // X(15,20,33) Yandaki gibide yapabiliriz. 
            
            
        }

        static public void X(int a , int b = 0,int c = 0)
        {
            Console.WriteLine($"a: {a}, b: {b}, c: {c}");
        }
    }
}