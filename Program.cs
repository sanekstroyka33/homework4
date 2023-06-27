// Console.Write("Введите число: ");
// int A = int.Parse(Console.ReadLine()!);
// Console.Write("Введите число для возведения в степень: ");
// int B = int.Parse(Console.ReadLine()!);
// Console.WriteLine($" возведение числа {A} в степень {B} равна {GetPow(B)}");
// // Функция возведения числа А в степень В
// int GetPow(int B)
// {
//     int pow = 1;
//     for (int i = 1; i <= B; i++)
//     {
//         pow = pow * A;  
//     } 
//         return pow; 
//         }
// Console.Write("Введите число: ");
// int Number = int.Parse(Console.ReadLine()!);
// Console.WriteLine($"{Number} -> {SumNumber(Number)}");
// int SumNumber(int A)
// {
//     int sum = 0;
//     while (A > 0)
//     {
//         sum = sum + A % 10;
//         A = A / 10;
//     }
//     return sum;
//     }
// int[] getArray(int size)
// {
//     int[] result = new int[size]; //целочмсленный массив с размером size
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(1, 10000);
//     }
//     return result;
// }
// int[] array = getArray(8);
// Console.WriteLine($"[{String.Join(",", array)}]");