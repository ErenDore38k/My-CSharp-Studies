//String Fonksiyonları - Split Metodu

//Metinsel ifadede verilen değeri ayraç olarak kullanıp, parçalayan ve sonucu string dizisi olarak döndüren bir fonksiyondur.


string metin = "Savaşa hayır ";
string[] dizi = metin.Split('a');
string[] dizi2 = metin.Split(' ');
for (int j = 0; j < dizi.Length; j++)
{
    Console.WriteLine(dizi2[j]);
}
/*
for (int i = 0; i < dizi.Length; i++)
{
    Console.WriteLine(dizi[i]);
}
*/