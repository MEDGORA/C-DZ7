/* Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
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
        matrix[i,j] = Convert.ToDouble(new Random().Next(0,101))/10;
        Console.Write(Math.Round(matrix[i,j], 1) + " ");
    }
    Console.WriteLine();
}
