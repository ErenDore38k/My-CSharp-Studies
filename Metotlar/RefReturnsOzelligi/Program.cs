

int a = 5;
int b =  X( ref a);
Console.WriteLine(a);
Console.WriteLine(b);
 ref int X( ref int y)
{
    y = 25;
    return ref y;
}