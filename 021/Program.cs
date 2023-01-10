//Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 2D пространстве


// Console.Write("Введите координату X точки А: ");
// int Ax = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y точки А: ");
// int Ay = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату X точки B: ");
// int Bx = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y точки B: ");
// int By = Convert.ToInt32(Console.ReadLine());

// double AB = Convert.ToDouble(Math.Sqrt(Math.Pow(Ax - Bx,2) + Math.Pow(Ay - By,2)));
// Console.WriteLine($"Расстояние между точками А и В равно {AB:f3}");


Console.Clear();
Console.Write("Введите координату X точки А: ");
int Ax = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y точки А: ");
int Ay = int.Parse(Console.ReadLine());

Console.Write("Введите координату X точки B: ");
int Bx = int.Parse(Console.ReadLine());

Console.Write("Введите координату Y точки B: ");
int By = int.Parse(Console.ReadLine());

double AB = Math.Sqrt(Math.Pow(Ax - Bx,2) + Math.Pow(Ay - By,2));
Console.WriteLine($"Расстояние между точками А и В равно {AB:f3}");