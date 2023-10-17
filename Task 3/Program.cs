// Напишите программу, которая выводит массив из 8 элементов, заполненный случайными числами. 
// Оформите заполнение массива и вывод в виде функции (пригодится в следующих задачах). 
// Реализовать через функции. (* Доп сложность, “введите количество элементов массива”, 
// “Введите минимальный порог случайных значений”, “Введите максимальный порог случайных значений”)

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

int[] createArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int length = ReadInt("Введите длину массива:");
int minArray = ReadInt("Введите минимальное значение массива:");
int maxArray = ReadInt("Введите максимальное значение массива:");

printArray(createArray(length, minArray, maxArray));

