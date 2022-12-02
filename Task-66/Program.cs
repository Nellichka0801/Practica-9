// Задайте значения M и N. Напишите программу, которая найдёт 
//сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine()!);

int result = SumOfNumbersFromMtoN(m, n);

Console.WriteLine($"Cуммa чисел от {m} до {n} равна {result}");


int SumOfNumbersFromMtoN(int m, int n)
{
    int result = 0;  
    while (m <=n)
    {
       result = result+m; m++;
       SumOfNumbersFromMtoN(m, n); 
    }
    return result;
}

