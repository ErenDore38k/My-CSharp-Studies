//Do While İle Sonsuz Döngü Nasıl Yapılır?

//Do while döngüsü ile aşağıdaki kod bloğu gibi sonsuz döngü yapabiliriz.

do
{
    Console.WriteLine("Wesley");
} while (true);


//Eğer ki sonsuz döngüden çıkmak istersek aşağıdaki gibi bir kod bloğu ile yapacağız.

/*
bool durum = true;
do
{
    if (true)
    {
        durum=!durum;
    }
} while (durum);
*/