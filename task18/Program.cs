// Задача 18: Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y)
// обратная задаче 17
Console.WriteLine("Введите номер четверти координат осьей ХУ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 1)
{
    Console.WriteLine("X > 0 и Y > 0");
}
else if (number == 2)
{
    Console.WriteLine("X < 0 и Y > 0");
}
else if (number == 3)
{       
     Console.WriteLine("X < 0 и Y < 0");
}
else if (number == 4)
{   Console.WriteLine("X > 0 и Y < 0");
}

else
{
    Console.WriteLine("Введен неправильный номер");
}