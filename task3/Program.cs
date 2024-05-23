/*
Задайте произвольный массив. 
Выведете его элементы, начиная с конца. 
Использовать рекурсию, не использовать циклы.
*/

void RevMas(int[] array, int i = 0)
{
    if (i < array.Length)
    {
        RevMas(array, i + 1);
        Console.Write(array[i] + " ");
    }
}
int[] array = { 1, 2, 5, 0, 10, 34 };
RevMas(array);