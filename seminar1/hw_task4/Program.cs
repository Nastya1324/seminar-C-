// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите число 1:");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 2:");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число 3:");
int numberC = Convert.ToInt32(Console.ReadLine());

if(numberA < numberC && numberB < numberC)
{
    Console.WriteLine(numberC);
}

if(numberA > numberB && numberA > numberC)
{
    Console.WriteLine(numberA);
}

if(numberA < numberB && numberC < numberB)
{
    Console.WriteLine(numberB);
}

if(numberA == numberB && numberA > numberC)
{
    Console.WriteLine(numberA);
}

if(numberA == numberC && numberA > numberB)
{
    Console.WriteLine(numberA);
}

if(numberB == numberC && numberB > numberA)
{
    Console.WriteLine(numberB);
}

if(numberA == numberB && numberA == numberC && numberB == numberC)
{
    Console.WriteLine("Не выполняется условие задачи");
}
