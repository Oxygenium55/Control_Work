/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести
с клавиатуры, либо задать на старте выполнения алгоритма.
*/

void TransformArray(string[] array1, string[] array2)
{
    int index = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[index] = array1[i];
        index++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] baseArray = new string[8] {"wow", "2022", "hello", "world", "!", ":-)", "-17", "C"};
string[] resultArray = new string[baseArray.Length];
TransformArray(baseArray, resultArray);
PrintArray(baseArray);
PrintArray(resultArray);
