using System;
using System.Collections.Generic;

namespace List
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //SequenceList<string> sequenceList = new SequenceList<string>();
            LinkedList<string> sequenceList = new LinkedList<string>();
            sequenceList.Add("123");
            sequenceList.Add("456");
            sequenceList.Add("789");

            Console.WriteLine("Get the First Element: " + sequenceList.GetElement(0));
            Console.WriteLine("Get the First Element: " + sequenceList[0]);

            Console.Write("print all Elements: ");
            for (int i = 0; i < sequenceList.GetLength(); i++)
            {
                Console.Write(sequenceList[i] + " ");
            }
            Console.WriteLine();


            sequenceList.Insert("777", 2);
            Console.Write("Inserted '777' into the index 2, Print whole list: ");
            for (int i = 0; i < sequenceList.GetLength(); i++)
            {
                Console.Write(sequenceList[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("The location of '777' is: " + sequenceList.Location("777"));


            sequenceList.Delete(0);
            Console.Write("Deleted the element of index 0, print whole list: ");
            for (int i = 0; i < sequenceList.GetLength(); i++)
            {
                Console.Write(sequenceList[i] + " ");
            }
            Console.WriteLine();


            sequenceList.Clear();

            Console.WriteLine("Clear the list, print the length of the list: " + sequenceList.GetLength());

            Console.ReadKey();
        }
    }
}
