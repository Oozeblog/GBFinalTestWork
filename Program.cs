string[] CreateRandomArray(int size)
{
    string [] arrayString = new string[size]; 
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine("Введите слово: ");
        arrayString[i] = Console.ReadLine();
    }
    return arrayString;
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите колличество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateRandomArray(n);
ShowArray(myArray);

