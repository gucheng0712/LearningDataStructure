

using System;

namespace ProgrammingQuestions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            EncodeAndDecodeTest();
        }


        public static void MaxStackTest()
        {
            MaxStack stack = new MaxStack();
            stack.Push(5);
            Console.WriteLine(stack.Peek());
            stack.Push(1);
            Console.WriteLine(stack.Peek());
            stack.Push(3);
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.PeekMax());
            stack.PopMax();
            Console.WriteLine(stack.PeekMax());
            stack.Pop();
            Console.WriteLine(stack.Peek());
        }

        public static void EncodeAndDecodeTest()
        {
            EncodeDecode ed = new EncodeDecode();
            string eCode_Base64 = ed.EncodeToBase64("1000");
            Console.WriteLine(eCode_Base64);
            string dCode_Base64 = ed.DecodeFromBase64(eCode_Base64);
            Console.WriteLine(dCode_Base64);

            string eCode_Guid = ed.EncodeToGuid("1000");
            Console.WriteLine(eCode_Guid);
            string dCode_Guid = ed.DecodeToGuid(eCode_Guid);
            Console.WriteLine(dCode_Guid);

        }
    }

}
