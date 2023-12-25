
Console.WriteLine(Topla(10, 20));
int Topla(int baslangic,int bitis)
{
    if (baslangic % 5 == 0)
        return baslangic + Topla(++baslangic,bitis);
    if(baslangic < bitis)
    return Topla(++baslangic, bitis); 
    return 0;
}

