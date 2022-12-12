// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void InputArray(int[] array) {
    for (int i = 0; i < array.Length; i++) {
        array[i] = new Random().Next(0, 100); // [0, 99]
    }
}

int GetMinMaxDelta(int[] array) {
    int max = array[0];
    int min = array[0];

    for (int i = 1; i < array.Length; i++) {
        if (array[i] > max) {
            max = array[i];
        }

        if (array[i] < min) {
            min = array[i];
        }
    }

    return max - min;
}

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

InputArray(array);

Console.WriteLine($"[{string.Join(", ", array)}]");

int delta = GetMinMaxDelta(array);

Console.WriteLine(delta);