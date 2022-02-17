string[] stringArray = new string[] { "abcde", "abc", "ab", "abcd", "abc","5"};

int lengthOfNewArray = 0;
for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3)
    {
        lengthOfNewArray++;
    }
}

var newArray = new string[lengthOfNewArray];

int count = 0;
for (int i = 0; i < stringArray.Length; i++)
{
    if (stringArray[i].Length <= 3)
    {
        count++;
        newArray[count - 1] = stringArray[i];
    }
}

void PrintArray(string[] someArray)
{
    Console.Write("[");
    for (int i = 0; i < someArray.Length - 1; i++)
    {
        Console.Write($"{someArray[i]}, ");
    }
    Console.Write(someArray[someArray.Length - 1]);
    Console.Write("]");
}

PrintArray(stringArray);
Console.Write("->");
PrintArray(newArray);

