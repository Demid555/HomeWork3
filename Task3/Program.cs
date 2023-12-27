// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.


void PrintArray(int[] array, int i = 0)

{
    if (i == array.Length) return;
    PrintArray(array, i + 1);
    Console.Write(Convert.ToInt32(array[i]));
    Console.Write(" ");
}



int[] myArray = {2 , 4 , 53, 6, 7};
PrintArray(myArray, 0);