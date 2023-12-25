
int a = X(out int _b, 123, out string _d);
Console.WriteLine(_d);
Console.WriteLine(_b);
int X(out int b,int c ,out string d)
{
    b = 25;
    d = "hilmi";
    return 0;

}


