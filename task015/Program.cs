// Задача 15: Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();

Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 1 || n > 7) {
    Console.WriteLine(" ");
}
else {
    if (n == 6 && n == 7) {
        Console.WriteLine("да");
    }
    else {
        Console.WriteLine("нет");
    }
}