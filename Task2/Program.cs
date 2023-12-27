// Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n. 



int ReadInt (string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int PrintNumber(int M, int N)
{
    if (M == 0) return N + 1;
    if (M>0 && N ==0) return PrintNumber(M-1,1);
    if (M>0 && N>0) return PrintNumber(M-1,PrintNumber(M,N-1));
    return N;
   
}


//______________________________________

int value1 = ReadInt("Введите число M: ");
int value2 = ReadInt("Введите число N: ");
Console.WriteLine(Convert.ToInt32(PrintNumber(value1, value2)));