
int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
Span<int> span = new Span<int>(sayilar);
Span<int> span2 = sayilar;
Span<int> span3 = new Span<int>(sayilar, 3, 5);
Span<int> span4 = sayilar.AsSpan();
Span<int> span5 = sayilar.AsSpan(3, 5);

string metin = "Sen kalbimde batan güneş , ben yollarda çilekeş..";
ReadOnlySpan<char> readOnlySpan = metin.AsSpan();
Console.WriteLine(readOnlySpan.ToString());