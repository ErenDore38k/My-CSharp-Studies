//String Interpolation İle Verbatim String Birlikteliği (C# 8.0)

// @ operatörü ile $ operatörü birlikte kullanılıyorsa önce @ operatörü sonra $ operatörü bildirilmelidir.

string isim = "Veli", soyisim = "Dalcı", siparisNo = "19053834";
int fiyat = 65;
string mesaj = @$" Merhaba {isim} {soyisim} 
{siparisNo} sipariş nolu talebiniz tarafımızca alınmıştır.
Fiyat : {fiyat}";
Console.WriteLine(mesaj);

//Verbatim operatöünü kullanıyorsak escape kaşış karakterlerini kullanmayız kullanmamalıyız.