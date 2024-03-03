
Console.WriteLine("Enter a word");
string userWord = Console.ReadLine();

PrintAnyWord(userWord); 

static void PrintAnyWord(string anyString)
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i ++)
    {
        Console.WriteLine(anyString);
    }
}