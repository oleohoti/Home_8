// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
void PrintArray(int[,]array)// Вывод массива на экран
{
    int rows = array.GetUpperBound(0) + 1;   
    int columns = array.Length / rows;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (array[i,j]<0) Console.Write($"{array[i,j]:N0} \t");
            else Console.Write($" {array[i,j]:N0} \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
int m=4;
int n=4;
int[,] CreateArray(int m,int n)
{
int[,]array=new int [m,n];
int k=1; int i=0;int j=0;
for( j=0; j<n;j++){array[i,j]=k;k++;}
for( i=1;i<m;i++){j=m-1;array[i,j]=k;k++;}
for( j=m-1-1;j>=0;j--){i=3;array[i,j]=k;k++;}
for( i=n-1-1;i>=1;i--){j=0;array[i,j]=k;k++;}
for( j=1;j<n-1-1;j++){i=1;array[i,j]=k;k++;}
for( i=1;i<n-1-1;i++){j=m-1-1;array[i,j]=k;k++;}
for( j=1+1;j<n-1;j++){i=1+1;array[i,j]=k;k++;}
for( i=m-1-1;i<m-1;i++){j=0+1;array[i,j]=k;k++;}
return array;
}
int [,]array = CreateArray (m,n);
PrintArray(array);

