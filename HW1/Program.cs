/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int f(int m, int n) 
{ 
    if (n == m) 
        return n; 

    return f(m + 1, n) + m;  
} 

int m = Convert.ToInt32(Console.ReadLine()); 
int n = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(f(m, n));