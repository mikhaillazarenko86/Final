
int EnterWords(string message) 
{
    Console.WriteLine(message);
    int count = Convert.ToInt32(Console.ReadLine());
    return count;
}
string[] FillArray(int length)
{
    string[] array = new string[length];
    for (int i = 0; i < length; i++)
    {
       Console.WriteLine($"Введите слово {i+1}");
       array[i] = Convert.ToString(Console.ReadLine());     
    }
return array;
} 
int CountOfWords(string[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
if (array[i].Length <= 3)
{
count++;
}
}
return count;
}
string[] NewArray(int n, string[] array)
{
    string[] newarray = new string[n];
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i].Length <= 3)
       newarray[i] = array[i];     
    }
return newarray;
} 
int quantity = EnterWords("Введите количество слов");
string[] WordsArray = FillArray(quantity);
Console.WriteLine("");
Console.WriteLine($"{string.Join(", ", WordsArray)}");
Console.WriteLine("");
int count = CountOfWords(WordsArray);
string[] result = NewArray(count, WordsArray);
Console.WriteLine($"{string.Join(", ", result)}");
