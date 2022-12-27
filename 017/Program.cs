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

int quarter(int numX, int numY)
{
    if (numX > 0 && numY > 0)
    {
       Console.WriteLine($"Точка с координатами {x} и {y} находится в первой четверти");
    }
    else
    {
        if (numX < 0 && numY > 0)
        {
            Console.WriteLine($"Точка с координатами {x} и {y} находится во второй четверти");
        }
        else
        {
            if (numX < 0 && numY < 0)
            {
                Console.WriteLine($"Точка с координатами {x} и {y} находится в третьей четверти"); 
            }
            else
            {
                Console.WriteLine($"Точка с координатами {x} и {y} находится в четвертой четверти");
            }
        }
    }
}

Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
