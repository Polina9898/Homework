// По целочисленным координатам вершин треугольника (x1,y1), (x2,y2) и (x3,y3) 
// требуется вычислить его площадь.

// Входной файл INPUT.TXT содержит 6 целых чисел x1,y1,x2,y2,x3,y3 – координаты вершин треугольника. 


int ReadWithLabel(string label) {
    Console.Write(label);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadWithLabel("Введите x1: ");
int y1 = ReadWithLabel("Введите y1: ");
int x2 = ReadWithLabel("Введите x2: ");
int y2 = ReadWithLabel("Введите y2: ");
int x3 = ReadWithLabel("Введите x3: ");
int y3 = ReadWithLabel("Введите y3: ");

double S = (double) Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1)) / 2d;
Console.WriteLine($"Площадь треугольника: {S}");

