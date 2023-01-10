Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int Index = 1;
while (Index <= a)
{
    Console.WriteLine($"Квадраты чисел от 1 до {a} равняются {Index*Index}");
    Index+=1;
}