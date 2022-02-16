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