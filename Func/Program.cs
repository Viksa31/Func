using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Вызов функций для проверки

        // Функция 1: Сумма двух чисел
        Console.WriteLine(Sum(3, 5)); 

        // Функция 2: Площадь круга
        Console.WriteLine(CircleArea(5)); 

        // Функция 3: Длина строки
        Console.WriteLine(StringLength("Hello, World!")); 

        // Функция 4: Наибольшее значение в массиве
        int[] array = { 1, 5, 3, 9, 2 };
        Console.WriteLine(MaxInArray(array)); 

        // Функция 5: Факториал числа
        Console.WriteLine(Factorial(5)); 

        // Функция 6: Проверка на палиндром
        Console.WriteLine(IsPalindrome("madam")); 
        Console.WriteLine(IsPalindrome("hello"));

        // Функция 7: Объединение двух массивов
        int[] array1 = { 1, 2, 3 };
        int[] array2 = { 4, 5, 6 };
        int[] mergedArray = MergeArrays(array1, array2);
        Console.WriteLine(string.Join(", ", mergedArray)); 

        // Функция 8: Проверка на простое число
        Console.WriteLine(IsPrime(7)); 
        Console.WriteLine(IsPrime(10)); 

        // Функция 9: Обратный порядок строки
        Console.WriteLine(ReverseString("Hello")); 

        // Функция 10: Сумма элементов двумерного массива
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine(SumOfElements(matrix)); 
    }

    // Функция 1: Сумма двух чисел
    static int Sum(int a, int b)
    {
        return a + b;
    }

    // Функция 2: Площадь круга
    static double CircleArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Функция 3: Длина строки
    static int StringLength(string str)
    {
        return str.Length;
    }

    // Функция 4: Наибольшее значение в массиве
    static int MaxInArray(int[] array)
    {
        return array.Max();
    }

    // Функция 5: Факториал числа
    static int Factorial(int n)
    {
        if (n <= 1) return 1;
        return n * Factorial(n - 1);
    }

    // Функция 6: Проверка на палиндром
    static bool IsPalindrome(string str)
    {
        string reversedStr = new string(str.Reverse().ToArray());
        return str == reversedStr;
    }

    // Функция 7: Объединение двух массивов
    static int[] MergeArrays(int[] array1, int[] array2)
    {
        return array1.Concat(array2).ToArray();
    }

    // Функция 8: Проверка на простое число
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0) return false;
        }
        return true;
    }

    // Функция 9: Обратный порядок строки
    static string ReverseString(string str)
    {
        return new string(str.Reverse().ToArray());
    }

    // Функция 10: Сумма элементов двумерного массива
    static int SumOfElements(int[,] matrix)
    {
        int sum = 0;
        foreach (int value in matrix)
        {
            sum += value;
        }
        return sum;
    }
}
