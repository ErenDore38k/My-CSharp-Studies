

int[,] sayilar = new int[3, 5]; 


int[,] sayılar =
{
    {3,5,7 },
    {4,6,8 },
    {5,10,9 },
    {30,36,12 }
};

for (int i = 0; i < sayılar.GetLength(0); i++)
{
    
    for (int j = 0; j < sayılar.GetLength(1); j++)
    {
        Console.Write(sayılar[i, j] + " \n");
    }
}

