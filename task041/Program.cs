// Задача 41:Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
Console.Write("Введите кол-во чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
int count = 0;
for (int i = 0; i < n; i++){
    Console.Write($"Ведите число {i+1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    
    if (array[i] > 0) {
            count = count + 1;
        }
   

}
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine($"Количество положительных чисел: {count}");
