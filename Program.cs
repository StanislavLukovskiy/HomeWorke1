// Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число");
string value;
value = Console.ReadLine();
int numberA = Convert.ToInt32(value);

Console.Write("Введите второе число");
value = Console.ReadLine();
int numberB =Convert.ToInt32(value);
if (numberA > numberB)
{
    System.Console.Write("Большее ");
    Console.WriteLine(numberA);
    System.Console.Write("Меньшее ");
    Console.WriteLine(numberB);
}
else
{
    System.Console.Write("Большее ");
    Console.WriteLine(numberB);
    System.Console.Write("Меньшее ");
    Console.WriteLine(numberA);
}