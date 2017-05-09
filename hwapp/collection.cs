using System;
using System.Collections.Generic;
namespace hwapp
{
    class TestClass
    {
        public static void fn_test()
        {
            List<String> al = new List<String>();
            al.Add("asdfas;");
            al.Add("1212312");

            al.AddRange(new List<String>());

            Dictionary<String,String> dic = new Dictionary<String,String>();
            dic.Add("123","324");
            String a = dic["123"];
            Console.WriteLine("a = " + a);
        }
    }

}