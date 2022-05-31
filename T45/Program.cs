//Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
int[] CopyArray(int[] array)
{
    int[] CopyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        CopyArray[i] = array[i];
    }
    return CopyArray;
}

int[] FillArray(int length, int deviation)
{
    if (length < 0)
    {
        length = 0;
    }
    else if (deviation < 0)
    {
        deviation = deviation * -1;
    }
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
        result[i] = new Random().Next(-deviation, deviation);
    }
    return result;
}


void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write("]");
}

Console.Write("Введите длину массива: ");
int MyArrayLength = Convert.ToInt32(Console.ReadLine());
while (MyArrayLength<0) 
{
   Console.WriteLine ("Длина массива должна быть положительная\nВведите длину: ");
   MyArrayLength = Convert.ToInt32(Console.ReadLine());
}
Console.Write("Введите диапазон массива: ");
int MyArrayDeviation = Convert.ToInt32(Console.ReadLine());
int[] MyArray = FillArray(MyArrayLength, MyArrayDeviation);
Console.WriteLine("Оригинал:");
PrintArray(MyArray);
Console.WriteLine();
int[] copyArray = CopyArray(MyArray);
Console.WriteLine("Копия:");
PrintArray(copyArray);