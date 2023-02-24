void InputMatrix(int[,] matrix)
{
  int row = matrix.GetLength(0);
  int col = matrix.GetLength(1);
  int len = row * col;
  int min = 0;
  if (col >= row)
    min = row;
  else 
    min = col;
  int[] r = new int[len]; 
  //Console.WriteLine($"row = {row} col = {col} len = {len}");
  int temprow = 1;
  int temp = 0;
  int temp2 = 0;
  bool flag = false;
  // заполняем массив координат строк
  while(temp < len)
  {  
    for(int y = 0; y < temprow; y++ )
    {
      if (temp >= len)
        break;
      r[temp] = y;      
      //Console.Write($"{r[temp]}\t");
      temp++;
    }
    temprow++;
    if(temprow > row)
    //if(temprow > min)
      {
        temprow = row;
        if (flag == false)
        {
            flag = true;
            temp2 = temp - row;
        }//Console.WriteLine("wjxkwjwklwklcjw " + (temp - row));
      }
    //else
      //temp2++;  
  } 
//Console.WriteLine("значение переменной temp = {0}, переменной temp2 = {1}" , temp, temp2);  
//Console.WriteLine(string.Join("\t", r));
  temprow = row - 1;
  //temprow = min - 1;
  temp = 0;
  while(temp < temp2)
  {
    for(int i = (min - 1); i >= temprow; i--)
    {
      if (temp >= temp2)
        break;
      
      temp++;
      r[r.Length - temp] = i;
    }
    temprow--;

  }
//Console.WriteLine(string.Join("\t", r));

// заполняем массив координат столбцов

  int[] c = new int[len];
  temprow = 1;
  temp = 0;
  temp2 = 0;
  flag = false;
  int temp3 = 0;
  // заполняем массив координат строк
  while(temp < len)
  {  
    for(int y = 0; y < temprow; y++ )
    {
      if (temp >= len)
        break;
      c[temp] = temprow - y - 1 + temp3;      
      //Console.Write($"{r[temp]}\t");
      temp++;
    }
    temprow++;
    if(temprow > row)
    //if(temprow > min)
      {
        temprow = row;
        temp3++;
        if (flag == false)
        {
            flag = true;
            temp2 = temp - row;
        }//Console.WriteLine("wjxkwjwklwklcjw " + (temp - row));
      }
    //else
      //temp2++;  
  }
  //Console.WriteLine("значение переменной temp = {0}, переменной temp2 = {1}" , temp, temp2);  
  //Console.WriteLine(string.Join("\t", c)); 
  temprow = row - 1;
  //temprow = min - 1;
  temp = 0;
  temp3 = row - 1;
  //temp3 = min - 1;
  while(temp < temp2)
  {
    temp3--;
    for(int i = (min - 1); i >= temprow; i--)
    {
      if (temp >= temp2)
        break;
      
      temp++; 
      c[c.Length - temp] = col - i + temp3;
      //temp3 --;
      //Console.Write("   " + c[c.Length - temp]);

    }
    //Console.Write("----");
    temprow--;

  }
//Console.WriteLine("  значение переменной temp = {0}, переменной temp2 = {1}" , temp, temp2);  
//Console.WriteLine();
//Console.WriteLine(string.Join("\t", c));

for(int i = 0; i < len; i++)
{
  matrix[r[i],c[i]] = i;

}











}





void PrintMatrix(int[,] matrix)
{
  for(int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {	
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
  }
}

Console.Clear();
Console.Write("Введите размер эталонного массива (не более 100 на 100): ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);





