//задача 2 на примере одной связки чисел, остальные выполняются также,
//просто меняются числа

int a = 5;
int b = 7;


int max = a;
if(a > max) max = a;
if(b > max) max = b;

Console.Write("max = ");
Console.WriteLine(max);