// Задача 2. Показать натуральные числа от M до N, N и M заданы
Console.WriteLine("Введите значение M: ");
int M = int.Parse (Console.ReadLine());
Console.WriteLine("Введите значение N: ");
int N = int.Parse (Console.ReadLine());
int count = M;

while (count <= N)
{
    Console.WriteLine(count);
    count = count + 1;
}
