using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {   //задание 1
            int x = 5; //локальная переменная-ссылка
            ref int xRef = ref x;
            double a = 7;
            x = (int)a;
            a = (double)x;
            char d = 'A';
            bool g = true;
            decimal r = -1;
            string b = "hello";
            object t = "+++";
            int z = 5;
            double y = 15.3;
            y = z; //здесь происходит неявное приведение типа к double
            int price = 39; //упаковка
            Object obj = price;
            int price2 = (int)obj; //распаковка
            var name = "Ann Sh"; //неявно типизированная переменная
            int? w = null; //пример работы с Nullable
            bool? enabled = null;
            //задание 2
            string str1 = "Good night";
            string str2 = "Good morning";
            int k = str1.CompareTo(str2); //сравнивает текущий объект с другой строкой
            string s1 = "Hello dear friend";
            string s2 = "My lend";
            string s3 = "Family weekend";
            string[] words = s1.Split(new char[] { ' ' }); //разделение строк
            s1 = s1.Insert(5, s3); //вставка, 5- индекс, где нужно вставить строку
            int ind = s2.Length - 1;//индекс последнего символа
            s2 = s2.Remove(ind);//вырезаем последний символ
            string s4 = s1 + " " + s2; //сцепление
            string s5 = String.Concat(s4, "!!!");
            string type = "";//пустая
            string str5 = null;
            StringBuilder sb = new StringBuilder("Hello world");
            sb.Append("!"); //добавляем в конец
            //задание 3a
            int[,] arr = { { 4, 5, 6 }, { 5, 8, 9 }, { 2, 1, 3 } };
            int rows = arr.GetUpperBound(0) + 1;
            int columns = arr.Length / rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            //задание 3b
            string[] strArray = { "15", "19", "10" };
            foreach (var q in strArray)
                Console.Write(" " + q);
            Console.WriteLine(strArray.Length);
            strArray[1] = "01";
            //задание 3с
            int[][] myArr = new int[3][];
            myArr[0] = new int[2];
            myArr[1] = new int[3];
            myArr[2] = new int[4];
            for (int i = 0; i < myArr.Length; i++)
            {
                for (int j = 0; j < myArr[i].Length; j++)
                {
                    myArr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            //задание 3d
            var A = new[] { 5, 10, 23, 16, 8 };
            var D = new[] { "hello" };
            //задание 4
            (int, string, char, string, ulong) g123 = (10, "", '0', ";klj", 10);

            Console.WriteLine(g123.Item1);
            Console.WriteLine(g123.Item2);
            Console.WriteLine(g123.Item3);
            Console.WriteLine(g123.Item4);
            Console.WriteLine(g123.Item5);


            Console.WriteLine(g123.Item1);
            Console.WriteLine(g123.Item3);
            Console.WriteLine(g123.Item4);


            var (tuple1, tuple2, tuple3, tuple4, tuple5) = g123;

            (int, string, char, string, ulong) g1234 = (10, "", '0', ";klj", 10);

            Console.WriteLine(g123.Equals(g1234) ? "equals" : "not equals");
        }
            (int, int, int, char) func()
            {
            string s = "huefisuefiuagf";
                int[] ar = new int[4] { 3, 5, 6, 8 };
                int min = ar[0];
                int max = ar[1];
                int sum = 0;
                foreach (var el in ar)
                {
                    if (min > el)
                        min = el;

                    if (max < el)
                        max = el;

                    sum += el;

                }
                Console.WriteLine("MAX" + max + " MIN " + min + " SUM " + sum);
                return (min, max, sum, s[0]);

            }

        
       
    }
}
