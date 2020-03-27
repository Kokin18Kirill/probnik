using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Змейка
{
    class Class
    {
        static string Hero = "x";
        static int x = 1, y = 1;
        static int a, b;
        static string dog = "@";
        static int dlina = 1;
        static int i;

        public static string[,] Pole(string[,] pole)
        {

            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 24; j++)
                {
                    Console.Write(pole[i, j]);
                }
                Console.WriteLine();
            }

            return pole;
        }

        public static int Qwer(ConsoleKeyInfo keyInfo, string[,] Pole)
        {
            int n = 1;
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {

                if (x + 1 <= 22 && Pole[y, x + 1] == " ")
                {
                    x++;
                    for (i = 0; i < dlina; i++)
                    {
                        Pole[y, x - i] = Hero;

                        Console.SetCursorPosition(x, y);
                        Console.Write("x");
                    }
                    Console.SetCursorPosition(x - 1 - i, y);
                    Console.Write(" ");
                    Console.SetCursorPosition(0, 0);

                    return n;
                }
                else
                {
                    if (x + 1 <= 22 && Pole[y, x + 1] == dog)
                    {
                        x++;
                        for (i = 0; i < dlina; i++)
                        {
                            Pole[y, x - i] = Hero;

                            Console.SetCursorPosition(x, y);
                            Console.Write("x");
                        }
                        Console.SetCursorPosition(x - 1 - i, y);
                        Console.Write(" ");
                        Console.SetCursorPosition(0, 0);
                        dlina++;
                        n = 0;

                        return n;
                    }
                }
            }
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                if (y - 1 >= 0 && Pole[y - 1, x] == " ")
                {
                    y--;
                    for (i = 0; i < dlina; i++)
                    {
                        Pole[y + i, x] = Hero;

                        Console.SetCursorPosition(x, y);
                        Console.Write("x");
                    }
                    Console.SetCursorPosition(x, y + 1 + i);
                    Console.Write(" ");
                    Console.SetCursorPosition(0, 0);

                    return n;
                }
                else
                {
                    if (y - 1 >= 0 && Pole[y - 1, x] == dog)
                    {

                        y--;
                        for (i = 0; i < dlina; i++)
                        {
                            Pole[y + i, x] = Hero;

                            Console.SetCursorPosition(x, y);
                            Console.Write("x");
                        }
                        Console.SetCursorPosition(x, y + 1 + i);
                        Console.Write(" ");
                        Console.SetCursorPosition(0, 0);
                        dlina++;
                        n = 0;

                        return n;
                    }
                }
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                if (x - 1 >= 0 && Pole[y, x - 1] == " ")
                {
                    x--;
                    for (i = 0; i < dlina; i++)
                    {
                        Pole[y, x] = Hero;

                        Console.SetCursorPosition(x, y);
                        Console.Write("x");
                    }
                    Console.SetCursorPosition(x + 1 + i, y);
                    Console.Write(" ");
                    Console.SetCursorPosition(0, 0);

                    return n;

                }
                else
                {
                    if (x - 1 >= 0 && Pole[y, x - 1] == dog)
                    {
                        x--;
                        for (i = 0; i < dlina; i++)
                        {
                            Pole[y, x] = Hero;

                            Console.SetCursorPosition(x, y);
                            Console.Write("x");
                        }
                        Console.SetCursorPosition(x + 1 + i, y);
                        Console.Write(" ");
                        Console.SetCursorPosition(0, 0);
                        dlina++;
                        n = 0;

                        return n;
                    }
                }
            }
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {

                if (y + 1 <= 22 && Pole[y + 1, x] == " ")
                {
                    y++;
                    for (i = 0; i < dlina; i++)
                    {
                        Pole[y - i, x] = Hero;
                        Console.SetCursorPosition(x, y - i);
                        Console.Write("x");
                    }
                    Console.SetCursorPosition(x, y - i - 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(0, 0);
                    return n;
                }
                else
                {
                    if (y + 1 <= 22 && Pole[y + 1, x] == dog)
                    {
                        y++;

                        for (i = 0; i < dlina; i++)
                        {
                            Pole[y - i, x] = Hero;
                            Console.SetCursorPosition(x, y - i);
                            Console.Write("x");
                        }
                        Console.SetCursorPosition(x, y - i - 1);
                        Console.Write(" ");
                        Console.SetCursorPosition(0, 0);
                        dlina++;
                        n = 0;
                        return n;
                    }
                }


            }
            return n;
        }

        public static int Going (ConsoleKeyInfo keyInfo, string[,] Pole)
        {
            int n = 1;
            int k = 0;
            y = 1; x = 1;
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                k = 4;
                while (k == 4)
                {
                    y++;
                    Thread.Sleep(500);
                    Pole[y - 1, x] = Hero;
                    Console.SetCursorPosition(x, y);
                    Console.Write("x");
                    Console.SetCursorPosition(x, y - 1);
                    Console.Write(" ");
                    Console.SetCursorPosition(0, 0);
                    k = 3;

                }
               
            }
           


            return n;
        }






    }
}