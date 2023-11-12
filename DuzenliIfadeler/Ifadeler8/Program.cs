//Regular Expressions Operatörleri \b - \B Operatörleri

// \B: Bu ifade ile kelimelerin başında ya da sonunda olmaması gereken karakterler bildirilir.
// \b :Bu ifade ilgili kelimelerin belirtilen karakter dizisi ile  sonlanmasını sağlar.


//\d{3}dır\B   Yandaki düzenli ifadenin açıklaması şudur örneğimiz 0-9 arasında bir rakamla başlayacak 3 tane rakam girilecek ve
// cümle dır ile BAŞLAMAYACAK VE  BİTMEYECEK. Mesela cümle 123dır5 ile bitebilir.

using System.Text.RegularExpressions;

string metin = "123dır65";
Regex regex = new Regex(@"\d{3}dır\B");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);


