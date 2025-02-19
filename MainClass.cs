using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Type_Patterns
{
    internal class MainClass
    {
        public void print()
        {
            //Console.WriteLine("Hello");
            List<string> list = new List<string>();
            list.Add("1-Left Triangle");
            list.Add("2-Right Triangle");
            list.Add("3-Triangle");
            list.Add("4-Triangle");
            foreach (string s in list)
            {
                Console.WriteLine(s);
            }
            Console.Write("Enter the Number to print triangle.....:-");
            int num = Convert.ToInt16(Console.ReadLine());
            
            Console.Write("Enter the length of triangle.....:-");
            int length = Convert.ToInt16(Console.ReadLine());
            if (length % 2 == 0)
            {
                Console.WriteLine("Enter Odd Numbers......");
                return;
            }
            else
            {
                Triangle_Pattern tri = new Triangle_Pattern();
                if (num == 1)
                    tri.LeftAngle(length);
                else if (num == 2)
                    tri.RightAngle(length);

            }






        }


    }
}
