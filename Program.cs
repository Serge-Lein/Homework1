// Task2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Input the first number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input the second number: ");
// int min = Convert.ToInt32(Console.ReadLine());

// if (min < max)
// {
//    Console.WriteLine($"Min number is: {min}\nMax number is: {max}");
//    return;
// }

// else if (min > max)
// {
//   Console.WriteLine($"Min number is: {max}\nMax number is: {min}");
//   return;
// }

// Console.WriteLine("Your numbers are equal!");
 





// Task4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Console.Write("Input the first number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input the second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// Console.Write("Input the third number: ");
// int num3 = Convert.ToInt32(Console.ReadLine());

// int max = Math.Max(num1, num2);
// max = Math.Max(max, num3);

// Console.WriteLine($"Max number is: {max}");





// Task6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

// System.Console.WriteLine("Input your number please: ");
// int num = Convert.ToInt32(Console.ReadLine());

// bool result = num % 2 == 0;
// if (result == true)
// {
//    System.Console.Write("Your number is even");
//    return;
// } 

// System.Console.WriteLine("Your number is odd");






// Task8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Input your number: ");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= num; i += 2 )
{
   System.Console.Write(i + ", ");
}


