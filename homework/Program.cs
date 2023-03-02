double [] PromptArray(string message)
{
System.Console.WriteLine(message);
double [] arraydigits = Array.ConvertAll(Console.ReadLine().Split(','), digit => {return System.Convert.ToDouble (digit);});
return arraydigits;
}

void CheckArray (double [] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i] > 0)
    count++;
  }
  System.Console.WriteLine(count);
}


void PrintArray (int [] array)
{
  System.Console.WriteLine(String.Join(" ", array));
}


// задача 41 пользователь ввел массив чисел, нужно посчитать сколько было введено чисел больш 0
// double [] array = PromptArray("введите массив");
// CheckArray (array);

// задача 43 программа которая найдет точку пересечения 2 прямых заданных уравнениями 

void LineCross (double  [] array)
{
double b1 = array [0];
double k1 = array [1];
double b2 = array [2];
double k2 = array [3];
System.Console.WriteLine($"{b1}, {k1}, {b2}, {k2}");
double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;
System.Console.WriteLine($"точка пересечения двух прямых х = {x} и у = {y}");
}

double  [] array = PromptArray("введите b1,k1,b2,k2:");
LineCross (array);