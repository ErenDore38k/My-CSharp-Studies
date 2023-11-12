
//as Operatörü
/* Cast Operatörünün unboxing işlemine altarnetif olarak üretilmiş bir operatördür.
 * Türüne uygun bir şekilde  as edilmesi zaruri değildir. Eğer ki tür uygunsa unboxing işlemi başarıyla yapılacak 
 * yok eğer tür uygun değilse hata vermeyecek  null değer döndürecektir. 
 * Bu durumda parogmatik olarak yazılımın sonlanmadan akışta kontrol edilmesine müsaade edecek ve işlem devam edecektir.
 * As operatörü tür uygun olmadığı takdirde geriye null döndüreceği için bu null'u karşılayabilen türlerle çalışmak isteyecektir.
 * haliyle as operatörü değer türlü değişkenlerde kullanılmaz.
*/


//Nullable Operatörü [ ? ]
/*c# programlama dilinde değer türlü değişkenler normal şartlarda null değer alamazlar(Not Nullable).
 * Bir değer türlü değişkenin null değer alabilmesi için (yani nullable olabilmesi için ) ? kullanılması gerekmektedir
int? q = null;
bool? w = null;
// Yukarıda ki örnekte değer türlü bir değişken var ve biz onu null yapmaya çalışıyoruz normalde hata verir ama 
// ? nullable operatörü sayesinde değer türlü olsa bile nullable operatörü ile yapabiliriz. Ve değişkenimiz artık referans türlü
// gibi davranış sergiler. Ve Yukarıda ki gibi bir kullanım şekli yaparız. 
// Değişken türü ? değişken adı  yandaki formatta tanımlanan değişkenler null değer alabilirler. 
 Bir değer türü değişken nullable yapıldıysa eğer; is null, is not null , as gibi null ile çalışan operatörleri üzerinde 
 * kullanabilirz.
 */



//Null Coalescing Operatörü

//Elimizdeki değişkenin değerinin null olma durumuna istinaden farklı bir değeri göndermemizi sağlayan operatördür.
string o = " Tete";
Console.WriteLine(o ?? " Nörüyon ");

//Yukarıda ki örnekte olduğu gibi bir kullanım şekli yapabiliriz. Eğer o değişkenim null olsaydı nörüyon yazdıracaktı ekrana .
//Null Coalescing Operatöründe her iki taraftaki değişken yahut değer aynı türde olmalıdır. Yoksa derleyici hata verecektir.
