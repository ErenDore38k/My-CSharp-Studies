//Düzensiz Dizilerde İç İçe Döngülerle Çalışma

int[][] sayilar = new int[3][];
sayilar[0] = new int[3] { 2, 4, 6 };
sayilar[1] = new int[5] { 3, 6, 9, 12, 15 };
sayilar[2] = new int[2] { 36, 38 };

for (int i = 0; i < sayilar.Length; i++)
{
    for (int j = 0; j < sayilar[i].Length; j++)
    {
        Console.Write(sayilar[i][j] + "  ");
    }
    Console.WriteLine("");
}