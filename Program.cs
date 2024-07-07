
    string[] UserArray (int n)
{
    string[] array = new string[n];
    int c = 1;
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите " + c + " символьную строку массива пользователя: ");
        array[i] = Convert.ToString(Console.ReadLine());
        c++;
    }
    return array;
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write("'{0}'", array[i]);
        Console.Write(",");
    }
    Console.Write("'{0}'", array[array.Length - 1]);
    Console.Write("]");
    Console.WriteLine();
}

int LineCounter(string[] array)
{
    int k = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string currentString = array[i];
        int length = currentString.Length;
        if (length <= 3)
        {
            k++;
        }
    }
    return k;
}

string[] NewArray (string[] array)
{
    string[] newarray = new string[LineCounter(array)];
        int j = 0;
        for (int i = 0; i < array.Length; i++)
        {
            string currentString = array[i];
            int length = currentString.Length;
            if (length <= 3)
            {
                newarray[j] = array[i];
                j++;
            }
        }
        return newarray;
}

void PrintNewArray (string[] newarray)
{
    if (newarray.Length == 0)
    {
        Console.Write("]");
        return;
    }   
    for (int i = 0; i < newarray.Length - 1; i++)
    {
        Console.Write("'{0}'", newarray[i]);
        Console.Write(",");
    }
    Console.Write("'{0}'", newarray[newarray.Length - 1]);
    Console.Write("]");
}

Console.Write("Введите размер одномерного массива: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] myArray = UserArray(n);
Console.Write("Создан массив пользователя из " + n + " элементов: [");
PrintArray(myArray);
Console.Write("Создан новый массив из строк массива пользователя длина которых меньше, либо равна 3 символам: [");
PrintNewArray(NewArray(myArray));
