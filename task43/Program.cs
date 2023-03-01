// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
System.Console.WriteLine("введите b1"); 
double b1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите k1"); 
double k1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите b2"); 
double b2 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("введите k2"); 
double k2 = Convert.ToInt32(Console.ReadLine());
double temp = b2-b1;
double temp2 = k1-k2;
double x = temp/temp2;
System.Console.WriteLine("икс = " + x );
double y1 = k1 * x + b1;
System.Console.WriteLine("игрэк = " + y1 );
System.Console.WriteLine("точка пересечения имеет кооридинаты: (" + x + ","+ y1 +")");