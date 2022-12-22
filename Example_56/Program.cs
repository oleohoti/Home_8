// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int [,] CreateArray(int r, int c)
{
    int [,] array = new int [r,c];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            array[i,j]=new Random().Next(0,10);
        }
    }
    return array;
}
void PrintArray(int[,]array)// Вывод массива на экран
{
   int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j]<0) Console.Write($"{array[i,j]} \t");
            else Console.Write($" {array[i,j]} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Sum(int [,]array)
{
    int[]sumar=new int[array.GetLength(0)];
    int sum =0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum=0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum+=array[i,j];
    }
    Console.WriteLine($" {i} строке сумма равна = {sum} ");
    sumar[i]=sum;
    }
    int min = sumar[0];
    int min_index = 0;
    for(int i=0; i<sumar.Length;i++)
    {
        if (sumar[i] < min)
        min = sumar[i];
        min_index = i;
    }
    Console.WriteLine($"Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: {min_index+1} строка, сумма равна = {min} ");
}
Console.WriteLine("Введите размерность массива: ");
Console.WriteLine("Введите кол-во строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,]array=CreateArray(m,n);
PrintArray(array);
Sum(array); 


