// Дана последовательность из N целых чисел и число K. Необходимо сдвинуть всю последовательность 
// (сдвиг - циклический) на |K| элементов вправо, если K – положительное и влево, если отрицательное.


Console.Clear();
Console.Write("Введите кол-во элементов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] array1 = new int[n];

for (int i = 0; i < n; i++) {
    array1[i] = Convert.ToInt32(Console.ReadLine());
}

Console.Write("Введите сдвиг: ");
int k = Convert.ToInt32(Console.ReadLine());
int[] array2 = new int[n];

for (int i = 0; i < n; i++) {
    int j = (i - k) % n;
    
    if (j < 0) {
        j = j + n;
    }

    array2[i] = array1[j];
}

Console.WriteLine(string.Join(", ", array2));