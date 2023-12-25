
using System.Collections;

int[] Yaslarr = new int[17]; 
Yaslarr[5] = 38;                 


ArrayList yaslar = new ArrayList();   
yaslar.Add(123);                     

for (int i = 0; i < 17; i++)
{
    Yaslarr[i] = i + 10; 
    yaslar.Add(i + 10);  

}

Console.WriteLine(Yaslarr[5]);


Console.WriteLine(yaslar[5]);




