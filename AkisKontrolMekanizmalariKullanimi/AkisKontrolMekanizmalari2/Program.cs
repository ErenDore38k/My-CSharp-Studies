
/*Switch yapılanmasında sadece elimizdeki değerin eşitlik durumunu kontrol edebilmekteyiz.Bunun dışında bu kontrol esnasında 
 *farklı şartlarıda değerlendirmek istiyorsak eğer when keywordünü kullanabiliriz.
 *When switch'i zenginleştiren özel bir keyworddür.
 *Eşitlik durumu için kontrol yaparken başka şartları da gözetim altına alabiliriz. 
*/

int satisTutar = 1000;
switch (satisTutar)
{
    case 1000 when (3 == 5):

        break;
    case 1000 when (3 == 3):

        break;
}
//Yukarıda ki örnekte olduğu gibi kullanım yapabiliriz.
