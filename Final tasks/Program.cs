// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
int NaturalNumbers(int numberM, int numberN)
{
    if(numberM > numberN)
    {
        int numberX = numberM;
        numberM = numberN;
        numberN = numberX;
    }
    if(numberM == numberN)
    {
        return numberN;
    }
    Console.Write($"{numberM}, ");
    return NaturalNumbers(numberM += 1, numberN);
}
Console.Write($"{NaturalNumbers(M, N)}");