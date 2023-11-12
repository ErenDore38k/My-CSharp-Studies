//Dizi İçerisinde Döngüyle Dönme Kritik

/*Dizi içerisinde dönecek olan döngü kombinasyonunda dizinin eleman sayısını manuel bir şekilde kullanmamalı, bu sayısal değeri
 *dizinin kendisinden almalıyız.
 *lenght:Dizinin kaç elemanlı olduğunu int olarak geriye döndürür.
 */

string[] personeller = new string[13];
personeller[0] = "Hilmi";
personeller[1] = "Hüseyin";
personeller[2] = "Rıfkı";
personeller[3] = "Şuayip";
personeller[4] = "Efkan";
personeller[5] = "Elif";
personeller[6] = "Ufuk";
personeller[7] = "Necmi";
personeller[8] = "Necati";
personeller[9] = "Arif";
personeller[10] = "Elif";
personeller[11] = "Ayşe";
personeller[12] = "Reyyan";

for (int i = 0; i < personeller.Length; i++)
{
    Console.WriteLine(personeller[i]);
}
