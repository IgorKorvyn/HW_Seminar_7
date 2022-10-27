/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            /* matrix[i, j] = new Random().NextDouble();
            Console.Write($"{matrix[i, j]} \t"); */

            //matrix[i, j] = new Random().Next(-10, 10) + new Random().NextDouble() * 10;
            matrix[i, j] = new Random().Next(-10, 10) * new Random().NextDouble();
            Console.Write($"{matrix[i, j]:f1} \t");
        }
        Console.WriteLine();
    }


}
Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n, m];
InputMatrix(matrix);
