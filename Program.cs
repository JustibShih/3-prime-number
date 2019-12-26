using System;

namespace _000
{
    class Program
    {
        private static int num1, num2, num3;
        public static int Num1 { get => num1; set => num1 = value; }
        public static int Num2 { get => num2; set => num2 = value; }
        public static int Num3 { get => num3; set => num3 = value; }
        public static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i <= 26; i++)
            {
                Num1 = i;
                for (int j = 1; j <= 26; j++)
                {
                    Num2 = j;
                    for (int k = 1; k <= 26; k++)
                    {
                        Num3 = k;

                        if (testc(Num1, Num2) && testc(Num2, Num3) && testc(Num1, Num3))
                        {
                            Console.WriteLine(Num1 + "\t" + Num2 + "\t" + Num3);
                            sum++;
                        }
                    }
                }
            }
            Console.Read();
        }
        private static bool testc(int num1, int num2)
        {
            bool n = false;
            if (GCD(num1, num2) == 1)
            {
                n = true;
            }
            return n;
        }
        private static int GCD(int num1, int num2)
        {
            int min = Math.Min(num1, num2);
            int max = Math.Max(num1, num2);
            int maxModMin = max % min;
            return maxModMin > 0 ? GCD(min, maxModMin) : min;
        }
    }
}
