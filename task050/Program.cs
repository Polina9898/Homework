// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и выводит значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такой позиции в массиве нет


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = new Random().Next(0, 11); // [0, 10]
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void PrintMatrixElement(int[, ] matrix, int i, int j)
{
    if (i < 0 || i >= matrix.GetLength(0)) {
        Console.WriteLine("такой позиции в массиве нет");
        return;
    }

    if (j < 0 || j >= matrix.GetLength(1)) {
        Console.WriteLine("такой позиции в массиве нет");
        return;
    }

    Console.WriteLine(matrix[i, j]);
}



Console.Clear();
Console.Write("Введите размеры матрицы: ");
string[] size = Console.ReadLine().Split(" ");
int rows = int.Parse(size[0]);
int columns = int.Parse(size[1]);
int[,] matrix = new int[rows, columns];

InputMatrix(matrix);

Console.WriteLine();
Console.Write("Введите позицию элемента: ");
string[] coord = Console.ReadLine().Split(" ");
int i = int.Parse(coord[0]);
int j = int.Parse(coord[1]);

PrintMatrixElement(matrix, i - 1, j - 1);