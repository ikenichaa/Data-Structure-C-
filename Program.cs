using System;
using System.IO;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"C:\Users\USER\Desktop\Lexer\Day2\DataStructure\DataStructure\train.csv"))
            {
                LinkedList A = new LinkedList();
                Stack B = new Stack();
                Queue C = new Queue();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(',');

                    B.push(values[0]);
                    C.enqueue(values[1]);
                }
                Object name;
                Object age;
                for (int i=0; i < B.list.size; i++)
                {
                    name = B.list.getElementAtIndex(i);
                    age = C.list.getElementAtIndex(i);
                    Console.WriteLine(name + " : " + age + " years old");
                }
              
                Console.ReadKey();
            }


        }


    }
}
