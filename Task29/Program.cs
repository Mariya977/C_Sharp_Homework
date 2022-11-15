// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

int [] GetArray(int size)
{
    int [] result = new int [size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(1, 11);
    }
    return result;
}

int[] array = GetArray(8);
Console.WriteLine($"[ {String.Join(", ", array)} ]");
