﻿// Напишите функцию, которая принимает одно число-высоту ёлочки 
// и рисует её в консоли звёздочкой
// 3=>                       5=>
//    *                             *
//   ***                           ***
//  *****                         *****
//                               *******
//                              *********

Console.Clear();

for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 10; j++)
    {
        Console.WriteLine(i*j);
    }
    Console.WriteLine();
}

