using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Last
{
    public class Vibor
    {

        static Cake tortiki = new Cake();
    

        public static Cake FORMA(int perem) //для формы
        {
            switch (perem)
            {
                case 3:
                   
                    tortiki.Form = "Круг - 500; ";
                    return tortiki;

                case 4:
                    
                    tortiki.Form = "Квадрат - 600; ";
                    return tortiki;
                case 5:
                    
                    tortiki.Form = "Прямоугольник - 700; ";
                    return tortiki;
            }
               return tortiki;
           
        }
        public static Cake Size(int perem) //для размера
        {
            switch(perem)
            {
                case 3:
                    tortiki.Size = "Маленький  - 500; ";
                    return tortiki;
                case 4:
                    tortiki.Size = "Средний - 600; ";
                    return tortiki;
                case 5:
                    tortiki.Size = "Большой - 700; ";
                    return tortiki;

            }
            return tortiki;
        }
        public static Cake Vkus(int perem) //для вкуса коржей
        {
            switch (perem)
            {
                case 3:
                    tortiki.Taste = "Без вкуса - 0; ";
                    return tortiki;
                case 4:
                    tortiki.Taste = "Шоколадный - 500; ";
                    return tortiki;
                case 5:
                    tortiki.Taste = "Карамельный - 700; ";
                    return tortiki;

            }
            return tortiki;
        }
        public static Cake VOlume(int perem) //кол-во коржей
        {
            switch (perem)
            {
                case 3:
                    tortiki.Volume = "Два коржа - 100; ";
                    return tortiki;
                case 4:
                    tortiki.Volume = "Три коржа - 200; ";
                    return tortiki;
                case 5:
                    tortiki.Volume = "Четыре коржа - 500; ";
                    return tortiki;

            }
            return tortiki;
        }
        public static Cake Glazur(int perem) //глазурь
        {
            switch (perem)
            {
                case 3:
                    tortiki.Glazur = "Шоколадная - 500; ";
                    return tortiki;
                case 4:
                    tortiki.Glazur = "Карамельная - 700; ";
                    return tortiki;
                case 5:
                    tortiki.Glazur = "Специальный рецепт - 1000; ";
                    return tortiki;

            }
            return tortiki;
        }
        public static Cake Decor(int perem) //декор
        {
            switch (perem)
            {
                case 3:
                    tortiki.Dekor = "Без декора - 0; ";
                    return tortiki;
                case 4:
                    tortiki.Dekor = "Написать ваше имя - 100; ";
                    return tortiki;
                case 5:
                    tortiki.Dekor = "Сложный декор - 500; ";
                    return tortiki;

            }
            return tortiki;
            
        }
        public static Cake Obnyl() //обнуление моей переменной
        {
            tortiki.Form = null;
            tortiki.Size = null;
            tortiki.Taste = null;
            tortiki.Volume = null;
            tortiki.Glazur = null;
            tortiki.Dekor = null;
           
            return tortiki;
        }
    }
}
