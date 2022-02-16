string [] stringArray = new string[] {"abcde", "abc", "ab","abcd","abc"};

int CountForNewArray(string[] ArrayForCounting)
{
    int count = 0;
    for (int i = 0; i < ArrayForCounting.Length; i++)
    {
        if (ArrayForCounting[i].Length <=3)
        {
            count++;
        }
    }
    return count;
}

string [] newStringArray = string [count];

void CreateNewArray(string [] oldArray, string [] newArray)
{
    for (int i = 0; i < oldArray.Length; i++)
    {
        if (oldArray[i].Length <= 3)
        {
            newArray[i] = oldArray[i];
        }
    }
}
