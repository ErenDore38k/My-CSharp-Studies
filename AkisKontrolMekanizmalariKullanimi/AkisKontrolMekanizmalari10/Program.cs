//if else Yapısı

/*if yapısı: Şarta göre bir kodun calışıp çalışmayacağını belirleyen bir yapılanma.
 *if else yapısı : Şarta göre bir kodun calışıp, şartın olmadığı durumda bir başka kodun çalışmasını belirleyen bir yapılanma.
 *Özetle if yapısında doğruysa belirlenen şart gerçekleşir değilse bir şey olmaz ekrana çıktı verilmez. 
 *İf else yapısında ise doğruysa yapılacak bir şart var değilse yanlışsa yapılacak bir şart var. 
 *İf bloğunda else varsa , şartın false olması durumunda kesinlikle else bloğu tetiklenir.
 *İf else yapılanmasında şart doğru olduğunda sadece if, yanlış olduğunda ise sadece else blokları tetiklenir.
 */

int e = 10;
if (e > 5)
{
    Console.WriteLine(" e değeri 5 'ten büyüktür");
}
else
{
    Console.WriteLine(" e değeri 5'ten küçüktür.");
}