// Напишите программу, которая принимает на вход три числа 
// и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число");
string value;
value = Console.ReadLine();
int numberA = Convert.ToInt32(value);

Console.Write("Введите второе число");
value = Console.ReadLine();
int numberB = Convert.ToInt32(value);

Console.Write("Введите третье число");
value = Console.ReadLine();
int numberD = Convert.ToInt32(value);
int max = 0;
if ((numberA > numberB) && (numberA > numberD))
{
   max = numberA;
}
else
if ((numberB > numberA) && (numberB > numberD))
{    
   max = numberB;
}
else
if ((numberD > numberA) && (numberD > numberB))
{   
   max = numberD;
}
Console.WriteLine("Найбольшее из трёх ");
Console.Write(max);