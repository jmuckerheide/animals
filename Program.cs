using System;
using System.Collections.Generic;

namespace Animals
{
    class Program
    {
        //static void Main(string[] args)
        //{ }

        private readonly static FileOutput outFile = new FileOutput("C:/Users/Crispian/Documents/MobileWeb/Animals/animalsOutput.txt");
        private readonly static FileInput inFile = new FileInput("animals.txt");

        static void Main(String[] args)//Might be static void Main(String[] args)
        {
            List<ITalkable> zoo = new List<ITalkable>();
            //ArrayList zoo = new ArrayList();




            // Lines to Replace Begin Here
            zoo.Add(new Dog(true, "Bean"));
            zoo.Add(new Cat(9, "Charlie"));
            zoo.Add(new Teacher(44, "Stacy Read"));
            // End Lines to Replace

            foreach (ITalkable thing in zoo)
            {
                printOut(thing);
            }
            outFile.fileClose();
            inFile.fileRead();
            inFile.fileClose();

            FileInput indata = new FileInput("animals.txt");
            String line;
            while ((line = indata.fileReadLine()) != null)
            {
                Console.WriteLine(line);
            }
        }

        public static void printOut(ITalkable p)
        {
            Console.WriteLine(p.getName() + " says=" + p.talk());
            outFile.fileWrite(p.getName() + " | " + p.talk());
        }
    }
}

