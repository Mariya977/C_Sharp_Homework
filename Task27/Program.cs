// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

void SumInNum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int i = number % 10;
        number /= 10;
        sum += i;
    }
    Console.WriteLine($"Сумма цифр в ведённом числе равна {sum}");
}

Console.WriteLine("Введите число: ");
SumInNum(Convert.ToInt32(Console.ReadLine()));

