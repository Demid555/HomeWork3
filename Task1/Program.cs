// Задайте значения M и N. Напишите
// программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не
// использовать циклы.


int ReadInt (string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintNumber(int M, int N)
{
    if (N < M) return;
  
    
    PrintNumber(M, N - 1);
    Console.Write(N + " ");
   
}


//______________________________________

int value1 = ReadInt("Введите число M: ");
int value2 = ReadInt("Введите число N: ");
PrintNumber(value1, value2);