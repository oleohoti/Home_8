// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] CreateArray(int r, int c)
{
    int[,] array = new int[r, c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}
int[,] ArrayC(int[,] a, int[,] b)
{
    int[,] c = new int[a.GetLength(0), b.GetLength(1)];
    int ck = 0;
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            ck = 0;
            for (int k = 0; k < b.GetLength(0); k++)
            {
                ck = a[i, k] * b[k, j]; c[i, j] += ck;
            }
        }
        Console.WriteLine();
    }
    return c;
}
void PrintArray(int[,] array)// Вывод массива на экран
{
    int rows = array.GetUpperBound(0) + 1;
    int columns = array.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i, j] < 0) Console.Write($"{array[i, j]:N0} \t");
            else Console.Write($" {array[i, j]:N0} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Console.WriteLine("Введите кол-во строк матрицы А");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы А");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во строк матрицы В");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов матрицы В");
int n2 = Convert.ToInt32(Console.ReadLine());
if (m1 != n2) System.Console.WriteLine("Такие матрицы нельзя перемножить, так как количество столбцов матрицы А не равно количеству строк матрицы В.");
else
{
    int[,] A = CreateArray(m1, n1);
    int[,] B = CreateArray(m2, n2);
    // int[,]A={{2,4},{3,2}};
    // int[,]B={{3,4},{3,3}};
    int[,] C = ArrayC(A, B);
    Console.WriteLine("Матрица А");
    PrintArray(A);
    Console.WriteLine("Матрица B");
    PrintArray(B);
    Console.WriteLine("Матрица C = A*B");
    PrintArray(C);
}
