using System;

namespace hwapp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(@"adfasdf as");
            var a = new BaseType();
            a.printinfo();
            TestClass.fn_test();

            TestClassA b = new TestClassA();
            TestClassA c = new TestClassA();
            TestClassA d = new TestClassA();
            d[1] = 1;
            d[2] = 2;
            d[3] = 3;
        }
    }
}


/*
    类与结构体的区别：
        类没有构造函数时，编译器自动生成无参数构造函数，如果自己声明了构造函数，这不会再自动生成默认构造函数，而结构体会一直有默认构造函数
 */