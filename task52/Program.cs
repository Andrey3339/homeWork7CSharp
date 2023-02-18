void InputMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
    }
  }
}

void PrintMatrix(int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {	
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
  }
}

double[] MiddleValue(int[,] matrix)
{
  double sum = 0;
  double[] middle = new double[matrix.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(1); i++)
  {
    sum = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {	
        sum = sum + matrix[j, i];
    }
    middle[i] = Math.Round(sum / (matrix.GetLength(0) ), 2);
  }
  return middle;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Среднее арифметическое каждого столбца массива: ");
Console.WriteLine(string.Join("\t", MiddleValue(matrix)));


