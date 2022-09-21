// Задача 1. Показать натуральные числа от N до 1, N задано
Console.WriteLine("Введите значение N: ");
int N = int.Parse (Console.ReadLine());
int count = N;

while (count < 2)
{
    Console.WriteLine(count);
    count = count + 1;
}
while (count > 2)
{
    Console.WriteLine("Введите другое значение N");
    break;
}
