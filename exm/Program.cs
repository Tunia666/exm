/*	Разработать программный модуль, в котором необходимо создать список из целых чисел при помощи класса List. Исключить из списка все элементы, равные х
*/
/*using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 3, 5, 3, 6 };
        int x = 3;

        Console.WriteLine("Исходный список:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        RemoveElements(numbers, x);

        Console.WriteLine("\nСписок после удаления элементов, равных " + x + ":");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }

    static void RemoveElements(List<int> numbers, int x)
    {
        numbers.RemoveAll(n => n == x);
    }
}
*/
/*Разработать программный модуль, в котором необходимо осуществить удаление из списка элемента методом стека. Осуществить чтение и запись списка в файл.*/
/*using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "D:\\Работа\\КС54\\ОП.04\\Kode\\exm\\numbers.txt";

        // Считываем список из файла
        List<int> numbers = ReadListFromFile(filePath);

        Console.WriteLine("Исходный список:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        
        // Удаляем элемент из списка методом стека
        if (numbers.Count > 0)
        {
            int removedElement = Pop(numbers);
            Console.WriteLine($"\nУдаленный элемент: {removedElement}");
        }
        else
        {
            Console.WriteLine("\nСписок пуст, удаление невозможно.");
        }

        // Записываем обновленный список обратно в файл
        WriteListToFile(numbers, filePath);

        Console.WriteLine("Список после удаления элемента методом стека:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }

    // Метод для удаления элемента из списка методом стека
    static int Pop(List<int> stack)
    {
        if (stack.Count == 0)
            throw new InvalidOperationException("Стек пуст.");

        int top = stack[stack.Count - 1];
        stack.RemoveAt(stack.Count - 1);
        return top;
    }

    // Метод для чтения списка из файла
    static List<int> ReadListFromFile(string filePath)
    {
        List<int> numbers = new List<int>();
        try
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                if (int.TryParse(line, out int number))
                {
                    numbers.Add(number);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при чтении файла: " + ex.Message);
        }
        return numbers;
    }

    // Метод для записи списка в файл
    static void WriteListToFile(List<int> numbers, string filePath)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (int number in numbers)
                {
                    writer.WriteLine(number);
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка при записи файла: " + ex.Message);
        }
    }
}
*/
/*Разработать программный модуль, в котором робот может перемещаться в четырех направлениях 
 * («С» — север, «З» — запад, «Ю» — юг, «В» — восток) и принимать три цифровые команды: 
 * 0 — продолжать движение, 1 — поворот налево, –1 — поворот направо. Дан символ C — 
 * исходное направление робота и целое число N — посланная ему команда. Вывести направление 
 * робота после выполнения полученной команды.*/
/*using System;
namespace program { 
    class Program { 
     static void Main(string[] args)
        {
            int N;
            char C;
            Console.WriteLine("Введите команду для робота: ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите исходное направление: ");
            C = Convert.ToChar(Console.ReadLine());
            
            switch (N) {
                case 0: {
                        switch (C) {
                            case 'С':
                        {
                            Console.WriteLine(" на север.");
                                    break;
                        };
                            case 'В':
                        {
                            Console.WriteLine(" на Восток");
                                    break;
                                }
                            case 'Ю': {
                            Console.WriteLine(" на Юг");
                                    break;
                                }
                            case 'З':
                                {
                                    Console.WriteLine(" на Запад");
                                    break;
                                }
                        }
                        break;
                    }
                case 1:
                    {
                        switch (C)
                        {
                            case 'С':
                                {
                                    Console.WriteLine(" на запад");
                                    break;
                                };
                            case 'В':
                                {
                                    Console.WriteLine(" на Север");
                                    break;
                                }
                            case 'Ю':
                                {
                                    Console.WriteLine(" на Восток");
                                    break;
                                }
                            case 'З':
                                {
                                    Console.WriteLine(" на Юг");
                                    break;
                                }
                        }
                        break;
                    }
                case -1:
                    {
                        switch (C)
                        {
                            case 'С':
                                {
                                    Console.WriteLine(" на воспок");
                                    break;
                                };
                            case 'В':
                                {
                                    Console.WriteLine(" на юг");
                                    break;
                                }
                            case 'Ю':
                                {
                                    Console.WriteLine(" на запад");
                                    break;
                                }
                            case 'З':
                                {
                                    Console.WriteLine(" на север");
                                    break;
                                }
                        }
                        break;
                    }
            }
        }
    }
}
*/
/*Разработать программный модуль, в котором необходимо 
 * сгенерировать матрицу согласно следующему принципу*/
/*using System;
using System.Diagnostics;

namespace program{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ранг матрицы");
            int N = Convert.ToInt32(Console.ReadLine());
            int[,] inst = new int[N, N];
            int[,] rez = Matrix(inst, N);
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    Console.Write(rez[i, j]+"\t");

                }
                Console.WriteLine();
            }
        }
        static int[,] Matrix(int[,] ints, int n) {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j) { ints[i, j] = (i + 1) * (j + 2); }
                    else ints[i, j] = 0;
                }
                
            }
            return ints;
        }
    }

}*/
/*
Разработать программный модуль, 
в котором необходимо создать массив целочисленного 
типа А(n) и выполнить поиск заданного элемента s 
методом двоичного поиска. На экран вывести найденный 
элемент, либо запись, что элемент не найден.*/
/*
using System;
namespace program {
    class Program
    {
        static void Main(string[] args)
        {
            int s, n;
            Console.Write("Введите кодичество элементов в массиве:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.Write("Введите массив:");
            for (int i = 0; i < A.Length; i++) { A[i] = Convert.ToInt32(Console.ReadLine()); }
            Console.Write("Введите число для поиска:");
            s = Convert.ToInt32(Console.ReadLine());
            int id_s = BinnaryMass(A, s, 0, n - 1);
            Console.WriteLine("Номер в массиве:" +id_s);
        }
        static int BinnaryMass(int[] a, int s, int start, int finish) {
            if (start > finish) return -1;
            int middle = (start + finish)/2;
            int mibleValue = a[middle];
            if (s > a[middle])
            {
                return BinnaryMass(a, s, start, middle - 1);
            }
            else if (s < a[middle])
            {
                return BinnaryMass(a, s, middle + 1, finish);
            }
            else return middle;
        }
    }
}
*/
/*Разработать программный модуль, 
 * в котором необходимо создать целочисленный массив А(m) и
 * выполнить сортировку элементов, находящихся на четных местах 
 * методом «пузырька». Отсортированную последовательность вывести на экран.*/
/*using System;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int s, n;
            Console.Write("Введите кодичество элементов в массиве:");
            n = Convert.ToInt32(Console.ReadLine());
            int[] A = new int[n];
            Console.Write("Введите массив:");
            for (int i = 0; i < A.Length; i++) { A[i] = Convert.ToInt32(Console.ReadLine()); }
            
            int [] t = BubbleMass(A);
            Console.Write("Вывод в массив:");
            foreach (int i in t) { Console.Write(i); }
            
        }
        static int [] BubbleMass(int[] a)
        {
            int n = a.Length;
            int temp;
            for (int i = 0; i < n; i += 2) {
                for (int j = 2; j < n; j += 2) {
                    if (a[i] > a[j]) {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;
        }
    }
}
*/
/*Разработать программный модуль, в котором необходимо создать 
 * матрицу вещественных элементов А(n,n) и выполнить сортировку 
 * отрицательных элементов методом выбора. Отсортированную 
 * последовательность вывести на экран. */
/*
using System;
namespace program { 
    public class Program
    {
        static void Main(string[] args) {
            Console.WriteLine("Введеите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[,]matrix = new double[n,n];
            Console.WriteLine("Введеите элементы матрицы: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i,j] = Convert.ToDouble(Console.ReadLine());
                }  
            }
            Console.WriteLine("Отсортированный массив: ");
            int minx, miny;
            double temp;
            for (int x = 0; x < n; x++) {
                for (int y = 0; y < n; y++)
                {
                    minx = x;
                    miny = y;
                    if (matrix[minx, miny] < 0) {
                        for (int z = 0; z < n; z++)
                        {
                            for (int r = 0; r < n; r++)
                            {
                                if (matrix[z, r] == matrix[minx, miny])
                                {
                                    continue;
                                }
                                if (matrix[z, r] < 0 && (matrix[minx, miny] > matrix[z, r]))
                                {
                                    temp = matrix[minx, miny];
                                    matrix[minx, miny] = matrix[z, r];
                                    matrix[z, r] = temp;
                                }
                            }
                        } 
                    }
                    
                }
               
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i,j]+"\t");
                }
                Console.WriteLine();
            }

        }
    }
}
*/
/*Разработать программный модуль, в котором необходимо 
 * создать целочисленную матрицу А(n,n) и выполнить сортировку 
 * элементов главной диагонали методом вставки. Отсортированную 
 * последовательность вывести на экран.*/
/*using System;
namespace program
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введеите n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[n, n];
            Console.WriteLine("Введеите элементы матрицы: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Отсортированный массив: ");
            int z, t,u;//
            int temp;
            for (int x = 1; x < n; x++)
            {
                for (int y = 1; y < n; y++)
                {
                   if (x == y)
                    {
                        z = matrix[x, y];
                        t = x; u = y;
                        while (t > 0 && u > 0 && matrix[x - 1, y - 1] > z)
                        {
                            temp = matrix[x - 1, y - 1];
                            matrix[x - 1, y - 1] = matrix[x, y];
                            matrix[x, y] = temp;
                        }
                        //matrix[x, y] = z;
                    }

                }

            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}

/*Разработать программный модуль, в котором с клавиатуры вводятся строки S, S1.
 * Удалить из строки S все подстроки, совпадающие с S1. 
 * Если совпадающих подстрок нет, то вывести строку S без изменений.*/
/*
using System;
namespace program
{
    public class Program
    {
        static void Main(string[] args)
        {
            string S, S1, S2;
            S = Console.ReadLine();
            S1 = Console.ReadLine();
            S2 = S.Replace(S1, "");
            Console.WriteLine(S2);
        }
    }
}
*/
/*Разработать консольное приложение, осуществляющее работу со строковыми данными. 
В программе должно быть меню вида:

Выберите пункт меню:
1 – Ввод данных
2 – Просмотр данных
3 – Обработка
4 – Выход

В программе при выборе пункта меню загружается соответствующий метод. 
В метод обработки необходимо передать в качестве параметров исходную строку. 
Метод просмотра в зависимости от передаваемых входных параметров реализует 
либо просмотр исходной строки, либо результат преобразования строки. 
Выход из программы осуществляется при выборе соответствующего пункта меню.
*/
/*using System;
namespace program
{
    public class ListString {
        public static List<string> list = new List<string>();
        public ListString(string s) { }
    } 
    public class Program
    {
        static void Main()
        {
            
            Console.WriteLine("Выберите пункт меню\n 1-Ввод данных\n 2 - Просмотр данных \n 3 - Обработка данных \n 4 - Выход");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
            case 1: Vvod();break;
            case 2: Prosmotr(); break;
            case 3: Obrabotka(); break;
            case 4: Vihod(); break;
            }
        }
        
        private static void Vihod()
        {
            Console.ReadKey();
            
        }

        private static void Obrabotka()
        {
            Console.WriteLine("Введите строку:");
            string s = Console.ReadLine();
            Console.WriteLine("Введите строку для замены:");
            string s1 = Console.ReadLine();
            foreach (string i in ListString.list)
            {
                s.Replace(i, s1);
            }
            Main();
        }

        private static void Prosmotr()
        {
            foreach (string i in ListString.list) { 
                Console.WriteLine(i);
            }
            Main();
        }

        static void Vvod() {
            
            string s = Console.ReadLine();
            ListString.list.Add(s);
            Main();
        }
    }
}
*/
/*Разработать программный модуль, в котором необходимо 
 * создать абстрактный класс Figure с функциями 
 * вычисления периметра, а также функцией, 
 * выводящей информацию о фигуре на экран. 
 * Создать производные классы: Rectangle (прямоугольник) 
 * и Triangle (треугольник). Создать массив n фигур и 
 * вывести полную информацию о фигурах на экран.
 * */
/*using System;

namespace Program{
     abstract class Figure {
        public abstract int Perimetr(int a, int b, int c);
        public abstract void Info();
    }
    class Triangle : Figure {
        
        override public int Perimetr(int a, int b, int c) {
            return (a+b+c);
        }
        override public void Info() {
            Console.WriteLine("Треугольник");
        }
    }
    class Rectangle : Figure
    {

        override public int Perimetr(int a, int b, int c)
        {
            return (a + b) * 2;
        }
        override public void Info()
        {
            Console.WriteLine("Прямоугольник");
        }
    }
    class Program {
        static void Main() {
            
            Figure [] f = new Figure[6];
            int a, b, c;
            f[0] = new Rectangle();
            f[1] = new Rectangle();
            f[2] = new Rectangle();
            f[3] = new Triangle();
            f[4] = new Triangle();
            f[5] = new Triangle();
            int [] perimetr = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Введите a,b,c:");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                c = Convert.ToInt32(Console.ReadLine());
                perimetr[i] = f[i].Perimetr(a,b,c);
            }
            for (int j = 0; j < 6; j++)
            {
                f[j].Info();
                Console.WriteLine(perimetr[j]);
                
            }

        }
    }
}
*/
/*Разработать программный модуль, в котором необходимо 
 * сгенерировать матрицу согласно следующему принципу*/
/*using System;

namespace Program
{
    class Program {
        static void Main() {
            Console.WriteLine("Введите n: ");
            int n = Convert.ToInt32 (Console.ReadLine());
            int[,] ints = new int[n, n];
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    if (i == j) ints[i, j] = (i + 1) * (j + 2);
                    else ints[i, j] = 0;
                    Console.Write(ints[i, j] + "\t");
                }
                Console.WriteLine();

            }

        }
    }
}*/