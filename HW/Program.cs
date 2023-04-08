// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] CreateArrayRandomInt( int size , int min, int max)
{
    int [] arr = new int[size];
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(min,max+1);
    }
    return arr;
}

void PrintArray(int[] arr)
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

int FindEvenNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (arr[i]%2==0) count ++; 
    }
    return count;
}


int[] array = CreateArrayRandomInt(6,100,999);
PrintArray(array);
int result = FindEvenNumbers(array);
Console.WriteLine($"Кол-во четных чисел в массиве = {result}");
