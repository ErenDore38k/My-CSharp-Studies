
//Switch Expressions - Tuple Patterns
//Tuple Patterns ise switch yapılanmasını Tuple nesnelerini kontrol edebilecek şekilde hem standar hemde yeni yapılanmayla 
//bizlere sunmaktadır. 

int S1 = 10;
int S2 = 20;
string Mesaj = (S1, S2) switch
{
    (5, 10) => "5 ile 10 değerleri",
    (10, 20) => "10 ile 20 değerleri",
    (_, _) => "Hiçbiri" // default
};
Console.WriteLine(Mesaj);