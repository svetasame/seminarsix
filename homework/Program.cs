int [] PromptArray(string message)
{
System.Console.WriteLine(message);
int[] arraydigits = Array.ConvertAll(Console.ReadLine().Split(','), digit => {return System.Convert.ToInt32 (digit);});
return arraydigits;
}

void CheckArray (int [] array)
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
// int [] array = PromptArray("введите массив");
// CheckArray (array);

//программа которая найдет точку пересечения 2 прямых заданных уравнениями 
// y=k1*x+b1, y = k2*x+b2
void Linec



int [] array = PromptArray("введите b1,k1,b2,k2:");
PrintArray (array);


int n = 0;
void Count (ref int Count)
{
  System.Console.WriteLine(n);
  Count++;
}

int number = 3; 
Count (ref number);
System.Console.WriteLine(number);