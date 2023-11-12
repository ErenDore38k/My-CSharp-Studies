//C# 7.0 Pattern Matching - Var Pattern

/*Eldeki veriyi 'var' değişkeni ile elde etmemizi sağlamaktadır.
 *var: Verilen değerin türüne bürünen bir keyword. Runtime'da bürünme işlemi gerçekleşmektedir.
 *Var Pattern 'a Type Pattern nın hızlandırılmış halide denilebilir.
 *Type Pattern ın bir üst varyasyonu var Pattern diyebiliriz.
 */

object x = "Türkiye";
if (x is var x1)
{
    Console.WriteLine(x1);
}
