
unchecked
{
    int ar = 1200;
    byte br = (byte)ar;
    Console.WriteLine(br);
}

//Unchecked ile veri kaybını göz arde ederek çalışmaya devam eder yani veri kyabı olamsı çalışma durumunu etkilemez
//unchecked sayesinde.  Veri kaybı olur o durumu etkilemez. 
//Not: Normal bir kod bloğu default olarak unchecked dir.


/* Bilinçsiz tür dönüşümünde ki mantık bir sayısal değerin kendisinden daha geniş bir aralığa dönüştürmektir ve burada bizim
 * herhangi bir sorumluluğumuz olmayacağı içşn bilinçsiz tür dönüşümü olmuş olacaktır
 * Not : Bilinçsiz tür dönüşümünde herhangi bir veri kaybı yaşanmaz . 
 *  bilinçli tür dönüşümünde ise sayısal değer kendisinden daha küçük daha dar bir aralığa sığdırılmaya dönüştürülmeye 
 *  çalışılmaktadır. Bilinçli tür dönüşümünde sorumluluk bizdedir kendi irademizle yaparız . Veri kaybı yaşama ihtiimalimiz 
 *  vardır .  
 */