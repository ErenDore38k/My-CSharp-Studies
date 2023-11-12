//if Yapisi Örnek2
//Girilen sayının negatif yada pozitif oldugunu gösteren uygulamayı yazalım.

int SAYI = int.Parse(Console.ReadLine());
string Sonuç = "";
if (SAYI < 0)
{
    Sonuç = "Negatif";
}
else
    Sonuç = "Pozitif";
Console.WriteLine(Sonuç);
