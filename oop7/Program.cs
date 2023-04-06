using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Menu menu = new Menu();
        }
    }

    public class Menu
    {
        private int sw;
        OOP7 oop = new OOP7();
        public Menu()
        {
            Console.WriteLine("1. Отримати проценти від числа.");
            Console.WriteLine("2. Додати проценти до числа.");
            Console.WriteLine("3. Відняти проценти від числа.");
            Console.WriteLine("4. Отримати проценти від раціонального дробу.");
            Console.WriteLine("5. Додати проценти до раціонального дробу.");
            Console.WriteLine("6. Відняти проценти до від раціонального дробу.");
            Console.Write("Оберіть варіант: ");
            sw = Convert.ToInt32(Console.ReadLine());
            switch(sw)
            {
                case 1:
                    Console.WriteLine("Результат = " + oop.getPercentTenth() + "\n");
                    new Menu();
                    break;
                case 2:
                    Console.WriteLine("Результат = " + oop.increasePercentsTenth() + "\n");
                    new Menu();
                    break;
                case 3:
                    Console.WriteLine("Результат = " + oop.decreasePercentsTenth() + "\n");
                    new Menu();
                    break;
                case 4:
                    Console.WriteLine("Результат = " + oop.getPercentRational() + "\n") ;
                    new Menu();
                    break;
                case 5:
                    Console.WriteLine("Результат = " + oop.increasePercentsRational() + "\n");
                    new Menu();
                    break;
                case 6:
                    Console.WriteLine("Результат = " + oop.decreasePercentsRational() + "\n");
                    new Menu();
                    break;
                default:
                    Console.Write("Помилка.");
                    new Menu();
                    break;
            }
        }
    }

    interface TenthFraction
    {
        double getPercentTenth();
        double increasePercentsTenth();
        double decreasePercentsTenth();
    }

    interface RationalFraction
    {
        double getPercentRational();
        double increasePercentsRational();
        double decreasePercentsRational();

    }

    public class OOP7: TenthFraction
    {
        private double n;
        private double perc;
        double result;
        double numerator;
        double denominator;
        public double getPercentTenth()
        {
            Console.Write("Введіть число: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть відсоток, який хочете отримати від числа: ");
            perc = Convert.ToDouble(Console.ReadLine());
            result = n * perc / (double)100;
            return result;
        }

        public double increasePercentsTenth()
        {
            Console.Write("Введіть число: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть відсоток, на який хочете збільшити число: ");
            perc = Convert.ToDouble(Console.ReadLine());
            result = n + n * perc / (double)100;
            return result;
        }

        public double decreasePercentsTenth()
        {
            Console.Write("Введіть число: ");
            n = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть відсоток, на який хочете зменшити число: ");
            perc = Convert.ToDouble(Console.ReadLine());
            result = n - n * perc / (double)100;
            return result;
        }

        public double getPercentRational()
        {
            Console.Write("Введіть чисельник: ");
            numerator = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть знаменник: ");
            denominator = Convert.ToDouble(Console.ReadLine());
            if (denominator == 0)
                getPercentRational();
            Console.Write("Введіть відсоток, який хочете отримати від числа: ");
            perc = Convert.ToDouble(Console.ReadLine());
            result = numerator * perc / (double)100 / denominator;
            return result;
        }

        public double increasePercentsRational()
        {
            Console.Write("Введіть чисельник: ");
            numerator = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть знаменник: ");
            denominator = Convert.ToDouble(Console.ReadLine());
            if (denominator == 0)
                getPercentRational();
            Console.Write("Введіть відсоток, на який хочете збільшити число: ");
            perc = Convert.ToDouble(Console.ReadLine());
            result = numerator / denominator + numerator * perc / (double)100 / denominator;
            return result;
        }

        public double decreasePercentsRational()
        {
            Console.Write("Введіть чисельник: ");
            numerator = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введіть знаменник: ");
            denominator = Convert.ToDouble(Console.ReadLine());
            if (denominator == 0)
                getPercentRational();
            Console.Write("Введіть відсоток, на який хочете зменшити число: ");
            perc = Convert.ToDouble(Console.ReadLine());
            result = numerator / denominator - numerator * perc / (double)100 / denominator;
            return result;
        }

    }
}
