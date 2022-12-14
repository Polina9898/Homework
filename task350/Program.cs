// Дана строка, состоящая из N попарно различных символов. 
// Требуется вывести все перестановки символов данной строки.

// Входной файл INPUT.TXT содержит строку, 
// состоящую из N символов (1 ≤ N ≤ 8), символы - буквы английского алфавита и цифры.

// В выходной файл OUTPUT.TXT выведите в каждой строке по одной перестановке. 
// Перестановки можно выводить в любом порядке. Повторений и строк, 
// не являющихся перестановками исходной, быть не должно.

void Swap(char[] charArray, int i, int j) {
    char item = charArray[i];
    charArray[i] = charArray[j];
    charArray[j] = item;
}
 
void Permutations(char[] charArray, int i) {
    if (i == charArray.Length - 1) {
        Console.WriteLine(String.Join("", charArray));
        return;
    }
 
    for (int j = i; j < charArray.Length; j++) {
        Swap(charArray, i, j);
        Permutations(charArray, i + 1);
        Swap(charArray, i, j);
    }
}

Console.Write("Enter string for permutations: ");
string? str = Console.ReadLine();

if (str != null && str.Length != 0) {
    char[] charArray = new char[str.Length];
    for (int i = 0; i < str.Length; i++) {
        charArray[i] = str[i];
    }

    Permutations(charArray, 0);
} else {
    Console.WriteLine("String is empty");
}
