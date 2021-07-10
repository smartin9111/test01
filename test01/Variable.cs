using System;
using System.Collections.Generic;
using System.Text;

namespace test01
{
    class Variable
    {
        int x = 2;
        public int y = 3;
        private int z = 4;
        //protected int xy = 5;

        public Variable() { 
        
        }

        //public int getX() { 
        
        //}

        public void test01() {
            int xyz = 3;
            Console.WriteLine(x);
        }

        public void test02() {
            int y = 5;
            Console.WriteLine(y);
            Console.WriteLine(this.y);
        }
    }
}
