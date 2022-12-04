/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

Console.WriteLine("Введите размерность двумерного массива m x n");
Console.Write("Введите  m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  n: ");
int n = Convert.ToInt32(Console.ReadLine());

double [,] matrix = new double [m,n];
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    {
        matrix[i,j] = new Random().Next(0,11);
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите индексы нужного Вам элемента массива [i, j]:");
Console.Write("Введите  i: ");
int indexI = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите  j: ");
int indexJ = Convert.ToInt32(Console.ReadLine());
if (indexI > m-1 || indexJ > n-1)
{
    Console.WriteLine("Данный элемент отсутствует в массиве");
}
else
{
for(int i = 0; i < m; i++)
{
    for(int j = 0; j < n; j++)
    if (i == indexI && j == indexJ)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(matrix[i,j]);
        Console.ResetColor();
        Console.Write(" ");
    }
    else
    {
        Console.Write(matrix[i,j]+ " ");
    }
    Console.WriteLine();
}
Console.WriteLine($"Нужный Вам элемент массива: {matrix[indexI,indexJ]}");
}