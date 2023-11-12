//Scopesuz If Yapısı

/*if yapılanması tek satırlık/ konseptlik bir işlem gerçekleştiriliyorsa eger bunu scope içerisinde yazmak mecburiyetinde değiliz.
 *Scope kullanmadığımız için herhangi bir performans kaybı yaşamayız . Kod daha derli daha düzgün görünmesi için kullanırız.
 *Tercih bize kalmış.
 *Eğer ki birden fazla konsept/ operasyon/işlem barındıracaksa bunları kesinlikle scope içerisine almamız gerekmektedir.
 *Aksi takdirde scopesuz çalısırsa ilk işlemi if bloğu alacak diğerlerini almayacaktır.
 */

bool takım = true;
if (takım == true)
    Console.WriteLine(" Sen Galatasaraylısın");

