string [] str = new string[4] {"Hello", "2", "world", ":-"};
string [] array = new string[4];
void FindNewArray(string[] str, string[] array, int j = 0)
{
    for (int i = 0; i < str.Length; i++)
    {
        if (str[i].Length <= 3)
        {
           array[j] = str[i];
           j++;
        }
    }
}
void PrintArray(string[] mass)
{
    for(int k = 0; k < array.Length; k++)
    {
        Console.Write($"{array[k]}" + "\t");
    }
    Console.WriteLine();
}
FindNewArray(str, array);
 PrintArray(array);

