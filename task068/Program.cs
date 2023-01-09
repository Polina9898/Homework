// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

// https://meadow-patio-044.notion.site/C-3253637fba794c1fb25716811f4ca2ec

static uint A(uint m, uint n)
{
  if (m == 0) {
    return n + 1;
  }
  else if (n == 0) {
    return A(m - 1, 1);
  }
  else {
    return A(m - 1, A(m, n - 1));
  }
}

Console.Clear();
uint m = Convert.ToUInt32(Console.ReadLine());
uint n = Convert.ToUInt32(Console.ReadLine());
Console.WriteLine(A(m, n));