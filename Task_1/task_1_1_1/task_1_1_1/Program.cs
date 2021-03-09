
using System;

namespace task_1_1_1
{
    class MainClass
    {

        //for task_1_1_1
        public static int SquareAB(int a, int b)
        {
            if (a == 0 || b == 0 || b < 0 || a < 0)
            {
                return 0;

            }
            else
            {
                return a * b;
            }
        }


        //for task_1_1_4
        static void getTree()
        {
            Console.Write("Введите N:");
            string text = Console.ReadLine();
            int N = Convert.ToInt32(text);

            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    for (int k = 0; k <= (N - j - 1); k++)
                    {
                        Console.Write(" ");
                    }
                    for (int f = 0; f < (j * 2 + 1); f++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
        }

        //for task_1_1_5
        public static int Num(int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum = sum + i;

                }
            }

            return sum;
        }

        //for task_1_1_6
        public static int Temp()
        {
            string myStr = Console.ReadLine();
            switch (myStr)
            {
                case "1":
                    Console.WriteLine(" Параметры надписи: bold ");
                    return 1;
                case "2":
                    Console.WriteLine(" Параметры надписи: italic ");
                    return 2;
                case "3":
                    Console.WriteLine(" Параметры надписи: underline ");
                    return 3;
                default:
                    Console.WriteLine("Некорректное значение! ");
                    return 0;
            }

        }

        //for task_1_1_7
        public static void BubbleSort(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas.Length - 1; j++)
                {
                    if (mas[j] > mas[j + 1])
                    {
                        int z = mas[j];
                        mas[j] = mas[j + 1];
                        mas[j + 1] = z;
                    }
                }
            }
        }

        //for task_1_1_9
        public static int Sum(int[] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {

                if (mas[i] > 0 || mas[i] == 0)
                {
                    sum = sum + mas[i];
                }
            }

            return sum;
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Task_1_1_1: ");
            Console.WriteLine("Enter value a: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            int square = SquareAB(a,b);
            if (square == 0) {
                Console.WriteLine($"Incorrect value ");
            }
            else { 
                Console.WriteLine($"Square is {square} ");
            }



            
            Console.WriteLine("Task_1_1_2: ");
            Console.Write("Введите N1: ");
            int N2 = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < N2 + 1; i++)
            {
                for (int j = 0; j < N2 + 1; j++)
                {
                    if (i < j)
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("*");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("Task_1_1_3: ");
            Console.Write("Введите N3: ");
            int N3 = Convert.ToInt32(Console.ReadLine());

            int z = 1;

            for (int i = 0; i < N3 + 2; i++)
            {
                for (int j = 0; j < N3 + 2; j++)
                {
                    Console.Write(" ");
                    if (j == N3)
                    {
                        for (int s = 0; s < z; s++)
                            Console.Write("*");
                    }
                }

                N3 = N3 - 1;
                z = z + 2;
                Console.WriteLine();
            }

            Console.WriteLine("Task_1_1_4: ");
            getTree();




            Console.WriteLine("Task_1_1_5: ");
            int sum = Num(1000);
            Console.WriteLine(sum);
            


            Console.WriteLine("Task_1_1_6: ");
            Console.WriteLine("Параметры надписи: None ");
            Console.WriteLine("Введите: \n   1: bold \n   2: italic \n   3: underline ");
            int newStr = 0;
            do
            {
                newStr = Temp();
            }
            while (newStr == 1 || newStr == 2 || newStr == 3);





            Console.WriteLine("Task_1_1_7: ");
            int[] array = new int[10];
            Random rand = new Random();
            Console.WriteLine("Original: ");
            for (int i = 0; i < 10; i++)
            {
                array[i] = rand.Next(0, 20);
                Console.Write(array[i] + "  ");
            }
            Console.WriteLine();
            Console.WriteLine("Sorted: ");
            BubbleSort(array);
            for (int i = 0; i < 10; i++)
            {

                Console.Write(array[i] + "  ");
            }





            Console.WriteLine("Task_1_1_8: ");
            int[,,] array1 = { { { 1, -1, 3 }, { 4, -2, 6 } } };
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        if (array1[i, j, k] > 0)
                        {
                            array1[i, j, k] = 0;
                        }
                    }
                }

            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.WriteLine(array1[i, j, k]);
                    }
                }
            }



            Console.WriteLine("Task_1_1_9: ");
            int[] num = new int[6] { 1, 2, 0, -1, 3, 5 };
            int sumArr = Sum(num);
            Console.Write(sumArr);
            Console.ReadKey();
        }
    }
}
