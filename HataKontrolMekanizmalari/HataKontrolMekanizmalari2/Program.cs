

try
{
    Console.WriteLine("Lütfen birinci sayiyi giriniz :");
    int sayi1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Lütfen ikinci sayiyi giriniz :");
    int sayi2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Toplam : " + (sayi1 + sayi2));

}
catch
{
    Console.WriteLine("Lütfen doğru bir ifade giriniz .");

}
