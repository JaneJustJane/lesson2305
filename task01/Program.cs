// Написать программу преобразования десятичного числа в двоичное

Console.WriteLine("Введите число");
int a = int.Parse(Console.ReadLine() ?? "0");
int rest = a%2;
int aa = rest;
a = a/2;
int i = 10;
while(a>0)
{
    rest=a%2;
    a=a/2;
    aa=aa+rest*i;
    i=i*10;
}
Console.WriteLine(aa);
