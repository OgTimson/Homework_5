/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

int[] InitArray(int size)
{
    int[] result = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(1, 100);
    }

    return result;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int GetDiffMaxMin(int[] arr)
{
    int max = arr[0];
    int min = arr[0];
    int diff = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        else if (arr[i] < min)
        {
            min = arr[i];
        }
        diff = max - min;
    }

    return diff;
}

int[] arr = InitArray(5);
PrintArray(arr);
int diffMaxMin = GetDiffMaxMin(arr);
Console.WriteLine($"Разница между максимальным и минимальным элементов массива = {diffMaxMin}");