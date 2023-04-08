// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


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

int SumNotEvenPositions(int [] arr)
{
    int summ=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length) summ = summ + arr[i];
        i=i+1;
    }
    return summ;
}


int[] array = CreateArrayRandomInt(10,1,9);
PrintArray(array);
int result = SumNotEvenPositions(array);
Console.WriteLine($"Сумма всех нечетных позиций в массиве = {result}");