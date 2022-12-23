// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся (HARD - случайных уникальных) двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
void CreateArray(int[,,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = new Random().Next(0, 10);
            }

        }
    }
}
void PrintArray(int[,,] array)// Вывод массива на экран
{
    for (int k = 0; k < array.GetLength(2); k++)
    {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           
                if (array[i, j , k] < 0) Console.Write($"{array[i, j, k]}({i},{j},{k}) \t");
                else Console.Write($" {array[i, j, k]}({i},{j},{k}) \t");
            }

        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
// void Uniqality(int [,,]array)
// {
//     for (int k = 0; k < array.GetLength(2); k++)
//     {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
           
//                 if (array[i, j , k] < 0) Console.Write($"{array[i, j, k]}({i},{j},{k}) \t");
//                 else Console.Write($" {array[i, j, k]}({i},{j},{k}) \t");
//             }

//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }
int[,,]array=new int [2,2,2];
CreateArray(array);
PrintArray(array);
