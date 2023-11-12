
int xx = 3000;
short yy = (short)xx;

/* Yukarıda yapmış olduğum örnek biliçli tür dönüşümüne örnekk vermek amacıyla yapılmıştır.
 * Bilinçli türde ki mantık biliçsizdekine göre tersi bu sefer daha küçük olana yollamaya çalışıyoruz . 
 * Ama burda sorumluluk bize ait çünkü bu dönüşümü yaparken veri kaybı yaşama ihtimalimiz var bu yüzden mesuliyet bizde
 * Herhangi bir veri kaybı olması sorumluluğunu göz önüne alarak yaptığımızdan dolayı bilinçli diyorız.
 Yukarıda ki vermiş olduğum örnekte veri kaybı yaşamadık ama bir sonraki örnek ona yönelik olacaktır.  
 */


int xxx = 60000;
short yyy = (short)xxx;
Console.WriteLine(yyy);
//Yukarıda veröiş olduğum örnek veri kaybı yaşanabilecek duruma örnek olması için verilmiştir. 
//Buradan anlaşılması gerekn dip not veri kaybı oluşması için bazı sınırlar vardır o sınırları aşmadığın müddetçe veri kaybı olmaz.