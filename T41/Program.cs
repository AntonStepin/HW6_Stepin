// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("");
Console.WriteLine("Добавить число - нажмите любую клавишу");
Console.WriteLine("Увидеть результат - нажмите Escape");
Console.WriteLine("");
ConsoleKeyInfo btn = new ConsoleKeyInfo();
int count = 0;
while (btn.Key != ConsoleKey.Escape)
{
    Console.Write("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) count++;
    btn = Console.ReadKey(true);
}
Console.WriteLine($"Ответ: {count}");