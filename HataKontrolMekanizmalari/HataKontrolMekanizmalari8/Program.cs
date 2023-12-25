

try
{
    int s1 = 0, s2 = 10;
    int a = s2 / s1;
}
catch (DivideByZeroException ex) when (3 == 3)
{
    Console.WriteLine(" Mesaj :" + ex.Message);
}



