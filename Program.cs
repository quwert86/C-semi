
//  2 Seminar


// void ShowNumber(){
//     int num = new Random().Next(10, 100);
//     int firstNum = num /10;
//     int secondNum = num % 10;
//     Console.Write(num + "->");
//     if (firstNum > secondNum){
//         Console.WriteLine(firstNum);
//     }
//     else {
//         Console.WriteLine(secondNum);
//     }
// }

// ShowNumber();



// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.



// int NumberWithOutSecDig(int Number){   
//     int NewNumber = Number / 100 * 10 + Number % 10;
//     return NewNumber;
// }
// int Number = new Random().Next(100, 1000);
// int res = NumberWithOutSecDig(Number);
// Console.WriteLine(Number + "  " + res);


// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.



// void resultOfDivision(int a, int b){
//     if (b % a==0){
//         Console.WriteLine(b + " кратно "  + a );
//     }
//     else{
//     Console.WriteLine(b + " не кратно " + a + " остаток " + b%a);
//     }
// }
// Console.WriteLine("Type int N1, N2");
// int n1 = Convert.ToInt32(Console.ReadLine());
// int n2 = Convert.ToInt32(Console.ReadLine());

// resultOfDivision(n1,n2);



// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

// void resultOfDivision(int a){
//     if (a % 7 == 0 && a % 23 == 0 ){
//         Console.WriteLine(a + " кратно " );
//     }
//     else{
//     Console.WriteLine(a + " не кратно ");
//     }
// }
// Console.WriteLine("Type int N1");
// int n1 = Convert.ToInt32(Console.ReadLine());


// resultOfDivision(n1);


// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

// void resultOfDivision(int a, int b){
//     if (a*a==b){
//         Console.WriteLine(b + " квадрат "  + a );
//     }
//     else{
//     Console.WriteLine(b + " не квадрат " + a );
//     }
// }


// Console.WriteLine("Type int N1, N2");
// int n1 = Convert.ToInt32(Console.ReadLine());
// int n2 = Convert.ToInt32(Console.ReadLine());



// resultOfDivision(n1,n2);


// HOMEWORK2

// Напишите программу, которая принимает на вход трёхзначное число
//  и на выходе показывает вторую цифру этого числа.

// void result(int a){
//     if (a > 99 && a < 1000) {
//         Console.WriteLine(a / 10 % 10);
//     }
//     else {
//     Console.WriteLine(" неверное значение ");
//     }
// }

// Console.WriteLine("Введите 3-х значное число");
// int n1 = Convert.ToInt32(Console.ReadLine());

// result(n1);


// Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.



// Console.WriteLine("Введите число");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(n>99 ? n.ToString()[2] : '-');
// Console.ReadKey(true);


// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.


// void result(int a) {
//     if (a > 1 && a > 7) {
//         Console.WriteLine("неверное значение");
//     }
//     else{
//         if (a > 5){
//         Console.WriteLine("выходной день");
//         }
//         else{
//             Console.WriteLine("рабочий день");
//         }
    
//     }
// }
// Console.WriteLine("Номер дня");
// int n1 = Convert.ToInt32(Console.ReadLine());

// result(n1);


    
