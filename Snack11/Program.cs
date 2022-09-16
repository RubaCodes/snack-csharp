

static string CheckLength(string word1, string word2)
{
    if (word1.Length == word2.Length)
    {
        return word1+" "+word2;
    }
    else
    {
        if (word1.Length > word2.Length)
        {
            return word1;
        }
        else {
            return word2;
        }
    }
}

Console.WriteLine("Inserire prima parola");
    string input1 = Console.ReadLine();
    Console.WriteLine("Inserire seconda parola");
    string input2 = Console.ReadLine();

    Console.WriteLine(CheckLength(input1, input2));


