// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
double [,] CreateArray(int r, int c)
{
    double [,] array = new double [r,c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            array[i,j]=new Random().Next(-10,10)+new Random().NextDouble();
        }
    }
    return array;
}
void PrintArray(double[,]array)// Вывод массива на экран
{
   int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j]<0) Console.Write($"{array[i,j]:N1} \t");
            else Console.Write($" {array[i,j]:N1} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
double [,] Arrange(double[,]array)// Упорядочивание массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
    for (int j = 0; j < array.GetLength(1)-1; j++)
    {
        int minPosition = j;
        
        for (int k = j+1; k< array.GetLength(1); k++)
        {
            if (array[i,k]>array[i,minPosition])
            {
                minPosition = k;
            }
        }

        double temporary = array[i,j];
        array[i,j]=array[i,minPosition];
        array[i,minPosition] = temporary;
    }
    }
    return array;
}

Console.WriteLine("Введите размерность массива: ");
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
double[,]array=CreateArray(m,n);
PrintArray(array);
double[,]rep=Arrange(array); 
PrintArray(rep);

