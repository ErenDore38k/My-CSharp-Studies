//try - catch when Yapısı İle Hata Filtreleme (C# 6.0)

try
{
    int s1 = 0, s2 = 10;
    int a = s2 / s1;
}
catch (DivideByZeroException ex) when (3 == 3)
{
    Console.WriteLine(" Mesaj :" + ex.Message);
}

//try-catch bloklarına when keywordü ile şart uyguluyabilmekteyiz.

