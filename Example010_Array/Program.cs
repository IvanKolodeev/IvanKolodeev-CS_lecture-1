void FillArray(int[] collection)
{
    for (int i = 0; i < collection.Length; i++)
    collection[i] = new Random().Next(1, 100);
}

void PrintArray(int[] col)
{
    for (int i = 0; i < col.Length; i++)
    Console.Write(col[i] + "  ");
}

void IndexOf (int[] collection, int find)
{
    int index = -1;
    for (int i = 0; i < collection.Length; i++)
    if (collection[i] == find)
    {
        index = i;
        Console.WriteLine("Index of this number is: " + index);
        break;
    }
    if (index == -1)  Console.WriteLine("Number not detected");
}


Console.Write("Please enter the array length: ");
int lengt = int.Parse(Console.ReadLine()!);
int [] array = new int[lengt];
FillArray(array);
PrintArray(array);

Console.WriteLine("");
Console.Write("Please enter the number: ");
int find = int.Parse(Console.ReadLine()!);

IndexOf(array, find);