// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.Write("Введите 1 число: ");
int numberA = int.Parse(Console.ReadLine()); 
Console.Write("Введите 2 число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB) 
{
    Console.WriteLine($"max = {numberA}, min = {numberB}");
}
else if (numberA < numberB)
{
    Console.WriteLine($"max = {numberB}, min = {numberA}");
}
else if (numberA == numberB)
{
    Console.WriteLine("Введенные числа равны");
}