checked
{
 int ar = 1200;
 byte br = (byte)ar;
 Console.WriteLine(br);
}
//Chacked bloğu bilinçli tür dönüşümü esnasında  bir veri kaybı söz konusu olursa eğer runtime de bizleri uyaracak olan bir kontrol 
//mekanizmasıdır.Yani bir veri kaybı olursa bizi bilgilendirecek uyaracak.Bir nevi hata yapma aşamasında isek bizi 
//yanlış yoldan alır.