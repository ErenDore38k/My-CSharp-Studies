//Döngülerle String Metin İçerisindeki Her Bir Karaktere Ulaşma

string metin = "Galatasaray";
for (int i = 0; i < metin.Length; i++)
{
    if (metin[i] == 'a')
        Console.WriteLine(i);
}