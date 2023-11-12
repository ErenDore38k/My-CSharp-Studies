//For Döngüsü Örnek Yapalım2

//Klavyeden girilen sayının faktöriyelini bulan programı yapalım.

int faktoriyel = 1;
int sayi = int.Parse(Console.ReadLine());
for (int i = 1; i <= sayi; i++)
{
    faktoriyel *= i;
}
Console.WriteLine("faktöriyel: " + faktoriyel);


