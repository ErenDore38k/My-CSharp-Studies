//Math Sınıfı - Round Fonksiyonu

//Elimizdeki ondalıklı değerin kendisine en yakın olan tam sayıya yuvarlanma işlemini sağlar.
//3.5 değerinde görüldüğü gibi bir sayıda 0.5'lik bir değer varsa yani yarım ise üst değere yuvarlanır.Bunun bir şeyin 
//yarısının yanlış olması tamamının yanlış olacağı kanısı ile düşünebiliriz.
//Sayı çift ise 2.50 ise 2 ye, tek ise 3.50 4 e yuvarlama yapılır.

double u = Math.Round(2.50);
Console.WriteLine(u);
double q = Math.Round(3.50);
Console.WriteLine(q);