using System.Globalization;

namespace Last
{
    public class Program
    {
        static List<Cake> menu = new List<Cake>(); //лист для конфигурации торта
        static int price;
        static void Main() 
            
            
            
        {
            Vibor tortiki = new Vibor();


            DateTime aDateTime = DateTime.Now;
            string DATA = Convert.ToString(aDateTime);

            Console.Clear();
            Console.WriteLine("Заказ тортов в Глазурька, торты на ваш выбор!");
            Console.WriteLine("Выберите параметр торта");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("  Форма торта");
            Console.WriteLine("  Размер торта");
            Console.WriteLine("  Вкус коржей");
            Console.WriteLine("  Количество коржей");
            Console.WriteLine("  Глазурь");
            Console.WriteLine("  Декор");
            Console.WriteLine("  Конец заказа");
            Console.WriteLine("");



            Console.WriteLine("Ваш торт:");
            foreach (Cake pos in menu)
            {
                Console.Write(pos.Form );
                Console.Write(pos.Size );
                Console.Write(pos.Taste );
                Console.Write(pos.Volume );
                Console.Write(pos.Glazur );
                Console.Write(pos.Dekor );
            }
            Console.WriteLine("");
            Console.WriteLine("Общая стоимость:" +price);



            int position = 3;
            Console.SetCursorPosition(0, position);
            Console.WriteLine("->");
            ConsoleKeyInfo key = Console.ReadKey();
            while (key.Key != ConsoleKey.Enter)
            {
                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;

                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;


                }
                if (position > 9)
                {
                    position = 9;
                    Console.SetCursorPosition(0, position);
                }
                if (position < 4)
                {
                    position = 3;
                    Console.SetCursorPosition(0, position);
                }
                Console.Clear();
                Console.WriteLine("Заказ тортов в Глазурька, торты на ваш выбор!");
                Console.WriteLine("Выберите параметр торта");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("  Форма торта");
                Console.WriteLine("  Размер торта");
                Console.WriteLine("  Вкус коржей");
                Console.WriteLine("  Количество коржей");
                Console.WriteLine("  Глазурь");
                Console.WriteLine("  Декор");
                Console.WriteLine("  Конец заказа");
                Console.WriteLine("");

                Console.WriteLine("Ваш торт:");
                foreach (Cake pos in menu)
                {
                    Console.Write(pos.Form );
                    Console.Write(pos.Size );
                    Console.Write(pos.Taste );
                    Console.Write(pos.Volume );
                    Console.Write(pos.Glazur );
                    Console.Write(pos.Dekor );
                }
                Console.WriteLine("");
                Console.WriteLine("Общая стоимость:" + price);


                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                key = Console.ReadKey();


            }
           
            Console.Clear();
            Console.WriteLine("Для выхода нажмите Escape");
            Console.WriteLine("Выберите пункт из меню");
            Console.WriteLine("--------------------------------------");

            //Массивы для дополнительной менюшки
            string[] Slovo1 = new string[] { "  Круг - 500", "  Квадрат - 600", "  Прямоугльник - 700", };
            string[] Slovo2 = new string[] { "  Маленький - 500", "  Средний - 600", "  Большой - 700" };
            string[] Slovo3 = new string[] { "  Без вкуса - 0", "  Шоколадный - 500", "  Карамельный - 700" };
            string[] Slovo4 = new string[] { "  Два коржа - 100", "  Три коржа - 200", "  Четыре коржа - 500" };
            string[] Slovo5 = new string[] { "  Шоколадная - 500", "  Карамельная - 700", "  Специальный рецепт - 1000" };
            string[] Slovo6 = new string[] { "  Без декора - 0", "  Написать ваше имя - 100", "  Сложный декор - 500" };

            switch (position) //Дополнительная менюшка
            {
                case 3:

                    foreach (string item in Slovo1)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case 4:

                    foreach (string item in Slovo2)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case 5:

                    foreach (string item in Slovo3)
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case 6:

                    foreach (string item in Slovo4)
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case 7:

                    foreach (string item in Slovo5)
                    {
                        Console.WriteLine(item);
                    }

                    break;
                case 8:

                    foreach (string item in Slovo6)
                    {
                        Console.WriteLine(item);
                    }

                    break;

                case 9:

                    Console.Clear();
                    Console.WriteLine("Спасибо за заказ! Если хотите сделать еще один, нажмите на клавишу TAB");
                    ConsoleKeyInfo keyvixod = Console.ReadKey();
                    if (keyvixod.Key == ConsoleKey.Tab)
                    {

                        foreach (Cake zapis in menu)
                        {
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", "Дата: " + DATA + "\n");
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", "Ваш заказ:" +"\n");
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Form);
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Size);
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Taste);
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Volume);
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Glazur);
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Dekor + "\n");
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", "Общая стоимость:" + price + "\n");
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt","\n");

                        }
                        Program.menu.Clear();
                        Vibor.Obnyl();
                        price = 0;
                        Main();
                    }
                    else
                    {
                        foreach (Cake zapis in menu)
                        {
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", "Дата: " + DATA + "\n");
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", "Ваш заказ:" + "\n");
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Form);
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Size);
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Taste);
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Volume);
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Glazur);
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", zapis.Dekor + "\n");
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", "Общая стоимость:" + price + "\n");
                            File.AppendAllText("C:\\Users\\User\\Desktop\\Заказ.txt", "\n");

                        }
                        Environment.Exit(0);
                    }

                    break;
            }

            int position2 = 3;
            Console.SetCursorPosition(0, position2);
            Console.WriteLine("->");
            ConsoleKeyInfo key2 = Console.ReadKey();
            if (key2.Key == ConsoleKey.Escape)
            {
                Main();

            }
            else
            {
                while (key2.Key != ConsoleKey.Enter)
                {
                    if (key2.Key == ConsoleKey.UpArrow)
                    {
                        position2--;
                    }
                    if (key2.Key == ConsoleKey.DownArrow)
                    {
                        position2++;

                    }
                    if (position2 > 5)
                    {
                        position2 = 5;
                        Console.SetCursorPosition(0, position2);
                    }
                    if (position2 < 3)
                    {
                        position2 = 3;
                        Console.SetCursorPosition(0, position2);
                    }

                    Console.Clear();
                    Console.WriteLine("Для выхода нажмите Escape");
                    Console.WriteLine("Выберите пункт из меню");
                    Console.WriteLine("--------------------------------------");

                    switch (position) //Дополнительная менюшка
                    {
                        case 3:

                            foreach (string item in Slovo1)
                            {
                                Console.WriteLine(item);

                            }

                            break;
                        case 4:

                            foreach (string item in Slovo2)
                            {
                                Console.WriteLine(item);
                            }

                            break;
                        case 5:

                            foreach (string item in Slovo3)
                            {
                                Console.WriteLine(item);
                            }

                            break;

                        case 6:

                            foreach (string item in Slovo4)
                            {
                                Console.WriteLine(item);
                            }

                            break;

                        case 7:

                            foreach (string item in Slovo5)
                            {
                                Console.WriteLine(item);
                            }

                            break;
                        case 8:

                            foreach (string item in Slovo6)
                            {
                                Console.WriteLine(item);
                            }

                            break;

                

                         
                    }
                    Console.SetCursorPosition(0, position2);
                    Console.WriteLine("->");
                    key2 = Console.ReadKey();
                    if (key2.Key == ConsoleKey.Escape)
                    {
                        Main();
                    }

                }
                Program.menu.Clear();//очищает лист c конфигурациеq торта
                                     //общая дополнительная менюшка
                switch (position) //тут короче смотрит на вкладку основного меню, а потом сделать условия на вкладки дополнительного
                {
                    case 3://Форма

                        if (position2 == 3)
                        {
                            Program.menu.Add(Vibor.FORMA(position2));
                            price = price + 500;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(Vibor.FORMA(position2));
                            price = price + 600;
                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(Vibor.FORMA(position2));
                            price = price + 700;
                        }
                        break;

                    case 4://Размер

                        if (position2 == 3)
                        {
                            
                            Program.menu.Add(Vibor.Size(position2));
                            price = price + 500;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(Vibor.Size(position2));
                            price = price + 600;
                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(Vibor.Size(position2));
                            price = price + 700;
                        }
                        break;

                    case 5://Вкус коржей

                        if (position2 == 3)
                        {
                            Program.menu.Add(Vibor.Vkus(position2));
                            price = price + 0;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(Vibor.Vkus(position2));
                            price = price + 500;
                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(Vibor.Vkus(position2));
                            price = price + 700;
                        }
                        break;

                    case 6://Количество коржей

                        if (position2 == 3)
                        {
                            Program.menu.Add(Vibor.VOlume(position2));
                            price = price + 100;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(Vibor.VOlume(position2));
                            price = price + 200;
                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(Vibor.VOlume(position2));
                            price = price + 500;
                        }
                        break;

                    case 7://Глазурь

                        if (position2 == 3)
                        {
                            Program.menu.Add(Vibor.Glazur(position2));
                            price = price + 500;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(Vibor.Glazur(position2));
                            price = price + 700;
                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(Vibor.Glazur(position2));
                            price = price + 1000;
                        }
                        break;

                    case 8://Декор

                        if (position2 == 3)
                        {
                            Program.menu.Add(Vibor.Decor(position2));
                            price = price + 0;
                        }
                        if (position2 == 4)
                        {
                            Program.menu.Add(Vibor.Decor(position2));
                            price = price + 100;

                        }
                        if (position2 == 5)
                        {
                            Program.menu.Add(Vibor.Decor(position2));
                            price = price + 500;
                        }
                        break;




                       
                }
                Main();
            }
        }
    }
}