using System;

namespace task_1_2_4
{
    class MainClass
    {
        //task_1_2_4
            static void splitString(string enter)
            {
                char[] text = enter.ToCharArray();
                bool toUp = true;
                for (int i = 0; i < text.Length; i++)
                {
                    if (char.IsLetter(text[i]))
                    {
                        if (toUp == true)
                        {
                            text[i] = char.ToUpper(text[i]);
                            toUp = false;
                        }
                    }
                    if (text[i] == '!' || text[i] == '?' || text[i] == '.')
                    {
                        toUp = true;
                    }
                }

                foreach (char i in text)
                {
                    Console.Write(i);
                }
            }
        

        static void Main(string[] args)
        {
                string myStr = "я плохо учил русский язык. забываю начинать предложения с заглавной. хорошо, что можно написать программу!";
                Console.WriteLine(myStr);
                splitString(myStr);
        }
    }
}
