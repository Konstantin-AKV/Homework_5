// Задача 34: Массив и сколько в нем четных)

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] mass = new int[10];
for (int i = 0; i < mass.Length; i++)
{
    mass[i] = new Random().Next(100, 1000);
}
Print(mass);

int count = 0;
for (int i = 0; i < mass.Length; i++)
    {
      if (mass[i] % 2 == 0)
      {
        count += 1;
      }
    }
Console.WriteLine("Количество четных чисел в массиве: " + count);
