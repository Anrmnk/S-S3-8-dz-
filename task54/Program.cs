﻿// Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию 
// элементы каждой строки двумерного массива.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// В итоге получается вот такой массив:

// 1 2 4 7

// 2 3 5 9

// 2 4 4 8

int [,] GetRandom (int rows, int columns, int left, int right)
{
    int [,] matrix = new int [rows, columns];
    for (int i = 0; i < matrix.GetLength (0); i++) 
    {
       for (int j = 0; j < matrix.GetLength (1); j++)
       {
        matrix[i, j] = Random.Shared.Next(left, right+1);
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

void result (int [,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      for (int x = 0; x < matrix.GetLength(1) - 1; x++)
      {
        if (matrix[i, x] > matrix[i, x + 1])
        {
          int temp = matrix[i, x + 1];
          matrix[i, x + 1] = matrix[i, x];
          matrix[i, x] = temp;
        }
      }
    }
  }
}

const int ROWS = 4;
const int COLUMNS = 4;
const int LEFT = 1;
const int RIGHT = 10;
int [,] myMatrix = GetRandom (ROWS, COLUMNS, LEFT, RIGHT);
Console.WriteLine("Оригинальный массив: ");
print (myMatrix);
result(myMatrix);
Console.WriteLine("Упорядоченный массив: ");
print (myMatrix);