using System;
namespace HelloWorldApplocation
{
    class HelloWorld
    {
        double width;
        double length;

        public double GetArea()
        {
            return width * length;
        }

        public void SetValue()
        {
            width = 5.0;
            length = 10.0;
        }

        public void ShowValue()
        {
            double a = 567.232;
            int b = (int)a;
            string str = "sdasdasdasdasdasdasdasd";
            string[] strArr = str.Split();
            Console.WriteLine("chat:{0}", strArr);
            Console.WriteLine("a:{0}", a);
            Console.WriteLine("b:{0}", b);
            Console.WriteLine("Width:{0}", width);
            Console.WriteLine("Length:{0}", length);
            Console.WriteLine("Area:{0}", GetArea());
        }
    }

    class ValuePrint
    {
        static void Main(string[] args)
        {

            PropertyClass2 pro = new PropertyClass2();
            pro.size = 10;//public
            pro.width = 10;//internal允许子类访问

            HelloWorld ho = new HelloWorld();
            ho.SetValue();
            ho.GetArea();
            ho.ShowValue();

            ConstTest test = new ConstTest();
            test.sampleClass(10, 12);
            Console.WriteLine("x = {0},y = {1}, a = {2},b = {3}", test.x, test.y, ConstTest.a, ConstTest.b);
            Console.WriteLine("class = {0}, size = {1}", typeof(ConstTest), sizeof(int));

            JiechengFucntion func = new JiechengFucntion();
            int a = func.JcFunction(5);
            Console.WriteLine("jiecheng : {0}", a);

            Console.ReadLine();
            Console.ReadKey();
        }
    }

    class ConstTest
    {
        public int x;
        public int y;
        public const int a = 10;
        public const int b = a + 5;

        public void sampleClass(int p1, int p2)
        {
            x = (a > 20) ? 30 : 10;
            if (p2 > 30)
            {
                y = 40;
            }
            else
            {
                y = 10;
            }

            switch (p1)
            {
                case 1:
                    Console.WriteLine("11");
                    break;
                case 2:
                    Console.WriteLine("22");
                    break;
                default:
                    break;
            }
        }
    }

    class JiechengFucntion
    {
        //阶乘的递归算法
        public int JcFunction(int num)
        {
            return num > 0 ? num * JcFunction(num - 1) : 1;
        }
    }


    class PropertyClass
    {
        internal int width; //允许一个类将其成员变和成员函数暴露给当前程序中的其余函数和对象
        protected int height; //允许子类访问那他的基类的成员变量和成员函数，结合继承
        public int size; //公开的，可以公共访问的
        private int frame; //个类将其成员变量和成员函数对其他的函数和对象进行隐藏,即使是类的实例也无法访问它的私有成员
    }

    class PropertyClass2 : PropertyClass
    {
        //方法的创建
        //<Access Specifier> <return type> <Method Name>(Parameter List) { }
        //Access Specifier:访问修饰符，public、private、internal、protected

        public void FunctionA(int[] args)
        {
            num3 = num2 ?? 5.444;

        }

        int? i = 3;
        double ? num1 = 3.75;
        double ? num2 = null;
        double num3;

       



    }


    

}

