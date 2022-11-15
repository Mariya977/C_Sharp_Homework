// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

void Stepen(int numA, int numB)
{
    int changedA = numA;
    for (int i = 1; i < numB; i++)
    {
        changedA = numA * changedA;
    }
    Console.WriteLine($"{numA} в степени {numB} = {changedA}");
}
Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
Stepen(a, b);