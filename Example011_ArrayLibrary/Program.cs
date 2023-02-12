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

int [] array = new int[10]; // по умолчанию массив наполнен нулями
FillArray(array);
PrintArray(array);


