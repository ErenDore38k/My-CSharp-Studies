//Array Türünden Dizilere Değer Atama Okuma

//1.Yöntem aşağıdaki gibidir. Bu yöntem pek pratik değil.
/*
int[] dizi  =new int[3];
dizi[0] = 25;
dizi[1] = 36;
dizi[2] = 47;
Array dizi2 = dizi; 
*/

//2.Yöntem Bu yöntem de pek kullanışlı değil. 
//Array dizi = new int[] { 3, 6, 9, 12, 15, 18 };
// Array dizi = new int[6] {3,6,9,12,15,18};
//Array dizi = new[] { 3, 6, 9, 12, 15, 18 };


//3.Yöntem 
/*
Array dizi = new int[3];
dizi.SetValue(120, 0);
dizi.SetValue(258, 1);
dizi.SetValue(369, 2);
*/


//Değer okuma kısmı aşagıdaki gibi olacak

Array dizi = new int[2];
dizi.SetValue(120, 0);
dizi.SetValue(258, 1);
object value = dizi.GetValue(0);
Console.WriteLine(value);

