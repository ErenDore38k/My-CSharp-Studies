
/* 
 * Bir sayısal tüürn kendisinden daha geniş aralıktaki  bir başka sayısal türe atanması bilinçsiz tür dönüşümüdür. 
örn: int aa = 300;
float f = aa;

 Yukarıda yapmış olduğum örnek bilinçsiz tür dönüşümüne örnektir. çünkü Float'ın değer aralığı int den daha geniştir.
 * Burada developer ın iradesi söz konusu değildir bizim sorumluluk alanımıza girmiyor . Çünkü burada float int den gelen
 * değeri her türlü karşılama yapabilir yani burada %100 güvence var ve hiç risk yok bu sebepten ötürü bilinçsiz tür dönüşümü
 * deriz. 
 * Bir tane daha örnek vermek istiyorum :
 * short x = 123;
 * long y = x ;
 * Bu yukarıda ki örnek de bilinçsiz tür dönüşümü kapsamına girmektedir.
*/


short x = 123;
long y = x;
Console.WriteLine(y);