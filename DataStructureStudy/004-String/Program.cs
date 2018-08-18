using System;

namespace String
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            MyString s = new MyString("I am a teacher");
            MyString i = new MyString("excellent");
            MyString r = new MyString("student");

            Console.WriteLine(s.GetLength());
            Console.WriteLine(i.GetLength());
            Console.WriteLine(r.GetLength());

            MyString subS = new MyString();
            subS = s.SubString(8, 4);
            MyString subI = new MyString();
            subI = i.SubString(2, 1);

            MyString newStr1 = new MyString("tea");
            MyString newStr2 = new MyString("cell");
            MyString newStr3 = new MyString("den");
            Console.WriteLine(s.IndexOf(newStr1));
            Console.WriteLine(i.IndexOf(newStr2));
            Console.WriteLine(r.IndexOf(newStr3));
        }
    }
}
