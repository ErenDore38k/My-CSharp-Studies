//Dizi İçerisinde Döngüyle Dönme

/* Diziler genellikle döngülerle birlikte algoritmalarda kullanılmaktadırlar/işlenmektedirler. 
 * Döngülerde genellikle dizilerle ya da ileride göreceğimiz koleksiyonlarla birliktede kullanılmaktadırlar.
 */

string[] personeller = new string[10];
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


for (int i = 0; i < 10; i++)
{
    Console.WriteLine(personeller[i]);
}


