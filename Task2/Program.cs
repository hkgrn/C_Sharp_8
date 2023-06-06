// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


void RandomNumbers(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void SummEl(int[,] arr) {
    int ex = 0;
    for (int m = 0; m < arr.GetLength(1); m++) {
         ex = ex + arr[0, m];
    }
    int Min = ex;
    int Summa = 0;
    int Str = 0;
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            Summa = Summa + arr[i, j];
            }
     Console.WriteLine($"Сумма строки {i} = {Summa}");
        if (Min>Summa) {
        Min = Summa;
        Str = i;
    }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная строка: НОМЕР [{Str}], ЗНАЧЕНИЕ - [{Min}] ");
}

int rows = 3;
int colums = 4;
int[,] numbers = new int[rows, colums];

RandomNumbers(numbers);

Console.WriteLine();
Console.WriteLine("ПОЛУЧЕННЫЙ МАССИВ: ");

for (int i = 0; i < numbers.GetLength(0); i++) {
    for (int j = 0; j < numbers.GetLength(1); j++) {
        Console.Write(numbers[i, j] + " ");
    }
    Console.WriteLine();
}
    Console.WriteLine();



SummEl(numbers);