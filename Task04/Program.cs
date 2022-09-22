// Задача 4. Найти сумму цифр числа
Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
if(n >= 100 & n <= 1000)
{
    int last = n % 10;
    int first = n / 100;
    int second = (n / 10) % 10;
}
int sum = (n / 100) + (n / 10) % 10 + (n % 10);
Console.WriteLine("Сумма цифр числа: " + sum);

