/*
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8
*/

void Fibonacci(int n)
{
    int FnPrevious = 1;
    int FnPrePrevious = 0;
    int result = 0;
    if (n < 0) Console.Write("Введите положительное значение");
    for (int i = 0; i < n; i++)
    {
        if (i == 0)
        {
            result = 0;
        }
        else if (i == 1)
        {
            result = 1;
        }
        else
        {
            result = FnPrevious + FnPrePrevious;
            int temp = FnPrevious;
            FnPrevious = result;
            FnPrePrevious = temp;
        }
        Console.Write($"{result} ");
    }
}

Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"F{n} = ");
Fibonacci(n);