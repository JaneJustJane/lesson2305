// Выяснить, являются ли три числа сторонами треугольника

int [] array = new int [3];

void FillArray(int[] array)
{
    for (int i=0; i<array.Length; i++)
    {
        array[i]=new Random().Next(1,10);
    }
}

FillArray (array);
int a = array[0];
int b = array[1];
int c = array[2];
Console.WriteLine($"даны три числа:{a},{b},{c}");
if (a < (b+c) && b< (a+c) && c < (a+b))
    Console.WriteLine("Данные числа являются сторонами треугольника");
else 
    Console.WriteLine("Данные числа не являются сторонами треугольника");
