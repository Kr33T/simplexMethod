using System;

namespace simplexMethod
{
    class program
    {
        static void Main(string[] args)
        {
            double[,] main = new double[0,0];
            double[] res = new double[0], dohod = new double[0];
            int n = 0, m = 0;
            Console.WriteLine("1.Мой пример из дока (№9)\n2.Задача 2 с минигрупп (которую делали с Тёмой)\n3.Задача 3 с минигрупп\n4.Настина задача из дока (№7)\n5.Пример с инета\n6.Рандом\n7.Ручной ввод");
            Console.WriteLine("Введите способ заполнения данных: ");
            int otv = Convert.ToInt32(Console.ReadLine());
            switch (otv)
            {
                case 1:
                    //Пример из дока (№9)
                    main = new double[,] { { 2, 1, 2, 1 }, { 4, 3, 1, 2 }, { 1, 2, 3, 1 } };
                    res = new double[] { 20, 10, 30 };
                    dohod = new double[] { 4, 2, 1, 3 };
                    break;
                case 2:
                    //Задача 2 (которую делали с Тёмой)
                    main = new double[,] { { 2, 3 }, { 2, 1 }, { 0, 3 }, { 3, 0 } };
                    res = new double[] { 19, 13, 15, 18 };
                    dohod = new double[] { 7, 5 };
                    break;
                case 3:
                    //Задача 3
                    main = new double[,] { { 1, 2, 2 }, { 1, 5, 9 }, { 2, 1, 2 } };
                    res = new double[] { 27, 45, 46 };
                    dohod = new double[] { 0, 1, 0 };
                    break;
                case 4:
                    //Настина (№7 из дока)
                    main = new double[,] { { 1, 2 }, { 2, 1 }, { 0, 4 }, { 3, 2 } };
                    res = new double[] { 4, 6, 8, 2 };
                    dohod = new double[] { 3, 6 };
                    break;
                case 5:
                    //Пример с инета
                    main = new double[,] { { -3, 5 }, { -2, 5 }, { 1, 0 }, { 3, -8 } };
                    res = new double[] { 25, 30, 10, 6 };
                    dohod = new double[] { 6, 5 };
                    break;
                case 6:
                    //рандом
                    Console.Write("Введите количество видов изделий: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите колчество ресурсов: ");
                    m = Convert.ToInt32(Console.ReadLine());

                    main = new double[m, n];
                    res = new double[m];
                    dohod = new double[n];

                    Random rnd = new Random();

                    for (int i = 0; i < main.GetLength(0); i++)
                    {
                        for (int j = 0; j < main.GetLength(1); j++)
                        {
                            main[i, j] = rnd.Next(0, 10);
                        }
                    }

                    for (int i = 0; i < res.Length; i++)
                    {
                        res[i] = rnd.Next(0, 10);
                    }

                    for (int i = 0; i < dohod.Length; i++)
                    {
                        dohod[i] = rnd.Next(1, 10);
                    }
                    break;
                case 7:
                    //вручную
                    Console.Write("Введите количество видов изделий: ");
                    n = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите колчество ресурсов: ");
                    m = Convert.ToInt32(Console.ReadLine());

                    main = new double[m, n];
                    res = new double[m];
                    dohod = new double[n];

                    for (int i = 0; i < main.GetLength(0); i++)
                    {
                        for (int j = 0; j < main.GetLength(1); j++)
                        {
                            Console.Write($"Введите сколько необходимо ресурса №{j + 1} на изготовление {i + 1} продукта: ");
                            main[i, j] = Convert.ToDouble(Console.ReadLine());
                        }
                    }

                    for (int i = 0; i < res.Length; i++)
                    {
                        Console.Write($"Введите запас ресурса №{i + 1}: ");
                        res[i] = Convert.ToDouble(Console.ReadLine());
                    }

                    for (int i = 0; i < dohod.Length; i++)
                    {
                        Console.Write($"Введите какая прибыль с реалзации продукта №{i + 1}: ");
                        dohod[i] = Convert.ToDouble(Console.ReadLine());
                    }
                    break;
            }
            
            int temp = main.GetLength(1) + 1, dop = temp;
            double[] ans = new double[0];
            //output math model
            Console.WriteLine("Математическая модель задачи:");
            Console.Write("\tF = ");
            for (int i = 0; i < dohod.Length; i++)
            {
                if(i != dohod.Length - 1)
                {
                    Console.Write($"{dohod[i]}x{i + 1} + ");
                }
                else
                {
                    Console.Write($"{dohod[i]}x{i + 1} -> max\n");
                }
            }
            for (int i = 0; i < main.GetLength(0); i++)
            {
                Console.Write("\t");
                for (int j = 0; j < main.GetLength(1); j++)
                {
                    if (j != main.GetLength(1) - 1)
                    {
                        Console.Write($"{main[i, j]}x{j + 1} + ");
                    }
                    else
                    {
                        Console.Write($"{main[i, j]}x{j + 1} <= {res[i]}");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine($"\tx1,2 >= 0\n");

            //output canonical mainimization task
            Console.WriteLine("Каноническая задача минимизации, составленная по условию задачи:");
            Console.Write("\tF' = -(");
            for (int i = 0; i < dohod.Length; i++)
            {
                if (i != dohod.Length - 1)
                {
                    Console.Write($"{dohod[i]}x{i + 1} + ");
                }
                else
                {
                    Console.Write($"{dohod[i]}x{i + 1}) -> min\n");
                }
            }
            for (int i = 0; i < main.GetLength(0); i++)
            {
                Console.Write("\t");
                for (int j = 0; j < main.GetLength(1); j++)
                {
                    if (j != main.GetLength(1) - 1)
                    {
                        Console.Write($"{main[i, j]}x{j + 1} + ");
                    }
                    else
                    {
                        Console.Write($"{main[i, j]}x{j + 1} + x{temp++} = {res[i]}");
                    }
                }
                Console.WriteLine();
            }
            Console.Write($"\tx1,2 >= 0; x");
            while (dop != temp)
            {
                if (dop + 1 != temp)
                {
                    Console.Write($"{dop},");
                }
                else
                {
                    Console.Write($"{dop}");
                }
                dop++;
            }
            Console.WriteLine(" - любое\n");

            //"сборка" первой симплекс таблицы
            double[,] Table = new double[main.GetLength(0) + 1, main.GetLength(1) + main.GetLength(0) + 1];
            temp = main.GetLength(1);
            for (int i = 0; i < main.GetLength(0); i++)
            {
                for (int j = 0; j < main.GetLength(1); j++)
                {
                    if(j != main.GetLength(1) - 1)
                    {
                        Table[i, j] = main[i, j];
                    }
                    else
                    {
                        Table[i, j] = main[i, j];
                        Table[i, temp++] = 1;
                    }
                }
            }
            for (int i = 0; i < res.Length; i++)
            {
                Table[i, Table.GetLength(1) - 1] = res[i];
            }
            for (int i = 0; i < dohod.Length; i++)
            {
                Table[Table.GetLength(0) - 1, i] = dohod[i];
            }

            //промежуточные
            simplex.intermediate(Table, ref ans, 0);

            //поиск индексов решающего элемента
            bool check = false;
            int col, row;
            int o = 0;
            while (true)
            {
                col = simplex.decisiveColumn(Table);
                row = simplex.decisiveRow(Table, col);

                Console.WriteLine($"Разрешающий столбец: {col + 1}");
                Console.WriteLine($"Разрешающая строка: {row + 1}");
                
                simplex.solve(ref Table, row, col);

                simplex.intermediate(Table, ref ans, o + 1);

                for (int j = 0; j < Table.GetLength(1); j++)
                {
                    if(Table[Table.GetLength(0) - 1, j] > 0 && Table[Table.GetLength(0) - 1, j] != 0)
                    {
                        check = false;
                        break;
                    }
                    else
                    {
                        check = true;
                    }
                }
                if (check)
                {
                    break;
                }
                o++;
            }
            simplex.finalResults(main.GetLength(1), ans, Table);
        }
    }

    class simplex
    {
        public static void finalResults(double r, double[] a, double[,] b)
        {
            Console.WriteLine("\nОкончательные результаты:");
            for (int i = 0; i < r; i++)
            {
                Console.WriteLine($"x{i + 1} = {a[i]}");
            }
            Console.WriteLine($"F = {Math.Abs(b[b.GetLength(0) - 1, b.GetLength(1) - 1])}");
        }

        public static void solve(ref double[,] a, int row, int col)
        {
            double var = a[row, col];
            for (int j = 0; j < a.GetLength(1); j++)
            {
                a[row, j] = (double)(a[row, j] / var);
            }
            double del;
            for (int i = 0; i < a.GetLength(0); i++)
            {
                del = a[i, col];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i != row)
                    {
                        var = a[row, j];
                        var *= -del;
                        a[i, j] += var;
                    }
                }
            }
        }

        public static int decisiveRow(double[,]a, int b)
        {
            double[,] a1 = new double[a.GetLength(0), a.GetLength(1)];
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                for (int j = 0; j < a1.GetLength(1); j++)
                {
                    a1[i, j] = Convert.ToDouble(a[i, j]);
                }
            }
            double min = double.MaxValue;
            int temp = 0;
            for (int i = 0; i < a1.GetLength(0) - 1; i++)
            {
                if(a1[i, a1.GetLength(1) - 1] != 0 && a1[i, b] > 0)
                {
                    if ((a1[i, a1.GetLength(1) - 1] / a1[i, b]) < min)
                    {
                        min = a1[i, a1.GetLength(1) - 1] / a1[i, b];
                        temp = i;
                    }
                }
            }
            return temp;
        }

        public static int decisiveColumn(double[,] a)
        {
            double max = double.MinValue;
            int temp = 0;
            for (int j = 0; j < a.GetLength(1); j++)
            {
                if(a[a.GetLength(0) - 1, j] >= 0)
                {
                    if (a[a.GetLength(0) - 1, j] > max)
                    {
                        max = a[a.GetLength(0) - 1, j];
                        temp = j;
                    }
                }
            }
            return temp;
        }

        public static void show(double[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]:f3} ");
                }
                Console.WriteLine();
            }
        }

        public static void show(double[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"{a[i]} ");
            }
        }

        public static void intermediate(double[,] a, ref double[] b, int o)
        {
            Array.Resize(ref b, 0);
            if (o == 0)
            {
                Console.WriteLine($"\n1-ая симплекс-таблица:");
            }
            else
            {
                Console.WriteLine($"\n{o + 1}-я Симплекс-таблица:");
            }
            
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]:f3} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nРезультаты таблицы:");
            int temp = 0, temp2 = 0;
            for (int j = 0; j < a.GetLength(1) - 1; j++)
            {
                temp = 0;
                temp2 = 0;
                for (int i = 0; i < a.GetLength(0) - 1; i++)
                {
                    if (a[i, j] == 0)
                        temp++;
                    if (a[i, j] == 1)
                        temp2++;
                }
                if (temp == a.GetLength(0) - 2 && temp2 == 1)
                {
                    for (int i = 0; i < a.GetLength(0) - 1; i++)
                    {
                        if (a[i, j] == 1)
                        {
                            temp = i;
                        }
                    }
                    Array.Resize(ref b, b.Length + 1);
                    b[b.Length - 1] = Math.Round(a[temp, a.GetLength(1) - 1]);
                }
                else
                {
                    Array.Resize(ref b, b.Length + 1);
                    b[b.Length - 1] = 0;
                }
            }
            for (int i = 0; i < b.Length; i++)
            {
                Console.WriteLine($"x{i + 1} = {b[i]}");
            }
            Console.WriteLine($"F' = {a[a.GetLength(0) - 1, a.GetLength(1) - 1]}");
            Console.WriteLine($"F = {Math.Abs(a[a.GetLength(0) - 1, a.GetLength(1) - 1])}");
        }
    }
}