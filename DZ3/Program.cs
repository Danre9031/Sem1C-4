
int[] arr = new int[8]; 

for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }

Vivodmasiv(arr);

void Vivodmasiv(int[] arr)
{
    int size=arr.Length;
    Console.WriteLine(size);
    Console.Write($"[");
    for(int i = 0; i < size-1; i++)
    {
        Console.Write($"{arr[i]},");
    }
    Console.Write($"{arr[size-1]}]");
    Console.WriteLine();
}

