// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void InputMatrix(int[, ] matrix) {
    for (int i = 0; i < matrix.GetLength(0); i++) {
        for (int j = 0; j < matrix.GetLength(1); j++) {
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
            Console.Write($"{matrix[i, j]} \t");
        }

        Console.WriteLine();
    }
}

void AvgMatrix(int[, ] matrix) {
    int result = 0;

    for (int j = 0; j < matrix.GetLength(1); j++) {
        for (int i = 0; i < matrix.GetLength(0); i++) {
            result += matrix[i, j];
        }

        Console.Write(string.Format("{0:0.0}; ", (double) result / (double) matrix.GetLength(0)));
        result = 0;
    }
}

Console.Clear();
Console.Write("Введите размер матрицы: ");
int[] coord = Console.ReadLine().Split(" ").Select(s => int.Parse(s)).ToArray();
int[,] matrix = new int[coord[0], coord[1]];
Console.WriteLine("Начальная матрица: ");
InputMatrix(matrix);

Console.Write("Среднее арифметическое каждого столбца: ");
AvgMatrix(matrix);