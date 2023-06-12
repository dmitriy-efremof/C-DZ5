// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] array = new int[4];
// int evenNumbers = 0;

// Console.Write("[ ");

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(100, 1000);
//     Console.Write(array[i]+"; ");
// }

// Console.Write("]");

// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         evenNumbers = evenNumbers + 1;
//     }
// }
// Console.WriteLine();
// Console.WriteLine($"Количество чётных чисел в массиве:{evenNumbers}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] array = new int[5];
// int unevenNumbers = 0;

// Console.Write("[ ");

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().Next(-100, 101);
//     Console.Write(array[i] + "; ");
// }

// Console.Write("]");

// for(int i = 0; i < array.Length; i+=2)
// {
//     unevenNumbers = unevenNumbers + array[i];
// }

// Console.WriteLine();
// Console.WriteLine($"Сумма элементов стоящих на нечётных позициях:{unevenNumbers}");

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

// double[] array = new double[5];

// Console.Write("[ ");

// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = new Random().NextDouble() * (101);
//     Console.Write(array[i] + "; ");
// }

// Console.Write("]");

// double maxNumber = array[0];
// double minNumber = array[0];

// for (int i = 0; i < array.Length; i++)
// {
//     if (maxNumber < array[i])
//     {
//         maxNumber = array[i];
//     }
//     else if (minNumber > array[i])
//     {
//         minNumber = array[i];
//     }

// }
// Console.WriteLine();
// Console.WriteLine($"Максимальный элемент массива:{maxNumber}");
// Console.WriteLine($"Минимальный элемент массива:{minNumber}");
// Console.WriteLine($"Разница между максимальным и минимальным элементом:{maxNumber - minNumber}");