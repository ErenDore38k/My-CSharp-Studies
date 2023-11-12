
string x = " 123";
//Console.WriteLine(Sayı1*5 ); denersek hata verir çünkü string bir ifadetle aritmetik bir işlem yapamayuz.
//Tür dönüşümü gerek. 
int x2 = int.Parse(x);
Console.WriteLine(x2 * 5); // Şeklinde parse metodunu kullanabbilriz  . 
                           // Console.WritLine(int. parse(x) *5 ); Şeklinde de kullanım yapabirliz. 
                           // Yukarıda yapmış olduğum örnek parse metoduna göre yapılmıştur.


string y = " 25";
int y2 = Convert.ToInt32(y);