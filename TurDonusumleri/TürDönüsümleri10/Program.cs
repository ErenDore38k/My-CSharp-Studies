
using System;

int t = 1;
bool c = convert.toboolean(t);
Console.WriteLine(c);
// tür dönüşümlerinde dönüştürülecek türün hedef türe uygun olması gerekiyordu . 
// bir istisna var normalde 1 -> true  0 -> false eşit olması ve geri kalanın mümkün olmaması gerekmekteydi. 
// burada 0'ın dışındaki tümm değerler true olarak kabul edilmesi bir istisnadır. 