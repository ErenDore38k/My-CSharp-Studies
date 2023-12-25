

using System.Text;

string isim = "Eren";
string soyisim = "Döre";


StringBuilder builder = new StringBuilder();
builder.Append(isim);
builder.Append("  ");
builder.Append(soyisim);
Console.WriteLine(builder.ToString());