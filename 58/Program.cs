void InputMatrix1(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}
void PrintMatrix1(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}
void InputMatrix2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}
void PrintMatrix2(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] martrix1, int[,] martrix2, int[,] resultMatrix)
{
    
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
        for (int k = 0; k < martrix1.GetLength(1); k++)
              sum += martrix1[i,k] * martrix2[k,j];
        resultMatrix[i,j] = sum;
    }
  }
}
Console.Clear();
Console.Write("Введите размер первого массива: ");
int[] size1 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];
InputMatrix1(matrix1);
PrintMatrix1(matrix1);
Console.Write("Введите размер второго массива: ");
int[] size2 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];
InputMatrix2(matrix2);
PrintMatrix2(matrix2);
int[] size3 = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] resultMatrix = new int [size3[0], size3[1]];
MultiplyMatrix(matrix1, matrix2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц: {resultMatrix}");