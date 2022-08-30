Console.Clear();
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
//и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// первый вариант-НЕ ЦИКЛ
// Console.Write("Введите число: ");
// int numA = int.Parse(Console.ReadLine()?? "0");
// Console.Write("Введите второе число, которое будет степенью первого: ");
// int numB = int.Parse(Console.ReadLine()?? "0");
// int num = Convert.ToInt32(Math.Pow(numA, numB));//метод Math.Pow_возводит в степень
// Console.WriteLine(num);
//второй вариант - ЦИКЛ
// Console.WriteLine("Введите число:   ");
// int numA = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите второе число, которое будет степенью: ");
// int numB = int.Parse(Console.ReadLine() ?? "0");
// numB = Math.Abs(numB);
// int firstA = numA;
// int i = 0;

////Console.WriteLine($"{numA} возведенное в степень {numB} = {Math.Pow(numA, numB)}");

// if (numA == 0)
// {
//     Console.WriteLine($"{firstA} возведенное в степень {numB} = {numA}");
// }
// else
// {
//     while (i < numB)
//     {
//         numA *= firstA;
//         i++;
//     }
//     numA /= firstA;
//     Console.WriteLine($"{firstA} возведенное в степень {numB} = {numA}");
// }

//Задача 27: Напишите программу, которая принимает на вход число 
//и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
//первый вариант 
// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// num = Math.Abs(num);
// Console.WriteLine($"Сумма всех цифр в числе = {GetSumNums(num)}");
// int GetSumNums(int number)
// {
//     int sum = 0;
//     while(number > 0)
//     {
//         sum += number %10;
//         number /= 10;
//     }
//     return sum;
// }


//второй вариант С МАССИВОМ
// Console.WriteLine("Введите число: ");
// double num = Convert.ToDouble(Console.ReadLine()!);
// double sum = 0;
// num = Math.Abs(num);
// while (num > 0)
// {
//     sum += num % 10;
//     num = Math.Floor(num / 10);
// }
// Console.Write($"Сумма всех цифр в числе: {Math.Floor(sum)}");


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.

// ПЕрвый ВАРИАНТ
// int[] array = GetRandomArray(8, 0, 100);
// Console.WriteLine($"[{String.Join(", ", array)}]");//метод String.Join выводит все значения через запятую

// int[] GetRandomArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);
//     }

//     return result;
// }

//второй вариант 
// Random rand = new Random();
// int[] array = new int[8];
// Console.Write("[");
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0, 11);
//     Console.Write($"{array[i]}" + (i < array.Length - 1 ? ", " : ""));
// }
// Console.Write("]");

