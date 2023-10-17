// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadInt(string msg)
{
    Console.WriteLine(msg);
    string temp = Console.ReadLine();
    int num = int.Parse(temp);
    return num;
}

double Power(int number, int power)
{
    double result = 1;
    for (int i = 1; i <= power; i++)
    {
        result *= number;
    }
    return result;
}

int number = ReadInt("Введите число");
int pow = ReadInt("Введите степень в которую возведется число");
double result = Power(number, pow);
Console.WriteLine($"Число {number} в степени {pow} равно {result}");
