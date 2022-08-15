// int firstNumber = 10;
// int secongNumber = 5;
// Console.WriteLine(Sum(firstNumber, secongNumber));

// int Sum(int a, int b) 
// {
//     int result = a + b;
//     return result;
// }

// void test (int a)





// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.

// int randomNumber = GetRandomNumber(10, 99);
// Console.WriteLine(randomNumber);

// int firstDigit = randomNumber / 10;
// int secondDigit = randomNumber % 10;
// int maxDigit = Max(firstDigit, secondDigit);

// Console.WriteLine(maxDigit);


// int GetRandomNumber(int min, int max)
// {
// return new Random().Next(min, max + 1);
// }

// int Max(int a, int b)
// {
// int max = 0;
// if(a > b)
// {
// max = a;
// }
// else
// {
// max = b;
// }
// return max;
// }







// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98


// int randomNumber = GetRandomNumber(100, 999);
// Console.WriteLine(randomNumber);
// Console.WriteLine(DeleteSecondNumber(randomNumber));

// int DeleteSecondNumber(int number)
// {
// int firstDigit = randomNumber / 100;
// int lastDigit = randomNumber % 10;
// return firstDigit * 10 + lastDigit;
// }

// int GetRandomNumber(int min, int max)
// {
// return new Random().Next(min, max + 1);
// }








// Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно


// int firstNumber = ReadInt("Первое число: ");
// int secondNumber = ReadInt("Второе число: ");

// int remainderOfDivision = firstNumber % secondNumber;
// if (remainderOfDivision == 0)
// {
// Console.WriteLine("Числа кратны");
// }
// else
// {
// Console.WriteLine("Числа не кратны, остаток от деления - " + remainderOfDivision);
// }

// int ReadInt(string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }





// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да


// int number = ReadInt("Введите первое число: ");
// int firstDivider = 7;
// int secondDivider = 23;

// if(Multiple(number, firstDivider) && Multiple(number, secondDivider))
// {
// Console.WriteLine("Да");
// }
// else
// {
// Console.WriteLine("Нет");
// }

// bool Multiple(int a, int b)
// {
// return a % b == 0;
// }

// int ReadInt(string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }



// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// int firstNumber = ReadInt("Введите первое число: ");
// int secondNumber = ReadInt("Введите второе число: ");

// if(SqrNumber(firstNumber) == secondNumber || SqrNumber(secondNumber) == firstNumber)
// {
// Console.WriteLine("Yes");
// }
// else
// {
// Console.WriteLine("No");
// }

// int SqrNumber(int number)
// {
// return number * number;
// }

// int ReadInt(string message)
// {
// Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }


// Задача 10. Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
// 456 - 5
// 782 - 8
// 918 - 1 

// Задача 13. Напишите программу, которая выводит третью цифру заданого числа или сообщает, что третьей цифры нет.
// 645 - 5
// 78 - третьей цифры нет
// 32679 - 6


// Задача 15. Напишите программу, которая проверяет на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 - да
// 7 - да
// 1 - нет



