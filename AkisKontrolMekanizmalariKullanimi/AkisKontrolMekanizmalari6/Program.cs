


int q1 = 15;
int q2 = 25;
string mesaj = (q1, q2) switch
{
    (5, 10) when (true) => " 5 ile 10 değerleri ",
    var d when d.q1 % 2 == 1 || d.q2 == 10 => " 10 ile 20 değerleri "
};
Console.WriteLine(mesaj);
