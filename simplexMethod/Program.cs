using System;

namespace simplexMethod
{
    class program
    {
        static void Main(string[] args)
        {
            /*
            Что осталось сделать:
                ++ условия на ввод данных (>0)
                ++ защита от дурака (try catch)
                ++ условие задачи
                повтор выполнения программы
                ++ round в промежуточных и окончательных результатах
                ++ переделать вывод граничных условий
                переименовать некоторые переменные и массивы
                нужно ли чтобы в строке сумма необходимого количесотва ресурсов было меньше общего запаса ресурсов
                
                .
                0b.
                011b.
                01010b
                0100101b.
                101101001b
                P " '0
                     '0
                      '0
                
            */
            Console.WriteLine("Некоторое производство выпускает продукцию двух видов: П1 и П2. Изготавливается она из четырех видов сырья: S1;S2;S3;S4. Запас сырья и расход его на единицу продукции задается таблицей:\nТаблицу см. в документе\nДоход от производства и реализации единицы продукции вида П1 равен 3 денежным единицам, а от единицы продукции вида П2 - 6 денежным единицам.\nКак следует спланировать выпуск продукции, чтобы доход предприятия был наибольшим?");

            double[,] main = new double[0,0];
            double[] res = new double[0], dohod = new double[0];
            int n = 0, m = 0, otv = 0;
            Console.WriteLine("1.Мой пример из дока (№9)\n2.Задача 2 с минигрупп (которую делали с Тёмой)\n3.Задача 3 с минигрупп\n4.Настина задача из дока (№7)\n5.Пример с инета\n6.Рандом\n7.Ручной ввод");
            metka: Console.Write("Введите способ заполнения данных: ");
            while (true)
            {
                try
                {
                    otv = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.Write("Вам необходимо ввести число!\nПовторите ввод: ");
                }
            }  
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
                    while (true)
                    {
                        try
                        {
                            int a = 0;
                            while (true)
                            {
                                Console.Write("Введите количество видов изделий: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a > 0)
                                {
                                    n = a;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Количество изделий априори не может быть отрицательным числом..");
                                }
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine($"Количество видов изделий - численное значение, а вы ввели..\nВведите еще раз!");
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            int a = 0;
                            while (true)
                            {
                                Console.Write("Введите колчество ресурсов: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a > 0)
                                {
                                    m = a;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Количество ресурсов априори не может быть отрицательным числом..");
                                }
                            }
                            
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Количество видов ресурсов тоже число, прямо как количество видов изделий..\nВам необходимо повторить ввод");
                        }
                    }

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
                    while (true)
                    {
                        try
                        {
                            int a = 0;
                            while (true)
                            {
                                Console.Write("Введите количество видов изделий: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a > 0)
                                {
                                    n = a;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Количество изделий априори не может быть отрицательным числом..");
                                }
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine($"Количество видов изделий - численное значение, а вы ввели..\nВведите еще раз!");
                        }
                    }
                    while (true)
                    {
                        try
                        {
                            int a = 0;
                            while (true)
                            {
                                Console.Write("Введите колчество ресурсов: ");
                                a = Convert.ToInt32(Console.ReadLine());
                                if (a > 0)
                                {
                                    m = a;
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Количество ресурсов априори не может быть отрицательным числом..");
                                }
                            }
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Количество видов ресурсов тоже число, прямо как количество видов изделий..\nВам необходимо повторить ввод");
                        }
                    }

                    main = new double[m, n];
                    res = new double[m];
                    dohod = new double[n];
                    double h = 0;

                    for (int i = 0; i < main.GetLength(0); i++)
                    {
                        for (int j = 0; j < main.GetLength(1); j++)
                        {
                            while (true)
                            {
                                try
                                {
                                    while (true)
                                    {
                                        Console.Write($"Введите сколько необходимо ресурса №{j + 1} на изготовление {i + 1} продукта: ");
                                        h = Convert.ToDouble(Console.ReadLine());
                                        if (h >= 0)
                                        {
                                            main[i, j] = h;
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine($"То есть от производства {i + 1} продукта ресурс {j + 1} будет пополняться?\nБраво)\nПовторите ввод");
                                        }
                                    }
                                    break;
                                }
                                catch
                                {
                                    Console.WriteLine("Вам необходимо ввести число!\nНи букву, ни специальный символ, а число!\nПовторите ввод");
                                }
                            }
                        }
                    }

                    for (int i = 0; i < res.Length; i++)
                    {
                        while (true)
                        {
                            try
                            {
                                while (true)
                                {
                                    Console.Write($"Введите запас ресурса №{i + 1}: ");
                                    h = Convert.ToDouble(Console.ReadLine());
                                    if (h >= 0)
                                    {
                                        res[i] = h;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Одна из ситуаций, когда ресурс идет не от поставщика, а к поставщику\nПовторите ввод");
                                    }
                                }
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Необходимо ввести число!\nПовторите ввод");
                            }
                        }
                        
                    }

                    for (int i = 0; i < dohod.Length; i++)
                    {
                        while (true)
                        {
                            try
                            {
                                while (true)
                                {
                                    Console.Write($"Введите прибыль с реалзации продукта №{i + 1}: ");
                                    h = Convert.ToDouble(Console.ReadLine());
                                    if (h >= 0)
                                    {
                                        dohod[i] = h;
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Прибыль на то и прибыль, что она должна быть больше нуля\nПовторите ввод");
                                    }
                                }
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Необходимо ввести число!\nПовторите ввод");
                            }
                        }
                        
                    }

                    break;
                default:
                    Console.WriteLine("Такого варианта вам не предоставлялось..\nПовторите ввод");
                    goto metka;
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
            Console.Write($"\tx");
            for (int i = 0; i < main.GetLength(1); i++)
            {
                if(i != main.GetLength(1) - 1)
                {
                    Console.Write($"{i + 1},");
                }
                else
                {
                    Console.Write($"{i + 1}");
                }
            }
            Console.WriteLine($" >= 0\n");

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
            Console.Write($"\tx");
            for (int i = 0; i < main.GetLength(1); i++)
            {
                if(i == main.GetLength(1) - 1)
                {
                    Console.Write($"{i + 1}");
                }
                else
                {
                    Console.Write($"{i + 1},");
                }
            }
            Console.Write($" >= 0; x");
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
            Console.WriteLine($"F = {Math.Round(Math.Abs(b[b.GetLength(0) - 1, b.GetLength(1) - 1]), 3)}");
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
            Console.WriteLine($"F' = {Math.Round(a[a.GetLength(0) - 1, a.GetLength(1) - 1], 3)}");
            Console.WriteLine($"F = {Math.Round(Math.Abs(a[a.GetLength(0) - 1, a.GetLength(1) - 1]), 3)}");
        }
    }
}