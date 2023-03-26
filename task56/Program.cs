// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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
        matrix[i, j] = Random.Shared.Next(1, 11);
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


Console.WriteLine($"Введите размер массива m x n:");
int m = Numbers ("Введите m: ");
int n = Numbers ("Введите n: ");
int [,] myMatrix = GetRandom (m, n);
print (myMatrix);

int minSum = 0;
int sum = SumElements(myMatrix, 0);
for (int i = 1; i < myMatrix.GetLength(0); i++)
{
  int temp = SumElements(myMatrix, i);
  if (sum > temp)
  {
    sum = temp;
    minSum = i;
  }
}

Console.WriteLine($"{minSum+1} - строкa с наименьшей суммой ({sum}) элементов ");


int SumElements(int[,] array, int i)
{
  int sumLine = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumLine += array[i,j];
  }
  return sumLine;
}
 
 

