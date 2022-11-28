//Задача 2: Напишите программу, которая на вход принимает
// два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) {
    Console.Write("max = ");
    Console.WriteLine(a);
    
} else {
    Console.Write("max = ");
    Console.Write(b);
}
