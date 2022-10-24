//Написать программу копирования массива

int[] n = new int[10]; 
int[] m = new int[10]; 
for (int i = 0; i < 10; i++)
{
    n[i] = i + 100;
}
Console.WriteLine("Оригинальный массив...");
foreach (int j in n)
{
    int i = j - 100;
    Console.WriteLine("Элемент[{0}] = {1}", i, j);
}
Array.Copy(n, 0, m, 0, 10);
Console.WriteLine("Новый массив...");
foreach (int res in m)
{
    Console.WriteLine(res);
}