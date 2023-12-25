

int Y = 10;
X(ref Y);
Console.WriteLine(Y);
void X(ref int a)
{
    a = 25;
}

