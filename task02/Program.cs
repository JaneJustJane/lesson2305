// показать числа Фибоначчи меньше заданного числа n
// 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, 610

Console.WriteLine("введите число n");
int n = int.Parse(Console.ReadLine() ?? "0");
int result = 0;
int a1=0;
int a2=1;
Console.Write($"{a1} {a2} ");
while (result<n)
{
    result=a1+a2; 
    if (result<=n)
    {
        Console.Write($"{result} ");
        a1 = a2;
        a2 = result;
    }
    else 
    {
        Console.WriteLine();
    }
   
}
