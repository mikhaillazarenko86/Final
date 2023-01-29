// Console.WriteLine("Введите количество слов");
// int n = Convert.ToInt32(Console.ReadLine());
// string[] matrix = new string[n];
// for (int i = 0; i < n; i++)
// {
// Console.WriteLine($"Введите слово {i+1}");
// matrix[i] = Convert.ToString(Console.ReadLine());
// }
// int count = 0;
// for (int i = 0; i < n; i++)
// {
// int length = matrix[i].Length;
// if (length <= 3)
// {
// count++;
// }
// }
// string[] newmatrix = new string[count];
// for (int i = 0; i < n; i++)
// {
// int length = matrix[i].Length;
// if (length <= 3)
// {
//     newmatrix[i] = matrix[i];
// }    
// }
// for (int i = 0; i < count; i++)
// {
//         Console.WriteLine(newmatrix[i]);
// }
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

int count = EnterWords("Введите количество слов");
Console.WriteLine(count);
string[] WordsArray = FillArray(count);
Console.WriteLine($"{string.Join(", ", WordsArray)}");