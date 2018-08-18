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

            Console.WriteLine(sequenceList.GetElement(0));
            Console.WriteLine(sequenceList[0]);
            for (int i = 0; i < sequenceList.GetLength(); i++)
            {
                Console.Write(sequenceList[i] + " ");
            }
            Console.WriteLine();
            sequenceList.Insert("777", 2);
            for (int i = 0; i < sequenceList.GetLength(); i++)
            {
                Console.Write(sequenceList[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(sequenceList.Location("777"));

            sequenceList.Delete(0);
            for (int i = 0; i < sequenceList.GetLength(); i++)
            {
                Console.Write(sequenceList[i] + " ");
            }
            Console.WriteLine();

            sequenceList.Clear();
            Console.WriteLine(sequenceList.GetLength());

            Console.ReadKey();
        }
    }
}
