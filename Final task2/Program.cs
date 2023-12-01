// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа M и N. Пример M = 2, N = 3 -> A(M,N) = 9

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
AkkermanFunction(M, N);
static void AkkermanFunction(int M, int N)
{
    Console.Write($"A(M,N)= {Akkerman(M, N)}");
}
static int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return Akkerman(M - 1, Akkerman(M, N - 1));
    }
}
