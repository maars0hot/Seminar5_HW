// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
double[] arr = new double[size];
Random rnd = new Random();

for (int i = 0; i < arr.Length; i++)
{
arr[i] = rnd.NextDouble() * (max - min) + min;
}
return (arr);
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length-1) Console.Write($"{arr[i]} ,");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
    Console.WriteLine("____________________________________________");
}

double FindMax (double[] arr)
{
    double max=arr[0];
    int i = 1;
    while (i < arr.Length)
    {
        if (arr[i]>max) max = arr[i];
        i++;
    }
    return max;
}

double FindMin (double[] arr)
{
    double min=arr[0];
    int i = 1;
    while (i < arr.Length)
    {
        if (arr[i]<min) min = arr[i];
        i++;
    }
    return min;
}

double Difference(double min, double max)
{
    double result = 0;
    result = max - min;
    return result;
}

double[] array = CreateArrayRndDouble(5,1,100);
PrintArray(array);
double maximum = Math.Round(FindMax(array),1,MidpointRounding.ToZero);
double minimum = Math.Round(FindMin(array),1,MidpointRounding.ToZero);
double result = Math.Round(Difference(minimum,maximum),1,MidpointRounding.ToZero);
Console.WriteLine($"Разница между максимумом {maximum} и {minimum} => {result}");