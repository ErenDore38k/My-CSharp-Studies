//Dizilerde Verisel Performans Nedir?


/*
*Bir referans tarafından işaretlenmiş herhangi bir dizi düşünelim.
 *int[] sayılar = { 10,20,30,40,50,60,70,80,90,100};
*Bu dizi tanımlandığında Ram de bir alan tahsisinde bulunacaktır.
 *Bu dizinin belli bir değer aralığında çalışmak istersek Range and Indices özelliğini kullanabilir ve istediğimiz değer 
 *aralığı elde edebiliriz.
 *int[] sayılar = { 10,20,30,40,50,60,70,80,90,100};
*int[] sayılar2 = sayılar[2..5]; // Böyle yaparsak 30 ile 70 arasındaki değerler elde edilir.
*ilgili alan ayrı bir dizi olarak elde edilecek ve değerler RAM'De tekrardan tahsis edilecektir.
*Böyle bir durumda aklımıza şu soru gelmektedir: Zaten var olan dizinin dışında neden başka dizi tanımlandı? Bu 
*ekstradan maliyet değil mi? CEVAP: Evet bir maliyettir.
*Esasında diziler üzerinde işlem yapmak oldukça maliyetli olabilmektedir.
*Çünkü dizi üzerinde bir alanı temsil etmek, esasında o alandaki verileri yeni bir diziye koyarak tekrar etmek demektir.
*Özellikle bu maliyetli durumlar string değerler için fazlasıyla geçerlidir.
*Çünkü string değerler için kullanılan string fonksiyonları arkaplanda sürekli yeni diziler oluşturmakta ve yüksek maliyetli 
*olmaktadırlar. 
**Örn: string metin= "sebepsiz bos yere ayrılacsksan.. ";
*     string metin2 = metin.Substring(2,5);
*     string metin3 = metin.Trim();
*     
* Hatta string ifadeleri +operatörüyle birleştirmek sonuç olarak eldeki string değerleri arttıracağından dolayı muazzam bir 
* bellek israfına yol açmakta ve maliyeti arttırmaktadır. Bundan dolayı string birleştirmeler +operatörüyle tavsiye
*edilmemektedir.
*/

String metin = "Fransa"; String metin2 = "Horoz";
Console.WriteLine(metin + "" + metin2);

//İşte, diziler üzerinde yapılan çalışmalarda bu maliyeti ortadan kaldırabilmek ve daha performanslı çalışabilmek için 
//ArraySegment ve StringSegment türleri geliştirilmiştir.    
//Bu türler yapısal olarak dizi yahut string ifadelerdeki bir bölümü  temsil etmemizi sağlayan ve bütünsel açıdan ilgili veri
//kümesini parça parça birden fazla referans eşliğinde yönetmemize imkan veren türlerdir.

