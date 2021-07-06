using System;

namespace Parte_3
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack obj = new Stack();
            obj.Pop();
            obj.push(1);
            obj.push(2);
            obj.push(3);
            obj.push(4);
            Console.WriteLine(obj.Pop());
            obj.push(5);
            Console.WriteLine(obj.Peek());





        }

        class Stack 
        {
            public int[] data;
            private int len;
            public Stack() 
            {
                data = new int[] { };
                len = 0;

            }
            
            public bool isEmpty() 
            {
                if (len == 0) 
                {
                    return true;
                }
                return false;

            }

            public void push(int a) 
            {

                int[] temp = new int[len + 1];
                data.CopyTo(temp, 0);
                temp[len] = a;
                data = temp;
                len++;



            }

            public int Pop() 
            {
                if (!isEmpty())
                {

                    int a = data[len - 1];
                    int[] temp = new int[len - 1];
                    Array.ConstrainedCopy(data, 0, temp, 0, len - 1);
                    data = temp;
                    len--;
                    return a;
                }
                Console.WriteLine("Nos se puede, Pop Vacio");
                return 0;


            }

            public int Length() 
            {

                return len;

            }


            public int Peek() 
            {
                return data[len - 1];

            }



        }


    }
}
