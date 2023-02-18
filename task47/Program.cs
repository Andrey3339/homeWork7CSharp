
void InputMatrix(double[,] matrix)
{
 int begin = -10, end = 10;
 for (int i = 0; i < matrix.GetLength(0); i++)
     for (int j = 0; j < matrix.GetLength(1); j++)
        matrix[i, j] = Math.Round(new Random().NextDouble() *
                       (end - begin) + begin, 2);
//Math.Round() - округляет первый аргумент до точности второго аргумента                      
}

void PrintMatrix(double[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {	
    for (int j = 0; j < matrix.GetLength(1); j++)
        Console.Write($"{matrix[i, j]} \t");
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
double[,] matrix = new double[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);


