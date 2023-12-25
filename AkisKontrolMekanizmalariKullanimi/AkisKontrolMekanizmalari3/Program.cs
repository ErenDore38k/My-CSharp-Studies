

int j = 10;
switch (j)
{
    case 5:
        Console.WriteLine(j * 10);
        break;
    case 6:
        Console.WriteLine(j * 30);
        break;
    case 7:
        goto case 5;
    case 10:
        goto case 5;
}


