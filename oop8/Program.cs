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

        public static LinkedList<LinkedList<int>> GetOuterProduct(int[] vector1, int[] vector2)
        {
            LinkedList<LinkedList<int>> matrix = new LinkedList<LinkedList<int>>();
            foreach (int v1 in vector1)
            {
                LinkedList<int> row = new LinkedList<int>();
                foreach (int v2 in vector2)
                {
                    row.AddLast(Multiply(v1, v2));
                }
                matrix.AddLast(row);
            }
            return matrix;
        }

        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static void PrintMatrix(LinkedList<LinkedList<int>> matrix)
        {
            Console.WriteLine("\nСтворена матриця: ");
            foreach (LinkedList<int> row in matrix)
            {
                foreach (int el in row)
                {
                    Console.Write(el + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
