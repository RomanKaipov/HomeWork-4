// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string temp = Console.ReadLine();
    int num = int.Parse(temp);
    return num;
}

void printArray(int[] array)
{
    foreach (var item in array)
    {
        Console.Write(item + " ");
    }
    Console.WriteLine();
}

int sizeArray(int number)
{
    int result = 0;
    while (number > 0)
    {
        result++;
        number /= 10;
    }
    return result;
}

int[] createArray(int number)
{
    int[] array = new int[sizeArray(number)];
    int i = 0;
    while (number > 0)
    {
        array[i] = number % 10;
        number /= 10;
        i++;
    }
    return array;
}

int sum(int number)
{
    int[] array = createArray(number);
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        result += array[i];
    }
    return result;
}

int number = ReadInt("Ввведите число: ");
// printArray(createArray(number)); // 
Console.WriteLine("Сумма цифр числа " + number + " равна " + sum(number));