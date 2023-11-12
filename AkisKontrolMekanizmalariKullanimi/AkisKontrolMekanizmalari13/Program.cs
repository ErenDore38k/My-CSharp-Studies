// if Else if Yapısı

/*if else if yapısı birden fazla şartı konrol etmemizi sağlayan bir yapılanmadır. 
 *eğer hava yağmurluysa bunu yap 
 *yok yağmurlu değilse kapalıysa bunu yap
 *yok kaplı değilse karlıysa bunu yap
 *Yukarıda verdiğim mini örnekteki mantık üzerinden yürür if else if yapısı. 
 */

int yas = 85;
if (yas < 18)
{
    Console.WriteLine(" Sen reşit değilsin çocuksun");
}
else if (yas >= 18 && yas <= 35)
{
    Console.WriteLine(" Sen genç bir bireysin ");
}
else if (yas >= 35 && yas < 64)
{
    Console.WriteLine(" Sen orta yaşlı bir bireysin");
}
else if (yas >= 65)
{
    Console.WriteLine(" Sen 65 yaş üstü bir bireysin ");
}
