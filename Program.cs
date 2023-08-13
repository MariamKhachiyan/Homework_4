/* Задача 25: Напишите цикл, который принимает на вход два числа 
(A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
 */

/*  Console.WriteLine("Enter first number");
 int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number");
 int num2 = Convert.ToInt32(Console.ReadLine());


 int Power()
 {
     int res = num1;
     for (int i = 1; i < num2; i++)
     {
         res = res * num1;
     }
     return res;
 }
 Console.WriteLine();
 Console.WriteLine(Power());
 
 */

 //Задача 27: Напишите программу, которая принимает на 
 //вход число и выдаёт сумму цифр в числе.
/* 452 -> 11
82 -> 10
9012 -> 12 */

/* Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
string numS = Convert.ToString(num);


int GetSum()
{
     int res = 0;
     int size = numS.Length;
     for (int i = 0; i < size; i++)
     {
         res += num % 10;
         num /= 10;
     }
     return res;
 }
 Console.WriteLine();
 Console.WriteLine(GetSum()); */



/* 
 int SumNumbers(string number)
{
    int[] arr = new int[number.Length];
    int sum = 0;
    for (int i = 0; i < number.Length; i++)
    {
        arr[i] = int.Parse(number[i].ToString());
        sum = sum + arr[i];
    }
    return sum;
}
string Digit(string text)
{
    Console.Write(text);
    return Console.ReadLine();
}
string num = Digit("Enter number: ");
int sumValue = SumNumbers(num);
Console.Write($"Sum of the digitis of number  {num} is equal to: {sumValue}"); */



/* 

Задача 29: Напишите программу, которая задаёт 
массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
 */

 
/* 
 int[] array = new int[8];
for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(100);
}
Console.WriteLine($"[{String.Join(",", array)}]"); */