string[] OriginalArray = SetArrayStr();
Console.Clear();
GetStrArrayMaxChar(OriginalArray);

static string[] SetArrayStr(string Mesadge = "Enter the elements of the initial array separated by commas: ", char SplitChar = ',')
{
    Console.WriteLine(Mesadge);
    string input = Console.ReadLine();
    string[] originalArray = input.Split(SplitChar);
    return originalArray;
}

static string[] GetStrArrayMaxChar(string[] originalArray)
{
    string[] newArray = new string[originalArray.Length];
    int j = 0;
    for (int i = 0; i < originalArray.Length; i++)
    {
        if (originalArray[i].Length <= 3)
        {
            newArray[j] = originalArray[i];
            j++;
        }
    }

    Console.WriteLine("Initial array: [" + string.Join(", ", originalArray) + "]");
    Console.Write("New array: [");
    for (int i = 0; i < j; i++)
    {
        Console.Write(newArray[i]);
        if (i < j - 1) Console.Write(", ");
    }
    Console.Write("]");

    return newArray;
}