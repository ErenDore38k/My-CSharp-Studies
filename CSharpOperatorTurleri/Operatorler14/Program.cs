

// Null Coalescing Assignment(C# 8.0)
string m = null;
Console.WriteLine(m ??= " MERHABA");

//Yukarıda ki vermiş olduğum örnekte m'in değeri null ise MERHANA yazdır ve MERHABA değerini m ye ata.
// EĞERKİ null değilse, direkt olarak m'in değerini yazdıracaktır. 
//Her iki değerde aynı türde olmak zorundadır. 