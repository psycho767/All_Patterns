using System;

namespace All_Type_Patterns
{
    class Square_Pattern
    {
        public void Square(int length)
        {
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(new string('*',length));
            }
        }

        public void Outline_Square(int length)
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || j == 0 || j==length-1 || i== length-1 || i==j || j== (length-1)-i)
                    Console.Write("*");
                    else
                        Console.Write(" ");
                } 
                Console.WriteLine();
            }
        
        }

        public void RightTiltedSquare(int length)
        {
            
            for (int i = 0; i < length; i++)
            {
                Console.Write(new string(' ', (length - 1) - i));
                for (int j = 0; j < length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        public void RightTilted_OutlineSquare(int length)
        {
            
            for (int i = 0; i < length; i++)
            {
                Console.Write(new string(' ', (length - 1) - i));
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || j == 0 || j==length-1 || i== length-1 )
                    Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void LeftTiltedSquare(int length)
        {
            
            for (int i = 0; i < length; i++)
            {
                Console.Write(new string(' ', i));
                for (int j = 0; j < length; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public void LeftTilted_OutlineSquare(int length)
        {
            
            for (int i = 0; i < length; i++)
            {
                Console.Write(new string(' ', i));
                for (int j = 0; j < length; j++)
                {
                    if (i == 0 || j == 0 || j==length-1 || i== length-1 )
                    Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        public void Chess_Square(int length)
        {
            
            for (int i = 0; i < length; i++)
            {
                //Console.Write(new string(' ', i));
                for (int j = 0; j < length; j++)
                {
                    if (i%2==0 && j%2==0 )
                    Console.Write("□");
                    else if(i%2!=0 && j%2!=0)
                    Console.Write("□");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
        }


    }
}