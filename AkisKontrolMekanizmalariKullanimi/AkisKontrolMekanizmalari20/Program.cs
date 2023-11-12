
//C# 7.0 Pattern Matching - Type Pattern Kritik Yapalım

object x = " Eren";
if (x is string a)
{
    Console.WriteLine(a);
}
else if (x is int b)
{
    Console.WriteLine(b);
}

//a diyemeyiz başka bir isimlendirme yapmalıyız örn b gibi gibi.
//a = " Goat";
//Console.WriteLine( a );
//İf bloğunun içinde yazdırabiliriz ama dışıda null olma ihtimalinden dolayı yazdıramayız. Değer verirken sıkıntı yaşamayız. 
//Eğer x değişkeni string değilse. 