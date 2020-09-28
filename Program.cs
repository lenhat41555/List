using System;
using System.Collections.Generic;
using System.Linq;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> MyList4 = new List<string>();
            MyList4.Add("lion");
            MyList4.Add("cat");
            MyList4.Add("dog");
            MyList4.Add("elephant");
          // In giá trị các phần tử trong List
           Console.WriteLine(" List ban dau: ");
          foreach (var item in MyList4)
                {
                    Console.WriteLine(item);
                }
           Console.WriteLine(" xoa phan tu dog trong danh sach: ");
         MyList4.Remove("dog");
                foreach (var item in MyList4)
                {
                    Console.WriteLine(item);
                }
        Console.WriteLine(" Danh sach list sau khi sap xep : ");
        var list = from ani in MyList4
            orderby ani.Length
            select ani;
         foreach (var item in list)
                {
                Console.WriteLine(item);
                }
        Console.WriteLine("Index cat  : ");
          Console.WriteLine(MyList4.IndexOf("cat"));
        }
    }
}
