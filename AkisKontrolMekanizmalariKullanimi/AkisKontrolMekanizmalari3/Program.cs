
//Switch Case'de goto Keyword'ü
/* Switch Case yapılanmasında sadece eşitlik durumunu inceleyebildiğimiz için mantıksal bir işlem gerçekleştirememekteyiz.
 * Dolayısıyla bazen farklı değerlere eşit olma durumunda aynı operasyonu/kodu / akışı kullanacağımız senaryolarla
 * karşılaşabilmekteyiz.
 * goto keywordü bir bakımdan farklı durumlarda aynı işlemi gerçekleştireceksek orada ki kod fazlalığını tekrarını azaltmak  
 * tekrara düşmememizi sağlar. 
 * goto kullanılan case'de break komutunu kullanmıyoruz.
 * goto keywordünün kullanıldığı case'in eşleştirmesine bakmaksızın direkt olarak kodunu çalıştıracaktır.
 */

int j = 10;
switch (j)
{
    case 5:
        Console.WriteLine(j * 10);
        break;
    case 6:
        Console.WriteLine(j * 30);
        break;
    case 7:
        goto case 5;
    case 10:
        goto case 5;
}


