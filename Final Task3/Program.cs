// Задача 3: Задайте произвольный массив. Выведете
//его элементы, начиная с конца. Использовать
//рекурсию, не использовать циклы.

int[] myArray = {1,2,5,3,10,34};
PrinArray(myArray,5);
static void PrinArray(int[] myArray, int i = 0)
{
    if (i < myArray.Length)
    {
        Console.WriteLine(myArray[i]);
        PrinArray(myArray, i - 1);
    }
}