
    
// Sem 3
// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.




// void getDot (int x, int y){
//     if (x == 0 || y == 0){
//         Console.WriteLine("Нет возможности определить четверть");
//     }else{
//         if(x > 0 && y > 0) 
//             Console.WriteLine("1 четверть");
//         if(x > 0 && y < 0)
//             Console.WriteLine("4 четверть");
//         if(x < 0 && y > 0) 
//             Console.WriteLine("2 четверть");
//         if(x < 0 && y < 0)
//             Console.WriteLine("3 четверть");
//     }
// }

// Console.WriteLine("Введите две точки: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// int y1 = Convert.ToInt32(Console.ReadLine());

// getDot(x1, y1);


// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void getDot (int num){
//     if (x == 0 || y == 0){
//         Console.WriteLine("Нет возможности определить четверть");
//     }else
//     {
//         if(num == 1) 
//             Console.WriteLine("X > 0; Y > 0");
//     else if(num == 2)
//             Console.WriteLine("X < 0; Y > 0");
//     else if(num == 3)
//             Console.WriteLine("X < 0; Y < 0");
//     else if(num == 4)
//             Console.WriteLine("X < 0; Y > 0");
//         else
//         { Console.WriteLine("Нет возможности определить четверть");}
//     }
// }

// Console.WriteLine("номер четверти: ");
// int x1 = Convert.ToInt32(Console.ReadLine());


// getDot(x1);

// void getDot(int q)
// {
//     if (q <= 0 || q > 4)
//     {
//         Console.WriteLine("Нет возможности определить диапазон");
//     }
//     else
//     {
//         if (q == 1)
//             Console.WriteLine("диапазон Х > 0 и Y > 0");
//         else if (q == 2)
//             Console.WriteLine("диапазон Х > 0 и Y < 0");
//         else if (q == 3)
//             Console.WriteLine("диапазон Х < 0 и Y < 0");
//         else
//             Console.WriteLine("диапазон Х < 0 и Y > 0");
//     }
// }

// Console.WriteLine("Введите четверть: ");
// int q1 = Convert.ToInt32(Console.ReadLine());

// getDot(q1);


// 3 задача

// Console.Clear();
// double distAB(int x1,int y1,int x2,int y2){
//     return Math.Sqrt(Math.Pow(Math.Abs((x2-x1)),2) +Math.Pow(Math.Abs((y2-y1)),2) );
// }

// Console.WriteLine("X1 = ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y1 = ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("X2 = ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y1 = ");
// int yB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("dist =  " + Math.Round(distAB(xA,yA,xB,yB)));

// Math.Round округление
// Math.Pow((x2-x1),2) возведение в степень 2
// Math.Abs модуль



// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N

// void listSqrt(int n){
//     int count = 1;

//     Console.Write(n + "->");

//     while (count <= n){
//         Console.WriteLine(Math.Pow(count,2) + ",");
//         count++;
//     }

// }

// Console.WriteLine("n = ");
// int num = Convert.ToInt32(Console.ReadLine());

// listSqrt(num);


// Console.Clear();

// void listSqrt(int n)
// {
//     int count = 1;

//     Console.Write(n + "-> ");

//     if (n > 0)
//     {

//         while (count <= n)
//         {
//             Console.Write(Math.Pow(count, 2) + ", ");
//             count++;
//         }
//     }
//     else
//     {
//         count = -1;
//         while (count >= n)
//         {
//             Console.Write(Math.Pow(count, 2) + ", ");
//             count--;
//         }
//     }
// }

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// listSqrt(num);



// HOMEWORK3



// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// void result(int a){
//     if (a > 9999 && a < 100000) {
//         if ((a % 10) == (a / 10000 % 10)){
//             if ((a /10 % 10) == (a /1000 % 10)) {
//                 Console.WriteLine("палиндром");
//             }
//             // Console.WriteLine("палиндром");
//             else
//         {
//             Console.WriteLine("не палиндром");
//         }
//         }
//         else
//         {
//             Console.WriteLine("не палиндром");
//         }
        
        
//     }
//     else {
//     Console.WriteLine(" нет ");
//     }
// }

// Console.WriteLine("Введите пятизначное число");
// int n1 = Convert.ToInt32(Console.ReadLine());

// result(n1);


// Напишите программу, которая принимет на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Clear();
// double distAB(int x1,int y1,int z1,int x2,int y2,int z2){
//     return Math.Sqrt(Math.Pow(Math.Abs((x2-x1)),2) + Math.Pow(Math.Abs((y2-y1)),2) + Math.Pow(Math.Abs((y2-y1)),2) );
// }

// Console.WriteLine("X1 = ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y1 = ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Z1 = ");
// int zA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("X2 = ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y1 = ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Z2 = ");
// int zB = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("dist =  " + Math.Round(distAB(xA,yA,zA,xB,yB,zB)));



// Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел  от 1 до N.
// 

// void listSqrt(int n){
//     int count = 1;

//     Console.Write(n + "->");

//     while (count <= n){
//         Console.WriteLine(Math.Pow(count,3) + ",");
//         count++;
//     }

// }

// Console.WriteLine("n = ");
// int num = Convert.ToInt32(Console.ReadLine());

// listSqrt(num);