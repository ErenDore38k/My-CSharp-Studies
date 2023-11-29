
/*
 *C#'ta Ref Returns Özelliği Nedir? Ne Amaçla Kullanılmaktadır?
 *Ref Returns özelliği sadece metotlarda geçerlidir.Çünkü returns(geri döndürme) yaptığımızdan dolayı returns da metotlarda yapılır.
 *Metotlar geriye değer döndürebilen yapılardır.Ayrıca metotlarda geriye nesnelerde döndürebilmekteyiz.Ayrıca ref returns özelliği
 *sayesinde değer türlü değişkenlerin referanslarınıda geriye döndürebilmekteyiz.
 * 
 */

int a = 5;
int b =  X( ref a);
Console.WriteLine(a);
Console.WriteLine(b);
 ref int X( ref int y)
{
    y = 25;
    return ref y;
}