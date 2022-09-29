/*
//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите натуральное число B: ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Число {a} в степени {b} = {GetPow(a, b)}");


double GetPow(int num1, int num2)
{
    double result = Math.Pow(num1, num2);

    return result;
}
*/


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Сумма цифр в числе {num} = {GetSumm(num)}");

int GetSumm (int num1)
{

    int result = 0;
    while (num1 > 0)
    {

        result = result + num1 % 10;
        num1 = num1 / 10;

    }
return result;

}

// Задача 29: Напишите программу, которая задаёт массив из 8 рандомных элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int[] array = FillArray(8);
Console.WriteLine($"[{String.Join(", ", array)}]");

int[] FillArray(int size)
{
    int[] result =  new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10);
    }
return result;
}
*/
