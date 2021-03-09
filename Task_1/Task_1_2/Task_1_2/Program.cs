using System;
using System.Linq;

namespace Task_1_2
{
    class MainClass
    {
        //task_1_2_1
        public static double Middle(string str)
        {
            double sumWords = 0;
            double sum = 0;
            //я не успела разобраться с методами и поэтому вбила символы в ручную((
            string[] text = str.Split(' ', ',', '.', ':', ';', '-', '"', '!', '?');
            foreach (string s in text)
            {
                sumWords = sumWords + 1;
                sum = sum + s.Length;
                if (s.Length < 1)
                {
                    sumWords = sumWords - 1;
                }
            }
            return sum / sumWords;
        }



        //task_1_2_3
        public static int SumChar(string str)
        {
            int sum = 0;

            string[] text = str.Split(' ');
            foreach (string s in text)
            {
                // Console.WriteLine(s);
                if (Char.IsLower(s[0]))
                {
                    sum = sum + 1;
                }
            }
            return sum;
        }



        static void Main(string[] args)
        {
            Console.WriteLine("Task_1_2_1");

            string str1_1 = "Викентий хорошо отметил день рождения: покушал пиццу, посмотрел кино, пообщался со студентами в чате";
            double middle = Middle(str1_1);
            Console.WriteLine("Сумма без округления: " + middle);




            Console.WriteLine("Task_1_2_2");

            string FinalString = "";
            string FirstString = "написать программу, которая";
            string SecondString = "описание";
            foreach (char ch in FirstString)
                if (!SecondString.Contains(ch))
                {
                    FinalString += ch;
                }
                else
                {
                    FinalString += ch;
                    FinalString += ch;
                }
            Console.WriteLine("Ввод1: {0}", FirstString);
            Console.WriteLine("Ввод2: {0}", SecondString);
            Console.WriteLine("Вывод: {0}", FinalString);




            Console.WriteLine("Task_1_2_3");

            string str1_2 = "Антон выпил кофе и послушал Стинга";
            int sumChar = SumChar(str1_2);
            Console.WriteLine(str1_2);
            Console.WriteLine("Сумма: " + sumChar);

         
            Console.ReadKey();
        }
    }
}

