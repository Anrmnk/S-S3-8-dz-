// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// и
// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7
// Их произведение будет равно следующему массиву:
// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

int Numbers(string input)
{
  Console.Write(input);
  int num = Convert.ToInt32(Console.ReadLine());
  return num;
}

int [,] GetRandom (int rows, int columns)
{
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
       {
        matrix[i, j] = Random.Shared.Next(1, 10);
       }
    }   
    return matrix;
}

void print (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
        {
            Console.Write (matrix[i, j] + "  ");
        }
    Console.WriteLine();
    
    }
}

void result (int [,] matrix, int [,] matrix2)
{
    int [,] array1 = matrix;
    int [,] array2 = matrix2; 
    int [,] resArray = new int [array1.GetLength (0), array1.GetLength (1)];
if (array1.GetLength (0) == array2.GetLength (0) && array1.GetLength (1) == array2.GetLength (1))
{
 for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
    {
        resArray[i,j] = array1[i,j] * array2[i,j];
        Console.Write (resArray[i, j] + "  ");
    }
    Console.WriteLine();
    }
}
else Console.WriteLine("Массивы не одной размерности");
}


Console.WriteLine($"Введите размер массива1 m x n:");
int m1 = Numbers ("Введите m: ");
int n1 = Numbers ("Введите n: ");
int [,] myMatrix1 = GetRandom (m1, n1);
print (myMatrix1);

Console.WriteLine($"Введите размер массива2 m x n:");
int m2 = Numbers ("Введите m: ");
int n2 = Numbers ("Введите n: ");
int [,] myMatrix2 = GetRandom (m2, n2);
print (myMatrix2);
Console.WriteLine($"Произведение матриц:");
result (myMatrix1, myMatrix2);

