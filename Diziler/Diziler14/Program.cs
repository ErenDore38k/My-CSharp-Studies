//Array Sınıfı Clear Metodu

/*Clear metodu dizi içerisindeki tüm elemanları siliyor diye biliniyor. Halbuki bu yanlıştır.Dizi içerisindeki tüm elemanlara , dizinin
 *türüne uygun default değerleri atayan bir fonksiyondur.
 */

Array isimler = new[] { "Hilmi", "Hüseyin", "Şuayip", "Rıfkı", "Hamdullah" };
Array.Clear(isimler, 0, isimler.Length);
for (int i = 0; i < isimler.Length; i++)
    Console.WriteLine(isimler.GetValue(i));