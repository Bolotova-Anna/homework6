// Пользователь вводит с клавиатуры M чисел. Посчитайте,
//  сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
int[] FoundFillArray(string text, int number)
{
System.Console.WriteLine(text);
int[] array = new int[number];
array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
return  array;
}
void Print(int[] array)
{
    System.Console.WriteLine("["+string.Join(",", array)+"]");
}
void Count(int[] array)
{
    int count = 0;
    for (int i = 0; i <array.Length; i++)
    {
        if (array[i]>0)
        count++;
    }
    System.Console.WriteLine("пользоваель ввел "+ count +" положительных числа");
}
int[] myarray = FoundFillArray("введите числа для заполнения массива", 6);
Print(myarray);
Count(myarray);