Console.WriteLine("Введите строки через запятую:");
string input = Console.ReadLine();

string[] originalArray = input.Split(',');

int count = 0;
for (int i = 0; i < originalArray.Length; i++)
{
    if (originalArray[i].Length <= 3)
    {
        count++;
    }
}

string[] newArray = new string[count];
int index = 0;
for (int i = 0; i < originalArray.Length; i++)
{
    if (originalArray[i].Length <= 3)
    {
        newArray[index++] = originalArray[i];
    }
}

Console.Write("Новый массив: ");
for (int i = 0; i < newArray.Length; i++)
{
    Console.Write(newArray[i] + " ");
}


