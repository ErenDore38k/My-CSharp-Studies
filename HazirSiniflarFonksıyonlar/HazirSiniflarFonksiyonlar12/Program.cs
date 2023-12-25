

DateTime T1 = DateTime.Now;
DateTime T2 = new DateTime(2004, 3, 16);
TimeSpan span = T1 - T2;
Console.WriteLine(span.Days);