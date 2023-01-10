// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

// Console.Write("Введите номер четверти: ");
// int quarter = int.Parse(Console.ReadLine());

// switch (quarter)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0 y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("x<0 y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("x<0 y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("x>0 y<0");
//         break;
//     }

//     default:
//     {
//         Console.WriteLine("Введена неправильная четверть");
//         break;
//     }
// }

Console.Clear();
string quad(int x)
{


    if (x == 1)
    {
        //Console.WriteLine($"В четверти {x} могут находиться точки с координатами x > 0 и y > 0");
        string a = "В четверти 1 могут находиться точки с координатами x > 0 и y > 0";
        return a;
    }
    else
    {
        if (x == 2)
        {
            //Console.WriteLine($"В четверти {x} могут находиться точки с координатами x < 0 и y > 0");
            string a = "В четверти 2 могут находиться точки с координатами x < 0 и y > 0";
            return a;
        }
        else
        {
            if (x == 3)
            {
                //Console.WriteLine($"В четверти {x} могут находиться точки с координатами x < 0 и y < 0");
                string a = "В четверти 3 могут находиться точки с координатами x < 0 и y < 0";
                return a;
            }
            else
            {
                if (x == 4)
                {
                    //Console.WriteLine($"В четверти {x} могут находиться точки с координатами x > 0 и y < 0");
                    string a = "В четверти 4 могут находиться точки с координатами x > 0 и y < 0";
                    return a;
                }
                else
                {
                    //Console.WriteLine($"Четверти {x} не существует в системе координат. Введите корректную четверь.");
                    string a = "Четверти не существует в системе координат. Введите корректную четверь.";
                    return a;
                }
            }
        }
    }
}
Console.Write("Введите номер четверти в координатах от 1 до 4: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(quad(num));


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