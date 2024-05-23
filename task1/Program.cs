 // Задача 1: Задайте значения M и N. 
 // Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
 // Использовать рекурсию, не использовать циклы.




void NumberOfToN(int m, int n)
{
    if (m > n)
    {
        NumberOfToN(m - 1, n);
        System.Console.Write(m + " ");
    }
    else if (n > m)
    {
        NumberOfToN(m, n-1);
        System.Console.Write(n + " ");
    }
    else 
        System.Console.Write(m + " ");
}

// NumberOfToN (1, 5);

NumberOfToN (4, 8);