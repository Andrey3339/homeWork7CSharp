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

string ExistElement(int[,] matrix, int x, int y)
{
  if (((x - 1) >= 0) && ((y - 1) >= 0) && ((x - 1) <= matrix.GetLength(0)) && ((y - 1) <= matrix.GetLength(1)))
    return "На позиции " + x + " и " + y + " находится элемент " + matrix[x-1, y-1] + ".";
  else
    return "Позиции " + x + " и " + y + " в массиве нет.";
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Введите позицию элемента в массиве: ");
int[] position = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
string s = ExistElement(matrix, (int)position[0], (int)position[1]);
Console.WriteLine(s);
