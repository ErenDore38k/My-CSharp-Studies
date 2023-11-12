//Array Sınıfı Nedir? Ne Amaçla Kullanılır?

//Dizi = Array sınıfı diyebiliriz.

/*Dizi olarak tanımlanan değişkenler Array sınıfından türetilmektedirler.
 * Dolayısıyla dizilerde Array sınıfından gelen belirli metotlar ve özellikler mevcuttur.
 */

int[] yaslar = new int[3];
Array yaşlar = new int[3];




//Bir Dizinin Kendi Türünde Tanımlanmasıyla Array Türünde Tanımlanması Arasındaki Fark Nedir?

int[] a = new int[5];
/*Dizi eğer ki kendi türünde referans ediliyorsa indexer operatörü kullanılabilir.
 *Bu şekilde çalışıldığında ilgili diziye verisel müdahaleler operatif gerçekleştirilirken
 *Genellikle bu format algoritmalarda tercih edilir. Çünkü indexer algoritmalarda çok kullanılır.
 * ************************************************************************************************
 *Array a2 = new int[5];
 *Yok eğer Array türünde referans ediliyorsa indexer operatörü kullanılamaz.
 *Bu şekilde ise fonksiyonel çözümler getirilmektedir.
 *Genellikle elimizdeki dizi üzerinde işlem yaparken tercih edilen formattır. Dizi hakkında bilgiedinirken  vs kullanılır.
*/





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

