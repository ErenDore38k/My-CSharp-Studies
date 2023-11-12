
//!operatörü genel anlamda değili olumsuzluğu ifade eder. 
// Mantıksal yapılarda olumsuzluğu ifade eder. örn : !true dersek bu false evrilir false anlamına gelir
//!false dersek de true anlamına dönüşür. Normalde == eşittir anlamına gelen operatörüdür ama 
//!= dersek eşit değildir anlamıma gelmektedir örnek vermek gerekirse : 3 != 5  burada 3 5 e eşit değil anlamı çıkar.

int k1 = 85;
int k2 = 98;
Console.WriteLine(k1 != k2);

//Böylede bir kullaım yapabilirz : Console.WriteLine(!(k1==k2 )); ŞEklinde de kullanım yapabiliriz. 
//Yukarıda ki örnekte görüldüğü üzere k1 k2 ye eşit değildir eğer biz == operatörünü kullansak false yazacaktı 
//ama biz != kullanarak eşit değildir anlamını yükledik ve True yani doğru anlamını ekrana çıktı oalrak verebildik. 