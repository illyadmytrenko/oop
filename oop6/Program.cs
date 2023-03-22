using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
        }
    }

    class Menu
    {
        private int sw;
        public Menu()
        {
            Console.WriteLine("1. 1 завдання");
            Console.WriteLine("2. 2 завдання");
            Console.WriteLine("3. 3 завдання");
            Console.WriteLine("4. 4 завдання");
            Console.WriteLine("5. 5 завдання");
            Console.WriteLine("6. 6 завдання");
            Console.Write("Оберiть завдання:");
            sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    FirstTask ft = new FirstTask();
                    break;
                case 2:
                    SecondTask st = new SecondTask();
                    break;
                case 3:
                    ThirdTask tt = new ThirdTask();
                    break;
                case 4:
                    FourthTask fourt = new FourthTask();
                    break;
                case 5:
                    FifthTask fivet = new FifthTask();
                    break;
                case 6:
                    SixthTask sixt = new SixthTask();
                    break;
                default:
                    break;
            }
        }
    }

    class StaticMethods
    {
        private static int[] array_1;
        private static int n;
        private static int[,] matrix_1;
        public static int[] randomly(int x ,int a = -10, int b = 11)
        {
            n = x;
            array_1 = new int[n];
            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                array_1[i] = random.Next(a, b);
            }
            return array_1;
        }

        public static int[] byYourself(int x = 0)
        {
            Console.Write("Введiть розмiр масиву:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < x)
                n = 10;
            array_1 = new int[n];
            Console.WriteLine("Введiть елементи масиву:");
            for (int i = 0; i < n; i++)
            {
                Console.Write((i + 1) + " елемент масиву = ");
                array_1[i] = Convert.ToInt32(Console.ReadLine());
            }
            return array_1;
        }

        public static void getArray(int[] arr)
        {
            Console.WriteLine("Елементи масиву:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i + 1 + " елемент масиву = " + arr[i]);
            }
        }

        public static int[,] randomlyMatrix(int x1 = 5, int x2 = 5, int a = -10, int b = 11)
        {
            matrix_1 = new int[x1, x2];
            Random random = new Random();
            for (int i = 0; i < matrix_1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_1.GetLength(1); j++)
                {
                    matrix_1[i, j] = random.Next(a, b);
                }
            }
            return matrix_1;
        }

        public static int[,] byYourselfMatrix(int num = 0)
        {
            if(num == 6)
            {
                Console.Write("Введiть розмiр квадратної матрицi:");
                n = Convert.ToInt32(Console.ReadLine());
                if (n < 0)
                    n = 5;
                matrix_1 = new int[n, n];
            }
            else if(num == 0)
                matrix_1 = new int[8, 8];
            Console.WriteLine("Введiть елементи матрицi:");
            for (int i = 0; i < matrix_1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix_1.GetLength(1); j++)
                {
                    Console.Write((j + 1) + " елемент " + (i + 1) + " рядка = ");
                    matrix_1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix_1;
        }

        public static void getMatrix(int[,] matrix)
        {
            Console.WriteLine("Елементи матрицi:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    class FirstTask
    {
        private int[] array;
        private int sw;
        public FirstTask()
        {
            Console.WriteLine("1. Рандомне заповення(розмiр масиву - 20 елементiв).");
            Console.WriteLine("2. Мануальне заповнення.");
            Console.Write("Оберiть варiант заповнення:");
            sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    array = StaticMethods.randomly(20);
                    StaticMethods.getArray(array);
                    checkIfArProgression();
                    new Menu();
                    break;
                case 2:
                    array = StaticMethods.byYourself(3);
                    StaticMethods.getArray(array);
                    checkIfArProgression();
                    new Menu();
                    break;
                default:
                    new Menu();
                    break;
            } 
        }

        private void checkIfArProgression()
        {
            int count = 0;
            for (int i = 0; i < array.Length - 2; i++)
            {
                if (array[i + 1] - array[i] == array[i + 2] - array[i + 1])
                {
                    count++;
                }
            }
            Console.WriteLine("\nКiлькiсть арифметичних прогресiй в масивi: " + count + "\n");
        }
    }

    class SecondTask
    {
        private int[] x;
        private int[] y;
        private int n;
        private int sw;

        public SecondTask()
        {
            Console.WriteLine("1. Рандомне заповення(розмiр векторiв - 5 елементiв).");
            Console.WriteLine("2. Мануальне заповнення.");
            Console.Write("Оберiть варiант заповнення:");
            sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    randomly();
                    getVectors();
                    checkIfPerpendicular();
                    new Menu();
                    break;
                case 2:
                    byYourself();
                    getVectors();
                    checkIfPerpendicular();
                    new Menu();
                    break;
                default:
                    new Menu();
                    break;
            }
        }

        private void randomly()
        {
            n = 5;
            x = new int[n];
            y = new int[n];
            Random random = new Random();
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = random.Next(-5, 6);
                y[i] = random.Next(-5, 6);
            }
        }
        private void byYourself()
        {
            Console.Write("Введiть розмiр векторiв:");
            n = Convert.ToInt32(Console.ReadLine());
            if (n < 0)
                n = 5;
            x = new int[n];
            y = new int[n];
            Console.WriteLine("Введiть координати вектора:");
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write((i + 1) + " координата вектора x = ");
                x[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write((i + 1) + " координата вектора y = ");
                y[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        private void checkIfPerpendicular()
        {
            double scalarProduct = 0;
            for (int i = 0; i < x.Length; i++)
            {
                scalarProduct += x[i] * y[i];
            }

            bool isPerpendicular = (scalarProduct == 0);
            Console.WriteLine("\nЧи є вектори перпендикулярними: " + isPerpendicular + "\n");
        }

        private void getVectors()
        {
            Console.WriteLine("Координати векторiв:");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine(i + 1 + " координата вектора x = " + x[i]);
                Console.WriteLine(i + 1 + " координата вектора y = " + y[i]);
            }
        }
    }

    class ThirdTask
    {
        private int[] array;
        private int sw;
        
        public ThirdTask()
        {
            Console.WriteLine("1. Рандомне заповення(розмiр масиву - 20 елементiв).");
            Console.WriteLine("2. Мануальне заповнення.");
            Console.Write("Оберiть варiант заповнення:");
            sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    array = StaticMethods.randomly(20);
                    StaticMethods.getArray(array);
                    getSortedArray();
                    new Menu();
                    break;
                case 2:
                    array = StaticMethods.byYourself();
                    StaticMethods.getArray(array);
                    new Menu();
                    break;
                default:
                    new Menu();
                    break;
            }
        }

        private void getSortedArray()
        {
            int[] oddArray = new int[array.Length / 2 + 1];
            int[] evenArray = new int[array.Length / 2];

            int oddCount = 0;
            int evenCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenArray[evenCount] = array[i];
                    evenCount++;
                }
                else
                {
                    oddArray[oddCount] = array[i];
                    oddCount++;
                }
            }

            int[] sortedArray = new int[array.Length];
            Array.Copy(oddArray, sortedArray, oddCount);
            Array.Copy(evenArray, 0, sortedArray, oddCount, evenCount);

            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(i + 1 + " елемент перетвореного масиву = " + sortedArray[i]);
            }
            Console.WriteLine();
        }
    }

    class FourthTask
    {
        private int n;
        private int[,] matrix;
        private int sw;
        public FourthTask()
        {
            Console.WriteLine("1. Рандомне заповення(розмiр матрицi - 5 елементiв).");
            Console.WriteLine("2. Мануальне заповнення:");
            Console.Write("Оберiть варiант заповнення:");
            sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    matrix = StaticMethods.randomlyMatrix();
                    StaticMethods.getMatrix(matrix);
                    getSortedEvenMatrix();
                    new Menu();
                    break;
                case 2:
                    matrix = StaticMethods.byYourselfMatrix(6);
                    StaticMethods.getMatrix(matrix);
                    getSortedEvenMatrix();
                    new Menu();
                    break;
                default:
                    new Menu();
                    break;
            }
        }

        public void getSortedEvenMatrix()
        {
            for (int i = 0; i < matrix.GetLength(0); i += 2)
            {
                int[] column = new int[matrix.GetLength(1)];
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    column[j] = matrix[j, i];
                }

                Array.Sort(column);
                Array.Reverse(column);

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[j, i] = column[j];
                }
            }

            Console.WriteLine("\nЕлементи вiдсортованої по парним стовбцям матрицi:");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
    class FifthTask
    {
        private int[,] matrix = new int[8, 8];
        private int sw;
         
        public FifthTask()
        {
            Console.WriteLine("1. Рандомне заповення.");
            Console.WriteLine("2. Мануальне заповнення:");
            Console.Write("Оберiть варiант заповнення:");
            sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    matrix = StaticMethods.randomlyMatrix(8, 8);
                    StaticMethods.getMatrix(matrix);
                    checkRowsAndColumns();
                    new Menu();
                    break;
                case 2:
                    matrix = StaticMethods.byYourselfMatrix();
                    StaticMethods.getMatrix(matrix);
                    checkRowsAndColumns();
                    new Menu();
                    break;
                default:
                    new Menu();
                    break;
            }
        }

        private void checkRowsAndColumns()
        {
            bool isEqual = true;
            bool isAtLeastOne = false;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] != matrix[j, i])
                    {
                        isEqual = false;
                        break;
                    }
                }
                if (isEqual)
                {
                    Console.WriteLine("\n" + (i + 1) + " Рядок спiвпадає з " + (i + 1) + " стовбцем\n");
                    isAtLeastOne = true;
                }
            }
            if (!isAtLeastOne)
            {
                Console.WriteLine("\nЖоден рядок не спiвпадає з жодним стовбцем\n");
            }
        }
    }

    class SixthTask
    {
        private int[,] matrix = new int[8, 8];
        private int sw;

        public SixthTask()
        {
            Console.WriteLine("1. Рандомне заповення.");
            Console.WriteLine("2. Мануальне заповнення:");
            Console.Write("Оберiть варiант заповнення:");
            sw = Convert.ToInt32(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    matrix = StaticMethods.randomlyMatrix(8, 8);
                    StaticMethods.getMatrix(matrix);
                    getSumInNegativeRow();
                    new Menu();
                    break;
                case 2:
                    matrix = StaticMethods.byYourselfMatrix();
                    StaticMethods.getMatrix(matrix);
                    getSumInNegativeRow();
                    new Menu();
                    break;
                default:
                    new Menu();
                    break;
            }
        }

        private void getSumInNegativeRow()
        {
            Console.WriteLine();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int sum = 0;
                bool hasNegative = false;

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }

                if (hasNegative)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        sum += matrix[i, j];
                    }
                    Console.WriteLine("Сума елементiв в " + (i + 1) + " рядку = " + sum);
                }
               
            }
            Console.WriteLine();
        }
    }
}
