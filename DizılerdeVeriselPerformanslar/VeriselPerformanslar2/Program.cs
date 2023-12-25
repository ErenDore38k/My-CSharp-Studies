

int[] sayilar = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

ArraySegment<int> segment = new ArraySegment<int>(sayilar);

ArraySegment<int> segment1 = segment.Slice(0, 3);
ArraySegment<int> segment2 = segment.Slice(3, 4);
ArraySegment<int> segment3 = segment.Slice(6, 4);

for (int i = 0; i < segment1.Count; i++)
{
    Console.WriteLine(segment1[i]);
}
Console.WriteLine("*");
for (int i = 0; i < segment2.Count; i++)
{
    Console.WriteLine(segment2[i]);
}
Console.WriteLine("*");

for (int i = 0; i < segment3.Count; i++)
{
    Console.WriteLine(segment3[i]);
}
