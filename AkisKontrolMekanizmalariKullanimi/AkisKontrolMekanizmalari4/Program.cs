
// Tek satırlık işlemler için maliyet düşürücü ve kullanışlı semantiklerdir

int e = 10;
string ısım = e switch
{
    5 => "Hilmi",
    7 => "Rıfkı",
    10 => "Eren"
};
Console.WriteLine(ısım);