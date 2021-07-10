using System;

namespace test01
{
    class Program
    {
        static int x = 2;
        static void Main(string[] args)
        {
            display("mouse");
            setXtoZero();
            int a = getResult();
            int a2 = getResult(5);

            Console.WriteLine(a);
            double b = getSum(4.2, 5.3);
            Console.WriteLine(b);
            

            Variable v1 = new Variable();
            v1.test01();
            v1.test02();

            Console.ReadKey();
        }
        static void display(string word)
        {
            Console.WriteLine("##-" + word + "-##");
        }

        static void setXtoZero() {
            x = 0;
        }

        static int getResult() {
            return x + 1;
        }

        static int getResult(int y) {
            return x + 4 + y;
        }

        static double getSum(double x, double y) {
            double z = x + y;
            return z;
        }

        //fuggveny tulterheles, overloading

        

    }
}
