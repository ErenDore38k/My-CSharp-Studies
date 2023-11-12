//Regular Expressions Operatörleri \ Operatörü

// \ Operatörü: Belirli karakter gruplarını içermesini isteniyorsa kullanılır.
// Sola yatık sılaş operaötrü tek başına kullanılmaz yanına aldığı parametreler ile kullanılır BU PARAMETRELER: 
// \D : Metinsel değerin ilgili yerinde rakam olmayan tek bir karakterin bulunması gerektiği belirtilir..
// \d : Metinsel değerin ilgili yerinde 0-9 arasında tek bir sayı olacağı ifade edilir.
// \W : Metinsel değerin ilgili yerinde alfanümerik olmayan karakterin olması gerektiği belirtilir. Alfanümerik karakterler: 
// a-z A-Z 0-9 
// \w : Metinsel değerin ilgili yerinde alfanümerik olan karakterin olacağı ifade edilir.
// \S : Metinsel değerin ilgili yerinde boşluk karakterleri (tab/space) dışında herhangi bir karakterin olamayacağı  belirtilir.
// \s : Metinsel değerin ilgili yerinde sadece boşluk karakterinin oalcağı ifade edilir.


//ÖRN: 9 ile başlayan, ikinci karakteri herhangi bir sayı olan ve son karakteri de boşluk olmayan bir düzenli ifade oluşturalım.
// ^9\d\S Yukarıdaki örneğe göre kullanacağımız düzenli ifadeler.

using System.Text.RegularExpressions;

string metin = "9365552gddfhfhfh";
Regex regex = new Regex(@"^9\d\S");
Match match = regex.Match(metin);
Console.WriteLine(match.Success);
