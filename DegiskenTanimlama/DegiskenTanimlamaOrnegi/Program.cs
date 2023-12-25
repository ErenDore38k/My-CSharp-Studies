
string AdSoyad = "Eren Döre"; 
char başharf = 'g';   
bool medenihal = false;
int x = 3;
int y = 253;
float f = 3.14f;
float g = 3.15F;
double d = 25.14;
decimal e = 14.14m;
decimal s = 36.47M;

(int a, int b, string c, double d) değişken = (25, 36, " hüso ", 36.75);
(int yas, string takım, string cinsiyet) bilgi = (25, " GALATASARAY", " ERKEK");

bool takım = true;
string futbol = takım == true ? " Sen GALATASARAYLISIN" : " Sen Galatasaraylı Değilsin ";
Console.WriteLine(futbol);

int sayı = 1_000_000;  
bool a = default(bool);
int yc = default(int);
string z = default(string);
char o = default(char);

