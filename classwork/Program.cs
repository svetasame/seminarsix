// задача 39
// перевернуть массив одномерные

int[] GenerateArray(int length)
{
  int[] array = new int[length];
  for (int i = 0; i < length; i++)
    array[i] = new Random().Next(-10, 11);
  return array;
}

void PrintArray (int [] array)
{
  System.Console.WriteLine(String.Join("", array));
}

int [] AnotherReverseArray(int[] array)
{
  int[] tmpArray = new int[array.Length];
  for (int i = 0; i < array.Length; i++)
    tmpArray[i] = array[array.Length - 1 - i];
  return tmpArray;
}

int [] ReverseArray (int [] array)
{
  for (int i = 0; i < array.Length/2; i++)
  {
    int tmp = array[i];
    array[i] = array[array.Length-1-i];
    array[array.Length-1-i] = tmp;
  }
  return array;
}


static int Prompt(string message)
{
System.Console.WriteLine(message);
int result = Convert.ToInt32(Console.ReadLine());
return result;
}

void CheckTriangle (int a, int b, int c)
{
  if (a == b+c)
  Console.WriteLine($"ОШИБКА.Треугольник с со сторонами {a}, {b} и {c} не сущесвует");
  else if (b == a+c)
  Console.WriteLine($"ОШИБКА.Треугольник с со сторонами {a}, {b} и {c} не сущесвует");
  else if (c == a+b)
  Console.WriteLine($"ОШИБКА.Треугольник с со сторонами {a}, {b} и {c} не сущесвует");
  else
  Console.WriteLine($"Треугольник с со сторонами {a}, {b} и {c} может существовать");
}


// int[] array1 = GenerateArray (4);
// ReverseArray (array1);
// AnotherReverseArray (array1);
// PrintArray (array1);
// // PrintArray (ReverseArray (array1));
// PrintArray (AnotherReverseArray(array1));


// задача 40 программа которая принимает 3 чисоа и проверяет есть ли треугольник со сторонами такой длины

// int a = Prompt("введите первое число");
// int b = Prompt("введите второе число");
// int c = Prompt("введите третье число");
// CheckTriangle (a,b,c);

int TenToTwo (int a)
{
int tmp = a;
int res = 0;
for (int i = 0; tmp > 0; i++)
  {
  tmp = tmp / 2;
  res++;
  }
  return res;
}

int[] TenToTwoArray (int a, int length)
{
int tmp = a;
int [] array = new int [length];
for (int i = 0; i < length; i++)
  {
  array[i] = tmp % 2;
  tmp = tmp / 2;
  }
  return array;
}

// программа которая будет преобразовывать десятичное число в двоичное
// int a = Prompt("введите число");
// TenToTwoAnother (a);
// int length = TenToTwo(a);
// System.Console.WriteLine();
// PrintArray(ReverseArray(TenToTwoArray (a, length)));

void TenToTwoAnother (int a)
{
int tmp = a;
string numbs = string.Empty;
while ( tmp > 0)
{
  numbs = tmp%2 + numbs; // переворачивание строки 
  tmp = tmp/2;
}
System.Console.WriteLine(numbs);
}

//сохранять каждую итерацию данные строки