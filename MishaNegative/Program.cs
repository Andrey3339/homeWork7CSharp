void InputMatrix(char[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = (new Random().Next(1, 11)) < 5 ? 'B': 'W';
    }
  }
}

void PrintMatrix(char[,] matrix)
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

int CountPixel(char[,] matrix, char[,] matrix2)
{
  int count = 0;
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {	
        if(matrix[i, j] != matrix2[i, j])
            count++;
    }
  }
  return count;
}

Console.Clear();
Console.Write("Введите размер эталонного массива (не более 100 на 100): ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
char[,] matrixEtalon = new char[size[0], size[1]];
char[,] matrixMisha = new char[size[0], size[1]];
InputMatrix(matrixEtalon);
PrintMatrix(matrixEtalon);
Console.WriteLine("---------------------------------------------------------------------------");
InputMatrix(matrixMisha);
PrintMatrix(matrixMisha);
Console.WriteLine("Количество неправильных пикселей: " +
                 CountPixel(matrixEtalon, matrixMisha));



