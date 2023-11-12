//CreateInstance Metodu İle Dizi Tanımlama

//int[] Yaslar = new int[3];
//Normalde yukarıdaki gibi yapılan dizi tanımlaması esasında arka planda Array sınıfının CreateInstance metodunu kullanmaktadır.
//Bizlerde bu metodu kullanarak fonksiyonel diziler oluşturabilmekteyiz.
Array yaslar = Array.CreateInstance(typeof(int), 3);

// Elemanları atama
yaslar.SetValue(25, 0);
yaslar.SetValue(30, 1);
yaslar.SetValue(35, 2);

// Elemanları ekrana yazdırma
for (int i = 0; i < yaslar.Length; i++)
{
    Console.WriteLine(yaslar.GetValue(i));
}
