int [] Prompt(string message)
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
int [] array = Prompt("введите массив");
CheckArray (array);