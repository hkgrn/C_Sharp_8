// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void RandomNumbers(int[,] arr) {
    for (int i = 0; i < arr.GetLength(0); i++) {
        for (int j = 0; j < arr.GetLength(1); j++) {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
}

void MatrixProiz(int[,] first, int[,] second, int[,] endmatrix) {
  for (int i = 0; i < endmatrix.GetLength(0); i++) {
    for (int j = 0; j < endmatrix.GetLength(1); j++) {
      int Summ = 0;
      for (int k = 0; k < first.GetLength(1); k++) {
        Summ = Summ + first[i,k]*second[k,j];
      }
      endmatrix[i,j] = Summ;
    }
  }
}


int rows = 2;
int colums = 2;
int[,] numbers1 = new int[rows, colums];
int[,] numbers2 = new int[rows, colums];

RandomNumbers(numbers1);
RandomNumbers(numbers2);

int[,] matrix = new int[rows, colums];

Console.WriteLine();
Console.WriteLine("ПОЛУЧЕННЫЕ МАТРИЦЫ: ");

for (int i = 0; i < numbers1.GetLength(0); i++) {
    for (int j = 0; j < numbers1.GetLength(1); j++) {
        Console.Write(numbers1[i, j] + " ");
    }
    Console.WriteLine();
}
    Console.WriteLine();

for (int i = 0; i < numbers2.GetLength(0); i++) {
    for (int j = 0; j < numbers2.GetLength(1); j++) {
        Console.Write(numbers2[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

MatrixProiz(numbers1, numbers2, matrix);

Console.WriteLine("ПРОИЗВЕДЕНИЕ: ");
for (int i = 0; i < matrix.GetLength(0); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++) {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}