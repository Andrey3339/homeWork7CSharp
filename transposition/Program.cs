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

void Transposition(int[,] matrix)
{
  int[] temp = new int[matrix.GetLength(1)];
  for (int i = 0; i < matrix.GetLength(0)/2; i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {	
        temp[j] = matrix[i,j];
        matrix[i, j] = matrix[matrix.GetLength(0) - 1 - i, j];
        matrix[matrix.GetLength(0) - 1 - i, j] = temp[j];
    }
    
  }
  
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("--------------------------------------------------");
Transposition(matrix);
PrintMatrix(matrix);


