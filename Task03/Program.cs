// Задача 3. Найти сумму элементов от M до N, N и M заданы
Console.Write("Введите значение M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите значение N: ");
int N = int.Parse(Console.ReadLine());
Console.WriteLine($"Result, S = {SumNumbers(M, N)}");
 
static int SumNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;           
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                       
    else if (M < N) return N + SumNumbers(M, N - 1); 
    else return N + SumNumbers(M, N + 1);        
}