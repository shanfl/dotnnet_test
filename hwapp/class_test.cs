using System;
namespace hwapp
{
    /*
    类与结构体的区别：
        类没有构造函数时，编译器自动生成无参数构造函数，如果自己声明了构造函数，这不会再自动生成默认构造函数，而结构体会一直有默认构造函数
    */
    public class TestClassA
    {
        private static String name;

        static TestClassA()  // 静态构造函数，仅执行一次
        {
            Console.WriteLine("TestClassA's static constructor");
            name = @"d\a\c\c";
        }

        public TestClassA(String a)
        {
             Console.WriteLine("TestClassA's constructor");   
        } 

        public TestClassA()
        {
             Console.WriteLine("TestClassA's default constructor");   
        } 

        ~TestClassA()
        {
            Console.WriteLine("TestClassA's deconstructor");

            // blow is detail
            // try
            // {
            //     Console.WriteLine("TestClassA's deconstructor");
            // }
            // finally
            // {
            //     base.Finalize();
            // }
        }    

        // 索引器
        private int[] data = new int[10];
        public int this[int idx]
        {
            get
            {
                if (idx <= 9 && idx >=0)
                    return data[idx];
                else
                    return 0;
            }
            set
            {
                if (idx <= 9 && idx >=0)
                {
                   data[idx] = value; 
                }
            }
        }
    };

    public abstract class Animal
    {
        private int age;
        public int Age
        {
            get 
            {
                return age;
            }
            set 
            {
                age = value;
            }
        }

        public virtual void voice()
        {
            Console.WriteLine("动物发声");
        }

        public virtual void singsong()
        {
            Console.WriteLine("singsong");
        }
    }

    public   class Horse : Animal
    {
        public override void voice()
        {
            Console.WriteLine("动物发声 - horse");
        }

        public sealed override void singsong() //
        {
            Console.WriteLine("singsong - horse");  // 
        }
    };

    public class FlyHorse: Horse
    {
        // forbid to do this
        // public override void singsong()
        // {

        // }
    }

    public class Sheep:Animal
    {
        public new void voice()  //？
        {
            Console.WriteLine("动物发声 - Sheep");
        }
    }

    public sealed class SealClass
    {
        private String name;
    }

    // public class InHeC: SealClass
    // {

    // }




}