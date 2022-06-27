
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



int[] CreateRandomArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++){
        array [i] = new Random().Next(0,10);
    }
    return array;
}

int[] myRandomArray = CreateRandomArray(8);
ShowArray(myRandomArray);

Console.WriteLine();


void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++){
        Console.Write(array[i]+ " ");
    }
}

