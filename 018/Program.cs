void quad(int quad_x)
{


if (quad_x = 1)
{
    Console.WriteLine($"В четверти {quad} могут находиться точки с координатами x > 0 и y > 0");
}
else
{
    if (quad_x = 2)
    {
        Console.WriteLine($"В четверти {quad} могут находиться точки с координатами x < 0 и y > 0");
    }
    else
    {
        if (quad_x = 3)
        {
           Console.WriteLine($"В четверти {quad} могут находиться точки с координатами x < 0 и y < 0"); 
        }
        else
        {
            if (quad_x = 4)
            {
                Console.WriteLine($"В четверти {quad} могут находиться точки с координатами x > 0 и y < 0");
            }
            else
            {
                Console.WriteLine($"Четверти {quad} не существует в системе координат. Введите корректную четверь.");
            }
        }
    }
}
}
Console.Write("Введите номер четверти в координатах от 1 до 4: ");
int x = Convert.ToInt32(Console.ReadLine());
quad(quad_x);


// ОБЫЧНЫЙ МЕТОД

// Console.Write("Введите номер четверти в координатах от 1 до 4: ");
// int quad = Convert.ToInt32(Console.ReadLine());

// if (quad = 1)
// {
//     Console.WriteLine($"В четверти {quad} могут находиться точки с координатами x > 0 и y > 0");
// }
// else
// {
//     if (quad = 2)
//     {
//         Console.WriteLine($"В четверти {quad} могут находиться точки с координатами x < 0 и y > 0");
//     }
//     else
//     {
//         if (quad =3)
//         {
//            Console.WriteLine($"В четверти {quad} могут находиться точки с координатами x < 0 и y < 0"); 
//         }
//         else
//         {
//             if (quad = 4)
//             {
//                 Console.WriteLine($"В четверти {quad} могут находиться точки с координатами x > 0 и y < 0");
//             }
//             else
//             {
//                 Console.WriteLine($"Четверти {quad} не существует в системе координат. Введите корректную четверь.");
//             }
//         }
//     }
// }