using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace All_Type_Patterns
{
    internal class Triangle_Pattern
    {
        public void LeftAngle(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(new string('*',i+1));
            }
        }
        public void RightAngle(int length)
        {
            
            for (int i = length; i > 0; i--)
            {
                Console.WriteLine(new string(' ',i-1)+new string('*',(length+1)-i));
            }
        }
        


    }


    
}
