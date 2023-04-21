using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path1 = "D:\\vector1.txt";
            string path2 = "D:\\vector2.txt";
            
            LinkedList<LinkedList<int>> matrix = OOP8.GetOuterProduct(OOP8.getVectors(path1, "1"), OOP8.getVectors(path2, "2"));
            OOP8.PrintMatrix(matrix);
        }
    }

    public class OOP8
    {
        public static int[] getVectors(string path, string num)
        {
            Console.WriteLine("\nВектор " + num + " :");
            StreamReader sr = new StreamReader(path);
            string[] v = sr.ReadLine().Split(' ');
            int[] vector = new int[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                vector[i] = Int32.Parse(v[i]);
                Console.Write(vector[i] + "\t");
            }
            return vector;
        }

        public static LinkedList<LinkedList<T>> GetOuterProduct<T>(T[] vector1, T[] vector2)
        {
            LinkedList<LinkedList<T>> matrix = new LinkedList<LinkedList<T>>();
            foreach (T v1 in vector1)
            {
                LinkedList<T> row = new LinkedList<T>();
                foreach (T v2 in vector2)
                {
                    row.AddLast(Multiply(v1, v2));
                }
                matrix.AddLast(row);
            }
            return matrix;
        }

        public static T Multiply<T>(T a, T b)
        {
            dynamic dynamicA = a;
            dynamic dynamicB = b;
            return dynamicA * dynamicB;
        }
        public static void PrintMatrix<T>(LinkedList<LinkedList<T>> matrix)
        {
            Console.WriteLine("\nСтворена матриця: ");
            foreach (LinkedList<T> row in matrix)
            {
                foreach (T el in row)
                {
                    Console.Write(el + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
