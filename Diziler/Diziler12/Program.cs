//Bir Dizinin Kendi Türünde Tanımlanmasıyla Array Türünde Tanımlanması Arasındaki Fark Nedir?

int[] a = new int[5];
/*Dizi eğer ki kendi türünde referans ediliyorsa indexer operatörü kullanılabilir.
 *Bu şekilde çalışıldığında ilgili diziye verisel müdahaleler operatif gerçekleştirilirken
 *Genellikle bu format algoritmalarda tercih edilir. Çünkü indexer algoritmalarda çok kullanılır.
 * ************************************************************************************************
 *Array a2 = new int[5];
 *Yok eğer Array türünde referans ediliyorsa indexer operatörü kullanılamaz.
 *Bu şekilde ise fonksiyonel çözümler getirilmektedir.
 *Genellikle elimizdeki dizi üzerinde işlem yaparken tercih edilen formattır. Dizi hakkında bilgiedinirken  vs kullanılır.
*/
