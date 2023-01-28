Console.WriteLine("Введите количество слов");
int n = Convert.ToInt32(Console.ReadLine());
string[] matrix = new string[n];
for (int i = 0; i < n; i++)
{
Console.WriteLine($"Введите слово {i+1}");
matrix[i] = Convert.ToString(Console.ReadLine());
}
int count = 0;
for (int i = 0; i < n; i++)
{
int length = matrix[i].Length;
if (length <= 3)
{
count++;
}
}
string[] newmatrix = new string[count];
for (int i = 0; i < n; i++)
{
int length = matrix[i].Length;
if (length <= 3)
{
    newmatrix[i] = matrix[i];
}    
}
for (int i = 0; i < count; i++)
{
        Console.WriteLine(newmatrix[i]);
}
