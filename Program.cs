
// SEMINAR 4

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.


// int sumToNum(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.WriteLine("Input number : ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of elements is " + sumToNum(number));



// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.


// int number = 5;
// int count = 0;
// while (number > 0)
//     {
//     number = number / 10 ;
//     count++;
//     }

// Console.WriteLine(count);


// int number = Convert.ToInt32(Console.ReadLine());
// int count = 0;
// while (number > 0)
//     {
//     number = number / 10 ;
//     count++;
//     }

// Console.WriteLine(count);

// int CountNumbers(int num){
//     int count = 0;
//     while (num > 0){
//         num = num / 10 ;
//         count++;
//     }
//     return(count);
// }
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(CountNumbers(number));


// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.


// int moleOfNum(int num)
// {
//     int mole = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         mole *= i;
//     }
//     return mole;
// }

// Console.WriteLine("Input number : ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Mole of elements is " + moleOfNum(number));


// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// Случайно генерирует массив

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++){
//         array [i] = new Random().Next(0,2);
//     }
//     return array;
// }

// int[] myRandomArray = CreateRandomArray(6);
// ShowArray(myRandomArray);

// Console.WriteLine();

// Ввод данных в массив


// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++){
//         Console.Write("Input " + i +  " element: ");
//         array [i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// Вывод массива

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i]+ " ");
//     }
// }

// int[] myRandomArray = CreateRandomArray(6);
// ShowArray(myRandomArray);

// Console.WriteLine();

// int[] myArray = CreateRandomArray(6);
// ShowArray(myArray);

// -------------------------------------------------

// создаем массив случайных чисел, где size -- количество элементов в массиве, min -- начало диапазона генерации случайных чисел, от какого генерируем, max -- до какого генерируем
// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }

//  создаем массив из чисел, которые вводим
// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write("Input " + i + " element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// выводим значения элементов массива в одну строку через пробел
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int[] myRandomArray = CreateRandomArray(8, 0, 1);
// ShowArray(myRandomArray);



// HOMEWORK4


// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


// int resultDegr(int a,int b){
//     int res = 1;
//     int i = 0;
//     while (i < b){
//         res = res * a;
//         i++ ;

//     }
//     return res;
//     Console.WriteLine(res);
// }
// Console.WriteLine("Input a, Input b : ");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(resultDegr(a,b));

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


// int SumDig(int n){
//     int sum = 0;
//     int i = 1;
//     int temp = 1;
//     while (n / (10*i) > 1){
//         sum = sum + (n /(temp)%10);
//         i++;
//         temp = 10*i;

//     }
//     return sum;
//     Console.WriteLine(SumDig(sum));
// }
// Console.WriteLine("Input n : ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(SumDig(n));




// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.



// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++){
//         array [i] = new Random().Next(0,10);
//     }
//     return array;
// }

// int[] myRandomArray = CreateRandomArray(8);
// ShowArray(myRandomArray);

// Console.WriteLine();


// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i]+ " ");
//     }
// }


// Seminar 5 

// string name = "Имя";
// int age = 99;
// Console.WriteLine("Имя: {0} Возраст: {1}", name, age);

// int number = 23;
// string result = string.Format("{0:f}", number);

// Console.WriteLine(result);


// int number = 23;
// string result = string.Format("{0:f}", number);

// Console.WriteLine(result);

// double number2 = 45.08;
// string result2 = string.Format("{0:f5}", number2);
// Console.WriteLine(result2);


// string name = "Имя";
// int age = 99;
// Console.WriteLine($"Имя: {name} Возраст: {age}");

// int x = 8;
// int y = 7;
// string result = $"{x} + {y} = {x + y}";
// Console.WriteLine(result);

// string name = "Имя";
// int age = 99;

// Console.WriteLine($"Имя: {name, -10} Возраст: {age}"); // пробелы после
// Console.WriteLine($"Имя: {name, 15} Возраст: {age}"); // пробелы до


// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }


// void ShowArray (int[] array){

//     for (int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sum_pos = 0;
// int sum_neg = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 0)
//         sum_pos += myArray[i];
//     else
//         sum_neg += myArray[i];
// }

// Console.WriteLine($"сумма положительных: {sum_pos}");
// Console.WriteLine($"сумма отрицательных: {sum_neg}");

// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }


// void ShowArray (int[] array){

//     for (int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(4, -8, 8);
// ShowArray(myArray);


// for (int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] = myArray[i]*(-1);

// }
// ShowArray(myArray);


// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


// int[] CreateRandomArray(int size)
// {
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
// array[i] = new Random().Next(0, 10);
// }
// return array;
// }

// int[] MyArray = CreateRandomArray(8);

// void ShowArray(int[] array)
// {

// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// }

// ShowArray(MyArray);

// int ArrayCheck(int[] array)
// {
// for (int i = 0; i < MyArray.Length; i++)
// {
// if (MyArray[i] == 4)
// {
// return 1;
// }
// }
// return 0;
// }

// if (ArrayCheck(MyArray) == 1){
// Console.WriteLine(" 4 is present");}

// else {
// Console.WriteLine (" 4 is absent");
// }

// bool FindNumber(int[] array, int Number)
// {
// for (int i = 0; i < array.Length; i++)
// {
// if (array[i] == Number) return true;
// }
// return false;
// }


// HOMEWORK5

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }


// void ShowArray (int[] array){

//     for (int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(6, 100, 999);
// ShowArray(myArray);

// int count = 0;
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] %2 == 0)
//         count++;

// }

// Console.WriteLine($"четные: {count}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.



// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }


// void ShowArray (int[] array){

//     for (int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(7, -9, 9);
// ShowArray(myArray);

// int sum = 0;
// for (int i = 1; i < myArray.Length; i=i+2)
// {
//     sum += myArray[i];

// }

// Console.WriteLine($"сумма чисел с нечетным индексом: {sum}");


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.



// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }


// void ShowArray (int[] array){

//     for (int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(5, 1, 9);
// ShowArray(myArray);

// int max = myArray[0];
// int min = myArray[0];
// for (int i = 0; i < myArray.Length; i++)
// {
//     if (max < myArray[i])
//     {
//         max = myArray[i];
//         }
//     else if (min > myArray[i])
//     {
//         min = myArray[i];
//         }

// }

// Console.WriteLine($"числа: {max} {min} разность {max - min}");


// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123


// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }


// void ShowArray (int[] array){

//     for (int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(123, -200, 200);
// // ShowArray(myArray);

// int sum = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if (myArray[i] > 9)
//         if (myArray[i] < 100)
//             sum += myArray[i];

// }

// Console.WriteLine($"сумма: {sum}");


// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.


// int[] CreateRandomArray(int size, int min, int max){
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }


// void ShowArray (int[] array){

//     for (int i = 0; i < array.Length; i++){
//     Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] myArray = CreateRandomArray(5, -5, 5);
// ShowArray(myArray);

// int mole = 1;

// for (int i = 0; i < myArray.Length; i++)
// {
//     while (i + i < myArray.Length){
//         mole = myArray[i]* myArray[myArray.Length-i-1];
//         i ++;
//         Console.WriteLine($"сумма положительных: {mole}");
//     }
// }

// SEMINAR 6

// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// int[] RandomArray(int size)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(100, 1000);
//     }
//     return array;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// void SwapArray(int[] array)
// {
//     int buf = 0;

//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         buf = array[i];
//         array[i] = array[array.Length - i - 1];
//         array[array.Length - i - 1] = buf;
//     }

//     ShowArray(array);
// }

// void SwapArray1(int[] array)
// {
//     int[] arr = new int[array.Length];

//     for (int i = 0, j = array.Length - 1; i < array.Length; i++, j--)
//     {
//         arr[i] = array[j];
//     }

//     ShowArray(arr);
// }

// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());

// int[] arr = RandomArray(size);

// ShowArray(arr);

// Console.WriteLine();

// SwapArray(arr);

// SwapArray1(arr);



// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


// bool NewNum(double X, double Y, double Z)
// {
//     if (X < Y + Z && Y < Z + X && Z < X + Y)
//     {
//         return true;

//     }
//     else
//     {
//         return false;
//     }
// }

// double A = new Random().NextDouble();
// Console.WriteLine("{0:f5}", A);

// double B = new Random().NextDouble();
// Console.WriteLine("{0:f5}", B);

// double C = new Random().NextDouble();
// Console.WriteLine("{0:f5}", C);

// if (NewNum(A, B, C))
// {
//     Console.WriteLine("треугольник существует");
// }
// else
// {
//     Console.WriteLine("треугольник не существует");
// }


// дополнение

// bool TreangleProof(int [] arr)
// {
//     bool proof1 = false;
//     bool proof2 = false;
//     bool proof3 = false;

//     if(arr[0] < arr[1] + arr[2]) proof1 = true;
//     if(arr[1] < arr[0] + arr[2]) proof2 = true;
//     if(arr[2] < arr[1] + arr[0]) proof3 = true;

//     return proof1 && proof2 && proof3;
// }


// HOMEWORK6


// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Console.WriteLine("Input X : ");
// int x = Convert.ToInt32(Console.ReadLine());
// string res = "";
// while (x > 0)
// {
//     res = ((x % 2 == 0) ? "0" : "1") + res;
//     x /= 2;
// }
// Console.Write(res);




// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.


// Console.WriteLine("Input n : ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] f = new int[n];
// f[0] = 0;
// f[1] = 1;
// for (int i = 2; i < n; ++i) {
//     f[i] = f[i - 1] + f[i - 2];
//     Console.Write( f[i] + " ");
// }

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Console.Write("Введите элементы(через пробел): ");
// int[] list = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < list.Length; i++)
// {
//     if (list[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");

// Seminar 7

// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++){
//         array[i,j] = new Random().Next(min, max + 1);  
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }

// }


// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());



// int[,] myArray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myArray);


// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


// int[,] CreateArray(int m, int n)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++){
//         array[i,j] = i+j;  
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());



// int[,] myArray = CreateArray(rows, columns);
// ShowArray(myArray);


// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++){
//         array[i,j] = new Random().Next(min, max + 1);  
//         }
//     }
//     return array;
// }
// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++){
//                 if(i%2 ==0 && j%2 ==0 && i!=0 && j!=0)
//                     Console.Write( $"|{array[i,j] }|");
//                     else

//                         Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// void EvenArray(int[,] array)
// {

//     for (int i = 2; i < array.GetLength(0); i++)
//     {
//         for (int j = 2; j < array.GetLength(1); j++){
//             if(i%2 ==0 && j%2 ==0)
//                 array[i,j] *= array[i,j];
//         }
//     }

// }


// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());



// int[,] myArray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myArray);
// Console.WriteLine();
// EvenArray(myArray);
// ShowArray(myArray);

// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++){
//         array[i,j] = new Random().Next(min, max + 1);  
//         }
//     }
//     return array;
// }
// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }
// }
// int SumNumber(int[,] array)
// {
// int sum = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++){
//             if(i==j)
//                 sum = array[i,j];
//         }
//     }
//     return sum;
// }


// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());



// int[,] myArray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myArray);
// Console.WriteLine();
// Console.WriteLine(SumNumber(myArray));



// --------------------------------------
// HOMEWORK 7

// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// Console.WriteLine($"Задача 47: Задайте двумерный массив размером m x n, заполненный случайными вещественными числами.");

// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Clear();
// Console.WriteLine($"m = {m}, n = {n}.");

// double[,] array = new double[m, n];

// CreateArrayDouble(array);

// WriteArray(array);

// Console.WriteLine();

// void CreateArrayDouble(double[,] array)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       array[i, j] = new Random().NextDouble() * 20 - 10;
//     }
//   }
// }

// void WriteArray (double[,] array){
// for (int i = 0; i < m; i++)
//   {
//       for (int j = 0; j < n; j++)
//       {
//         double alignNumber = Math.Round(array[i, j], 1);
//         Console.Write(alignNumber + " ");
//       }
//       Console.WriteLine();
//   }
// }

// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого числа в массиве нет


// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m,n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++){
//         array[i,j] = new Random().Next(min, max + 1);  
//         }
//     }
//     return array;
// }

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i,j] + " ");
//         }
//     Console.WriteLine();
//     }

// }

// int LocalElemInTaple(int[,] array)
// {
// Console.WriteLine("indexI: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("indexJ: ");
// int b = Convert.ToInt32(Console.ReadLine());
//     Console.Write(array[a,b] + " ");
//     return array[a,b];
// }

// Console.WriteLine("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());



// int[,] myArray = CreateRandomArray(rows, columns, min, max);
// ShowArray(myArray);
// LocalElemInTaple(myArray);


// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// Console.Write("Введите m: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите n: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Console.Clear();
// Console.WriteLine($"m = {m}, n = {n}.");

// double[,] array = new double[m, n];

// CreateArrayDouble(array);

// WriteArray(array);

// Console.WriteLine();

// void CreateArrayDouble(double[,] array)
// {
//   for (int i = 0; i < m; i++)
//   {
//     for (int j = 0; j < n; j++)
//     {
//       array[i, j] = new Random().NextDouble() * 20 - 10;
//     }
//   }
// }

// void WriteArray (double[,] array){
// for (int i = 0; i < m; i++)
//   {
//       for (int j = 0; j < n; j++)
//       {
//         double alignNumber = Math.Round(array[i, j], 1);
//         Console.Write(alignNumber + " ");
//       }
//       Console.WriteLine();
//   }
// }


// int[,] arrayWhole = new int[m, n];
// arrayWhole = TransformationArrayWhole(array);

// WriteArrayInt(arrayWhole);

// Console.Write($"\nCреднее арифметическое:\n");
// for (int i = 0; i < n; i++)
// {
//   double arithmeticMean = 0;
//   for (int j = 0; j < m; j++)
//   {
//     arithmeticMean += arrayWhole[j, i];
//   }
//   arithmeticMean = Math.Round(arithmeticMean / m, 1);
//   Console.WriteLine($"столбца № {i+1} {arithmeticMean}");
// }

// int[,] TransformationArrayWhole (double[,] array)
// {
//   int[,] arrayWhole = new int[array.GetLength(0), array.GetLength(1)];
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       arrayWhole[i, j] = Convert.ToInt32(array[i, j]);
//     }
//   }
//   return arrayWhole;
// }

// void WriteArrayInt (int[,] arrayWhole){
// for (int i = 0; i < m; i++)
//   {
//       for (int j = 0; j < n; j++)
//       {
//         Console.Write(arrayWhole[i, j] + " ");
//       }
//       Console.WriteLine();
//   }
// }


// Seminar 8

// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.


// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
// int[,] array = new int[m, n];
// for (int i = 0; i < m; i++)
// {
// for (int j = 0; j < n; j++)
// {
// array[i, j] = new Random().Next(min, max + 1);
// }
// }
// return array;
// }

// void ShowArray(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
// Console.Write(array[i, j] + " ");
// }
// Console.WriteLine();
// }
// }

// void SwapArray(int[,] array)
// {
// int buf = 0;
// int lastRow = array.GetLength(0) - 1;
// for (int column = 0; column < array.GetLength(1); column++)
// {
// buf = array[0, column];
// array[0, column] = array[lastRow, column];
// array[lastRow, column] = buf;
// }
// }

// Console.WriteLine("Enter number of rows");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number of columns");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter number");


// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// HOMEWORK 8 
// ----------------------------------------


// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.


// int m = InputNumbers("Input m: ");
// int n = InputNumbers("input n: ");
// int range = InputNumbers("Spacing input:  ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// Console.WriteLine($"\nsorted: ");
// OrderArrayLines(array);
// WriteArray(array);

// void OrderArrayLines(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int k = 0; k < array.GetLength(1) - 1; k++)
//       {
//         if (array[i, k] < array[i, k + 1])
//         {
//           int temp = array[i, k + 1];
//           array[i, k + 1] = array[i, k];
//           array[i, k] = temp;
//         }
//       }
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i, j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.


// int m = InputNumbers("Input m: ");
// int n = InputNumbers("input n: ");
// int range = InputNumbers("Spacing input:  ");

// int[,] array = new int[m, n];
// CreateArray(array);
// WriteArray(array);

// int minSumLine = 0;
// int sumLine = SumLineElements(array, 0);
// for (int i = 1; i < array.GetLength(0); i++)
// {
//   int tempSumLine = SumLineElements(array, i);
//   if (sumLine > tempSumLine)
//   {
//     sumLine = tempSumLine;
//     minSumLine = i;
//   }
// }

// Console.WriteLine($"\n{minSumLine+1} - Less Sum ({sumLine}) elements");


// int SumLineElements(int[,] array, int i)
// {
//   int sumLine = array[i,0];
//   for (int j = 1; j < array.GetLength(1); j++)
//   {
//     sumLine += array[i,j];
//   }
//   return sumLine;
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// Console.WriteLine($"\ninput Matrix size:");
// int m = InputNumbers("rows of 1 Matrix: ");
// int n = InputNumbers("input columns of 1 Matrix : ");
// int p = InputNumbers("input columns of 2 Matrix : ");
// int range = InputNumbers("Spacing of numbers ");

// int[,] firstMartrix = new int[m, n];
// CreateArray(firstMartrix);
// Console.WriteLine($"\n1 Matrix:");
// WriteArray(firstMartrix);

// int[,] secomdMartrix = new int[n, p];
// CreateArray(secomdMartrix);
// Console.WriteLine($"\n2 Matrix:");
// WriteArray(secomdMartrix);

// int[,] resultMatrix = new int[m,p];

// MultiplyMatrix(firstMartrix, secomdMartrix, resultMatrix);
// Console.WriteLine($"\nMole Matrix:");
// WriteArray(resultMatrix);

// void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
// {
//   for (int i = 0; i < resultMatrix.GetLength(0); i++)
//   {
//     for (int j = 0; j < resultMatrix.GetLength(1); j++)
//     {
//       int sum = 0;
//       for (int k = 0; k < firstMartrix.GetLength(1); k++)
//       {
//         sum += firstMartrix[i,k] * secomdMartrix[k,j];
//       }
//       resultMatrix[i,j] = sum;
//     }
//   }
// }

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void CreateArray(int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       array[i, j] = new Random().Next(range);
//     }
//   }
// }

// void WriteArray (int[,] array)
// {
//   for (int i = 0; i < array.GetLength(0); i++)
//   {
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       Console.Write(array[i,j] + " ");
//     }
//     Console.WriteLine();
//   }
// }


// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.



// int x = InputNumbers("Input X: ");
// int y = InputNumbers("Input Y: ");
// int z = InputNumbers("Input Z: ");


// int[,,] array3D = new int[x, y, z];
// CreateArray(array3D);
// WriteArray(array3D);

// int InputNumbers(string input)
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }

// void WriteArray (int[,,] array3D)
// {
//   for (int i = 0; i < array3D.GetLength(0); i++)
//   {
//     for (int j = 0; j < array3D.GetLength(1); j++)
//     {
//       Console.Write($"X({i}) Y({j}) ");
//       for (int k = 0; k < array3D.GetLength(2); k++)
//       {
//         Console.Write( $"Z({k})={array3D[i,j,k]}; ");
//       }
//       Console.WriteLine();
//     }
//     Console.WriteLine();
//   }
// }

// void CreateArray(int[,,] array3D)
// {
//   int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
//   int  number;
//   for (int i = 0; i < temp.GetLength(0); i++)
//   {
//     temp[i] = new Random().Next(10, 100);
//     number = temp[i];
//     if (i >= 1)
//     {
//       for (int j = 0; j < i; j++)
//       {
//         while (temp[i] == temp[j])
//         {
//           temp[i] = new Random().Next(10, 100);
//           j = 0;
//           number = temp[i];
//         }
//           number = temp[i];
//       }
//     }
//   }
//   int count = 0; 
//   for (int x = 0; x < array3D.GetLength(0); x++)
//   {
//     for (int y = 0; y < array3D.GetLength(1); y++)
//     {
//       for (int z = 0; z < array3D.GetLength(2); z++)
//       {
//         array3D[x, y, z] = temp[count];
//         count++;
//       }
//     }
//   }
// }


// Задача 62: Заполните спирально массив 4 на 4.

int n = 4;
int[,] sqareMatrix = new int[n, n];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
{
  sqareMatrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(sqareMatrix);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i,j]} ");

      else Console.Write($"{array[i,j]} ");
    }
    Console.WriteLine();
  }
}