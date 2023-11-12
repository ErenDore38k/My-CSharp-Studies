
//Switch Expressions - Tuple Patterns when Şartı Uygulamak

int q1 = 15;
int q2 = 25;
string mesaj = (q1, q2) switch
{
    (5, 10) when (true) => " 5 ile 10 değerleri ",
    var d when d.q1 % 2 == 1 || d.q2 == 10 => " 10 ile 20 değerleri "
};
Console.WriteLine(mesaj);
//Tuple Patterns when şartı uygulama yaparken kural tuple ile birden fazla türlerle kod yaptığımız için var keywördünü 
//kullanmak gerekir karşılayabilemsi için kesin. 


//Positional Patterns 
/*
 * Positional Patterns ise Deconstruct özelliği olan nesneleri kıyaslamak yahut değersel karşılaştırmak için 
*kullanılan bir gelişimdir. 
*/

//Property Patterns
/*
 * Property Patterns nesnenin propertylerine girerek belirli durumları hızlı bir şekilde kontrol etmemizi gerçekleştiren
 * ve bunu farklı değerler için birden fazla kez tekrarlı bir şekilde yapmamıza olanak sağlayan güzel bir gelişimdir. 
 */
