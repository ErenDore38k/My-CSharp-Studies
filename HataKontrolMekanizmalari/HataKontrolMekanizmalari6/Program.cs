//try - catch Birden Çok Catch Durumu

try
{
    int s1 = 0, s2 = 10; // DvideByZeroException Hata türü
    int a = s2 / s1;       // DvideByZeroException Hata türü
    int.Parse("Selam"); // FormatException Hata Türü
}
catch (DivideByZeroException ex)
{



}
catch (FormatException ex)  // FormatException hatasını karşılacak olan catch tanımlanmış oldu.
{

}
catch (Exception ex)
{

}

//catch bloklarının en sonuna Exception türünde parametre(catch) tanımlarsan alınan hata üsteki türlerden herhangi biri değilse kesinlikle
//bu Exception tarafından karşılanabilir olacağından dolayı en kötü buraya girecektir.
//Anlaşılıyor ki try-catch yapılanması olası run time hatası alındığında catch sıralamasına göre kontrol etmektedir. Bu sıralama önemlidir.
//Eğer ki birden fazla catch bloğunun tanımlanmasında exception kullanılıcaksa bu Exception'nın en sona tanımlanması gerekmektedir.

/*Yukarıdaki 2 farklı hata türü örneğinde biz catch bloğuna parantez içerisinse (Exception ex ) ile bir kullanım yaparsak Exception her 2 
 *ihtimaldede aynı davranışı sergiliyecektir. Dolayısıyla farklı türlerde ki hata durumlarında bu şekilde bir fark yaratamayız
 *catch bloğuna DvideByZeroException yazarsak da DvideByZeroException hatası alındığında bu hatayı karşılıyacak olan catch haline getirilmiş
 *oldu...
 *Bu catchların dışında farklı bir türde hata alınırsa eğer o hatayıda karşılıyan bir catch bloğu tanımlanmalıdır.
 */