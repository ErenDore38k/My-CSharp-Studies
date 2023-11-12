//While Döngüsü Kritik yapalım5

//O anki tarihinin saniye değeri 5'in katıysa eğer tarihi ekranda gösteren uygulamayı yazalım.

while (true)
{
    if (DateTime.Now.Second % 5 == 0)
        Console.WriteLine(DateTime.Now);
}
