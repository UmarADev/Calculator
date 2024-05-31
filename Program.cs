using System;

Console.WriteLine("Hi. Please enter 2 numbers:");

int firstNum = Convert.ToInt32(Console.ReadLine());
int secondNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Here results:");
Console.WriteLine($"When nums added: {firstNum} + {secondNum} = {firstNum + secondNum}");
Console.WriteLine($"When nums subtracted: {firstNum} - {secondNum} = {firstNum - secondNum}");
Console.WriteLine($"When nums multiplied: {firstNum} * {secondNum} = {firstNum * secondNum}");
Console.WriteLine($"When nums divided: {firstNum} / {secondNum} = {firstNum / secondNum}");
Console.WriteLine($"This is a big number you entered: {Math.Max(firstNum, secondNum)}");
Console.WriteLine($"This is power of your first number to second number: {firstNum} ^ {secondNum} = {Math.Pow(firstNum, secondNum)}");
Console.WriteLine($"First number's square root is {Math.Sqrt(firstNum)}");
Console.WriteLine($"Second number's square root is {Math.Sqrt(secondNum)}");
Console.WriteLine($"First number's absolute value is {Math.Abs(firstNum)}");
Console.WriteLine($"Second number's absolute value is {Math.Abs(secondNum)}");