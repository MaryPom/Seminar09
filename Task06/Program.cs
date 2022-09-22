// Задача 6. Написать программу возведения числа А в целую стень B
Console.Write("Введите значение a = ");
int a = int.Parse(Console.ReadLine()); 
Console.Write("Введите значение b = ");
int b = int.Parse(Console.ReadLine()); 
int counter = 1;
int pow = 1;
while (counter <= b)
    { 
    pow = pow * a;
    counter++;
    }
Console.Write("Число a в степени b " + " равно " + pow);
