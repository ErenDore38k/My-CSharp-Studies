//C# 7.0 Pattern Matching - Constant Pattern

//Elimizdeki veriyi sabit bir değer ile karşılaştırabilmemizi sağlar.
//is operatörü  == operatörünün görevini görüyor Constant Pattern da.
//Değersel yani bu değere eşit mi diye kontrol yapabiliriz. Türsel olarak da yapabiliriz int mi bool mı string mi gibi gibi

object x = 123;
if (x is 123)
{
    Console.WriteLine("x=123");

}


/*is operatörü bir değişkenin türünü sormamızı/belirlememizi sağlayan bir operatördür. Ve bu operatörün kullanıldığı değişkenlerin türü 
 *illa bir referans türlü olmak zorunda değildir.
 *İsterseniz değer türlü değişkenlerde de is operatörü kullanılabilmektedir.Ve hatta primitive türlerde bile kullanılabilmektedir.
 *Eğer ki is operatörüyle bir değişkenin değerini  == operatörünün sorumluluğuyla check ediyorsa işte buna Constant Pattern denmektedir. 
*/
