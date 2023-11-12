//Var Pattern Kritik Yapalım 1

object s = "Goat";
if (s is var s1)
{
    Console.WriteLine(s1);
}
//var ın türü runtime da belirlenecektir.


/*var keywordü ile var pattern'de ki var yapılanması arasında davranış farkı vardır. 
 *var keywordü : Derleme zamanında(compile aşamasında ) türünü belirlerken 
 *var patternda'ki var keywordü ise Runtime da türünü belirleyecektir. 
 */

//is den sonra var keywordü gelebilir ama dynamic keywordü gelemez

