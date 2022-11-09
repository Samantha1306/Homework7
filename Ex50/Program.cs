// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

try
{
    Console.Write("Укажите, сколько строк будет в массиве (введите натуральное число): ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите, сколько столбцов будет в массиве (введите натуральное число): ");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.Write("Укажите, какое число требуется найти в массиве (введите целое число): ");
    int x = Convert.ToInt32(Console.ReadLine());

    int[,] matrix = new int[m, n];

    void FillArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                matr[i, j] = new Random().Next(1,10);
            }
        }
    }

    void PrintArray(int[,] matr)
    {
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                Console.Write($"{matr[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    bool FindNumber(int[,] matr)
    {
        bool a = false;
        for (int i = 0; i < matr.GetLength(0); i++)
        {
            for (int j = 0; j < matr.GetLength(1); j++)
            {
                if (matr[i, j] == x)
                {
                    a = true;
                    Console.Write($"Число {x} находится в массиве на позиции ({i}, {j}).");
                }
            }
        }
        if (a == false) Console.Write($"Числа {x} нет в массиве.");
        return a;
    }

    FillArray(matrix);
    PrintArray(matrix);
    FindNumber(matrix);
}
catch
{
    Console.WriteLine("Ошибка! Введите натуральное число.");
}
