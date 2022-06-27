
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



int[] CreateRandomArray(int size, int min, int max){
    int[] array = new int[size];
    for(int i = 0; i < size; i++){
        array[i] = new Random().Next(min,max+1);
    }
    return array;
}


void ShowArray (int[] array){

    for (int i = 0; i < array.Length; i++){
    Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int[] myArray = CreateRandomArray(5, 1, 9);
ShowArray(myArray);

int max = myArray[0];
int min = myArray[0];
for (int i = 0; i < myArray.Length; i++)
{
    if (max < myArray[i])
    {
        max = myArray[i];
        }
    else if (min > myArray[i])
    {
        min = myArray[i];
        }
    
}

Console.WriteLine($"числа: {max} {min} разность {max - min}");

