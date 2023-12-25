

string metin = "Savaşa hayır ";
string[] dizi = metin.Split('a');
string[] dizi2 = metin.Split(' ');
for (int j = 0; j < dizi.Length; j++)
{
    Console.WriteLine(dizi2[j]);
}
