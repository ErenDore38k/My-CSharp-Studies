
Array yaslar = Array.CreateInstance(typeof(int), 3);


yaslar.SetValue(25, 0);
yaslar.SetValue(30, 1);
yaslar.SetValue(35, 2);


for (int i = 0; i < yaslar.Length; i++)
{
    Console.WriteLine(yaslar.GetValue(i));
}
