string[] strings =
{
    "Option 1",
    "Option 2",
    "Option 3",
    "Option 4",
    "About"
};
string[] strings1 =
{
    "1 => Option 1",
    "1 => Option 2",
    "1 => Option 3",
    "1 => Option 4"
};
string[] strings2 =
{
    "2 => Option 1",
    "2 => Option 2",
    "2 => Option 3",
    "2 => Option 4"
};
string[] strings3 =
{
    "3 => Option 1",
    "3 => Option 2",
    "3 => Option 3",
    "3 => Option 4"
};
string[] strings4 =
{
    "4 => Option 1",
    "4 => Option 2",
    "4 => Option 3",
    "4 => Option 4"
};
int secim = 0;
string about = new string($"Bu program da Array ile menu qurulub siz seciminizi \"Enter\" ve yaxud \"Right Arrow(sag isare)\" duymesi ile ede bilersiniz. Eger size geri qayitmaq isteyirsinizse \"Left Arrow\" ve yaxud \"Backsapce\" ile evvelki menu-ya qayida blersiniz.                                By: Muhammad Fatullayev ");
do
{
    Console.Clear();
    for (int i = 0; i <= 4; i++)
    {
        bool isCheck = false;
        if (secim == i)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(strings[i]);
            Console.ForegroundColor = ConsoleColor.White;
            isCheck = true;
        }
        if (!isCheck)
        {
            Console.WriteLine(strings[i]);
        }

    }
    ConsoleKeyInfo info = Console.ReadKey(true);

    if (info.Key == ConsoleKey.UpArrow)
    {
        if (secim == 0)
        {
            secim = 4;
        }
        else
        {
            secim--;
        }
    }
    else if (info.Key == ConsoleKey.DownArrow)
    {
        if (secim == 4)
        {
            secim = 0;
        }
        else
        {
            secim++;
        }
    }
    else if (info.Key == ConsoleKey.RightArrow)
    {
        if (secim == 0)
        {
            do
            {
                Console.Clear();
                for (int i = 0; i <= 3; i++)
                {
                    bool isCheck1 = false;
                    if (secim == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(strings1[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        isCheck1 = true;
                    }
                    if (!isCheck1)
                    {
                        Console.WriteLine(strings1[i]);
                    }

                }
                ConsoleKeyInfo info1 = Console.ReadKey(true);

                if (info1.Key == ConsoleKey.UpArrow)
                {
                    if (secim == 0)
                    {
                        secim = 3;
                    }
                    else
                    {
                        secim--;
                    }
                }
                else if (info1.Key == ConsoleKey.DownArrow)
                {
                    if (secim == 3)
                    {
                        secim = 0;
                    }
                    else
                    {
                        secim++;
                    }
                }
                else if (info1.Key == ConsoleKey.LeftArrow)
                {
                    break;
                }
                else if (info1.Key == ConsoleKey.Backspace)
                {
                    break;
                }
            } while (true);
        }
        else if (secim == 1)
        {
            do
            {
                Console.Clear();
                for (int i = 0; i <= 3; i++)
                {
                    bool isCheck1 = false;
                    if (secim == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(strings2[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        isCheck1 = true;
                    }
                    if (!isCheck1)
                    {
                        Console.WriteLine(strings2[i]);
                    }

                }
                ConsoleKeyInfo info1 = Console.ReadKey(true);

                if (info1.Key == ConsoleKey.UpArrow)
                {
                    if (secim == 0)
                    {
                        secim = 3;
                    }
                    else
                    {
                        secim--;
                    }
                }
                else if (info1.Key == ConsoleKey.DownArrow)
                {
                    if (secim == 3)
                    {
                        secim = 0;
                    }
                    else
                    {
                        secim++;
                    }
                }
                else if (info1.Key == ConsoleKey.LeftArrow)
                {
                    break;
                }
                else if (info1.Key == ConsoleKey.Backspace)
                {
                    break;
                }
            } while (true);
        }
        else if (secim == 2)
        {
            do
            {
                Console.Clear();
                for (int i = 0; i <= 3; i++)
                {
                    bool isCheck1 = false;
                    if (secim == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(strings3[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        isCheck1 = true;
                    }
                    if (!isCheck1)
                    {
                        Console.WriteLine(strings3[i]);
                    }

                }
                ConsoleKeyInfo info1 = Console.ReadKey(true);

                if (info1.Key == ConsoleKey.UpArrow)
                {
                    if (secim == 0)
                    {
                        secim = 3;
                    }
                    else
                    {
                        secim--;
                    }
                }
                else if (info1.Key == ConsoleKey.DownArrow)
                {
                    if (secim == 3)
                    {
                        secim = 0;
                    }
                    else
                    {
                        secim++;
                    }
                }
                else if (info1.Key == ConsoleKey.LeftArrow)
                {
                    break;
                }
                else if (info1.Key == ConsoleKey.Backspace)
                {
                    break;
                }
            } while (true);
        }
        else if (secim == 3)
        {
            do
            {
                Console.Clear();
                for (int i = 0; i <= 3; i++)
                {
                    bool isCheck1 = false;
                    if (secim == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(strings4[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        isCheck1 = true;
                    }
                    if (!isCheck1)
                    {
                        Console.WriteLine(strings4[i]);
                    }

                }
                ConsoleKeyInfo info1 = Console.ReadKey(true);

                if (info1.Key == ConsoleKey.UpArrow)
                {
                    if (secim == 0)
                    {
                        secim = 3;
                    }
                    else
                    {
                        secim--;
                    }
                }
                else if (info1.Key == ConsoleKey.DownArrow)
                {
                    if (secim == 3)
                    {
                        secim = 0;
                    }
                    else
                    {
                        secim++;
                    }
                }
                else if (info1.Key == ConsoleKey.LeftArrow)
                {
                    break;
                }
                else if (info1.Key == ConsoleKey.Backspace)
                {
                    break;
                }
            } while (true);
        }
        else if(secim == 4)
        {
            Console.Clear();
            Console.WriteLine(about);
            Thread.Sleep(10000);
        }
    }
    else if(info.Key == ConsoleKey.Enter)
    {
        if (secim == 0)
        {
            do
            {
                Console.Clear();
                for (int i = 0; i <= 3; i++)
                {
                    bool isCheck1 = false;
                    if (secim == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(strings1[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        isCheck1 = true;
                    }
                    if (!isCheck1)
                    {
                        Console.WriteLine(strings1[i]);
                    }

                }
                ConsoleKeyInfo info1 = Console.ReadKey(true);

                if (info1.Key == ConsoleKey.UpArrow)
                {
                    if (secim == 0)
                    {
                        secim = 3;
                    }
                    else
                    {
                        secim--;
                    }
                }
                else if (info1.Key == ConsoleKey.DownArrow)
                {
                    if (secim == 3)
                    {
                        secim = 0;
                    }
                    else
                    {
                        secim++;
                    }
                }
                else if (info1.Key == ConsoleKey.LeftArrow)
                {
                    break;
                }
                else if (info1.Key == ConsoleKey.Backspace)
                {
                    break;
                }
            } while (true);
        }
        else if (secim == 1)
        {
            do
            {
                Console.Clear();
                for (int i = 0; i <= 3; i++)
                {
                    bool isCheck1 = false;
                    if (secim == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(strings2[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        isCheck1 = true;
                    }
                    if (!isCheck1)
                    {
                        Console.WriteLine(strings2[i]);
                    }

                }
                ConsoleKeyInfo info1 = Console.ReadKey(true);

                if (info1.Key == ConsoleKey.UpArrow)
                {
                    if (secim == 0)
                    {
                        secim = 3;
                    }
                    else
                    {
                        secim--;
                    }
                }
                else if (info1.Key == ConsoleKey.DownArrow)
                {
                    if (secim == 3)
                    {
                        secim = 0;
                    }
                    else
                    {
                        secim++;
                    }
                }
                else if (info1.Key == ConsoleKey.LeftArrow)
                {
                    break;
                }
                else if (info1.Key == ConsoleKey.Backspace)
                {
                    break;
                }
            } while (true);
        }
        else if (secim == 2)
        {
            do
            {
                Console.Clear();
                for (int i = 0; i <= 3; i++)
                {
                    bool isCheck1 = false;
                    if (secim == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(strings3[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        isCheck1 = true;
                    }
                    if (!isCheck1)
                    {
                        Console.WriteLine(strings3[i]);
                    }

                }
                ConsoleKeyInfo info1 = Console.ReadKey(true);

                if (info1.Key == ConsoleKey.UpArrow)
                {
                    if (secim == 0)
                    {
                        secim = 3;
                    }
                    else
                    {
                        secim--;
                    }
                }
                else if (info1.Key == ConsoleKey.DownArrow)
                {
                    if (secim == 3)
                    {
                        secim = 0;
                    }
                    else
                    {
                        secim++;
                    }
                }
                else if (info1.Key == ConsoleKey.LeftArrow)
                {
                    break;
                }
                else if (info1.Key == ConsoleKey.Backspace)
                {
                    break;
                }
            } while (true);
        }
        else if (secim == 3)
        {
            do
            {
                Console.Clear();
                for (int i = 0; i <= 3; i++)
                {
                    bool isCheck1 = false;
                    if (secim == i)
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine(strings4[i]);
                        Console.ForegroundColor = ConsoleColor.White;
                        isCheck1 = true;
                    }
                    if (!isCheck1)
                    {
                        Console.WriteLine(strings4[i]);
                    }

                }
                ConsoleKeyInfo info1 = Console.ReadKey(true);

                if (info1.Key == ConsoleKey.UpArrow)
                {
                    if (secim == 0)
                    {
                        secim = 3;
                    }
                    else
                    {
                        secim--;
                    }
                }
                else if (info1.Key == ConsoleKey.DownArrow)
                {
                    if (secim == 3)
                    {
                        secim = 0;
                    }
                    else
                    {
                        secim++;
                    }
                }
                else if (info1.Key == ConsoleKey.LeftArrow)
                {
                    break;
                }
                else if (info1.Key == ConsoleKey.Backspace)
                {
                    break;
                }
            } while (true);
        }
        else if (secim == 4)
        {
            Console.Clear();
            Console.WriteLine(about);
            Thread.Sleep(10000);
        }
    }

} while (true);

