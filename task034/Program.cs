// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void InputArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(100, 1000); // [100, 999]
    }
}

int CountEven(int[] array) {
    int count = 0; //количество чётных чисел

    for (int i = 0; i < array.Length; i++) {
        if (array[i] % 2 == 0) {
            count = count + 1;
        }
    }

    return count;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);

Console.WriteLine($"[{string.Join(", ", array)}]");

int count = CountEven(array);

Console.WriteLine(count);