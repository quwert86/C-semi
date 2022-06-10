// квадрат числа
// Console.WriteLine("Type int number");
// int num = Convert.ToInt32(Console.ReadLine());
// int result = num * num;
// Console.WriteLine("result is "+ result);



// Напишите программу, которая на вход принимает два числа и проверяет,
//  является ли первое число квадратом второго.

// Console.WriteLine("Type int first number");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Type int second number");
// int num2 = Convert.ToInt32(Console.ReadLine());

// int square = num2 * num2;

// if (num1 == square) {
//     Console.WriteLine("first number is a square of second one");
// }

// else{
//     Console.WriteLine("first number is NOT a square of second one");
// }


// Напишите программу, которая будет выдавать название дня недели по заданному номеру.

// Console.WriteLine("Type weeks day");
// int day = Convert.ToInt32(Console.ReadLine());

// if (day < 1 || day > 7 ){
//     Console.WriteLine("incorrect day");

// }
//  else  {
//     if (day == 1){
//         Console.WriteLine("monday");
//     }
//     if (day == 2){
//         Console.WriteLine("tuesday");
//     }
//  }


// Напишите программу, которая на вход принимает одно число (N),
//  а на выходе показывает все целые числа в промежутке от -N до N.


// Console.WriteLine("Type int N");
// int n = Convert.ToInt32(Console.ReadLine());
// int current;
// if (n < 0){
//     current = n;
//     n = n *(-1);
// }
// else{
//     current = -1 * n;
// }

// while(current < n-1){
//     current++;
//     Console.Write(current + " ");
    
// }


// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.


Console.WriteLine("Type int N");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(num % 10);