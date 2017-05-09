using System;
namespace hwapp
{
    interface ICustomCompare
    {
        // 接口定义不能添加任何访问修饰符，接口方法默认为public
        // 接口中，除了可以定义方法外，还可以包含  属性，事件，索引器，
        // 不能包含 字段 运算符重载，实例构造函数 析构函数
        int CompareTo(object ob);
    }


    class Person:ICustomCompare
    {
        private int age;

        int Age 
        {
            get {return age;}
            set {
                age = value;
            }
        }
        public int CompareTo(object value)
        {
            if(value == null)
            {return 1;}

            Person objother = (Person)value;
            if(this.Age > objother.Age)
            {
                return 1;
            }
            else if (this.Age < objother.Age)
            {
                return -1;
            }
            return 0;
        }
    }

    interface IChineseGreating
    {
        void sayHello();
    }

    interface IEnglishGreating
    {
        void sayHello();
    }


    class Person2:IChineseGreating,IEnglishGreating
    {
        void IChineseGreating.sayHello()  // not use [public]
        {
            Console.WriteLine("ninhao ");
        }

        void IEnglishGreating.sayHello()
        {
            Console.WriteLine("Hi, ");
        }
    }

    // Person2 man = new Person2();
    // IChineseGreating ichinese = (IChineseGreating)man 


}