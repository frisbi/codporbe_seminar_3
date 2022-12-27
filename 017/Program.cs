// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// if (x > 0 && y > 0)
// {
//     Console.WriteLine($"Точка с координатами {x} и {y} находится в первой четверти");
// }
// else
// {
//     if (x < 0 && y > 0)
//     {
//         Console.WriteLine($"Точка с координатами {x} и {y} находится во второй четверти");
//     }
//     else
//     {
//         if (x < 0 && y < 0)
//         {
//            Console.WriteLine($"Точка с координатами {x} и {y} находится в третьей четверти"); 
//         }
//         else
//         {
//             Console.WriteLine($"Точка с координатами {x} и {y} находится в четвертой четверти");
//         }
//     }
// }



// ЧЕРЕЗ ПРОЦЕДУРУ

// void quarter(int numX, int numY)
// {
//     if (numX > 0 && numY > 0)
//     {
//        Console.WriteLine($"Точка с координатами {numX} и {numY} находится в 1 четверти");
//     }
//     else
//     {
//         if (numX < 0 && numY > 0)
//         {
//             Console.WriteLine($"Точка с координатами {numX} и {numY} находится во 2 четверти");
//         }
//         else
//         {
//             if (numX < 0 && numY < 0)
//             {
//                 Console.WriteLine($"Точка с координатами {numX} и {numY} находится в 3 четверти"); 
//             }
//             else
//             {
//                 Console.WriteLine($"Точка с координатами {numX} и {numY} находится в 4 четверти");
//             }
//         }
//     }
// }

// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());

// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// int x_r = new Random().Next(-150,150);
// int y_r = new Random().Next(-150,150);
// quarter(x,y);  // вызов процедуры
// quarter(15,-8);
// quarter(x_r , y_r);


// через функцию

int quarter(int numX, int numY)
{
    if (numX > 0 && numY > 0)
    {
       return 1;
    }
    else
    {
        if (numX < 0 && numY > 0)
        {
            return 2;
        }
        else
        {
            if (numX < 0 && numY < 0)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
    }
}

Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
int x_r = new Random().Next(-150,150);
int y_r = new Random().Next(-150,150);
Console.WriteLine($"Точка с координатами {x} и {y} находится в {quarter(x,y)} четверти");