
//Cast Operatörü [ () ]
/*Genellikle tür dönüşümlerinde kullanılan bir operatördür. 
 * Cast operatörünü kullandığımız durumlar:
 *1: Boxing - unboxing durumunda örn: object x = 123;
int x2 = (int)x;
Yukarıda ki örnekte cast operatörünü boxing unboxing duurmunda nasıl kullanıdğımızı gösterdik.

* Cast Operatörünü kullandığımız ikinci durum ise bilinçli tür dönüşümü durumunda 
* ÖRn : int a = 5;
short b = (short)a;
Yukarıda ki örnekte cast operatörünü bilinçli tür dönüşümünde nasıl kullanırız ona dair verilmiş bir örnektir. 

* Cast operatörünü kullandığımız bir diğer durum ise char -int int -char  dönüşüm yaparken .
ÖRN: int ascii = 93;
char c = (char)ascii;
*İŞte bu üç durumda cast operatörünü kullandık . 
 */


//Sizeof Operatörü
Console.WriteLine(" int : " + sizeof(int));
Console.WriteLine(" long : " + sizeof(long));
Console.WriteLine(" decimal : " + sizeof(decimal));

// Verilen türün bellekte kaç byte'lık yer kapladığını interger olarak geriye döndürür.