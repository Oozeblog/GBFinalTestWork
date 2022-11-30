string[] CreateArray(int size)
{
    string[] arrayString = new string[size]; 
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
string[] CreateThreeCharArray(string[] array)
{
    int size = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        size++;
    }
    string[] threeCharArray = new string[size];

    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < threeCharArray.Length; j++)
        {
            if(array[i].Length <= 3)
            threeCharArray[j] = array[i];
        }
    }
    return threeCharArray;
}
Console.WriteLine("Введите колличество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] myArray = CreateArray(n);
Console.WriteLine("Исходный массив строк: ");
ShowArray(myArray);

Console.WriteLine("Массив из строк, длина которых меньше, либо равна 3 символам: ");
string [] newArray = CreateThreeCharArray(myArray);
ShowArray(newArray);
