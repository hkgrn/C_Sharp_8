// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void RandomNumbers(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(-100, 100);
        }
    }
}

void SortingArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(0); j++) {
            for (int n = 0; n < arr.GetLength(0)-1; n++) {
                if (arr[i, n] < arr[i, n+1]) {
                    int x = arr[i, n+1];
                    arr[i, n+1] = arr[i, n];
                    arr[i, n] = x;
                }
            }
        }
    }
}


Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int colums = Convert.ToInt32(Console.ReadLine());
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


SortingArray(numbers);

Console.WriteLine();
Console.WriteLine("УПОРЯДОЧЕННЫЙ МАССИВ: ");

for (int i = 0; i < numbers.GetLength(0); i++) {
    for (int j = 0; j < numbers.GetLength(1); j++) {
        Console.Write(numbers[i, j] + " ");
    }
    Console.WriteLine();
}