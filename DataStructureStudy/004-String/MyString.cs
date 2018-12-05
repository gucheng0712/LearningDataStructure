using System;
namespace String
{
    public class MyString
    {
        private char[] data; // 用来存放字符串中的字符

        public char this[int index] => data[index];// 根据索引访问字符的索引器

        public MyString() { }

        public MyString(char[] array)
        {
            data = new char[array.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = array[i];
            }
        }

        public MyString(string str)
        {
            data = new char[str.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = str[i];
            }
        }

        public int GetLength() { return data.Length; }

        // 如果两个字符串一样,返回0
        // 如果当前字符串小于s, 返回-1
        // 如果当前字符串大于s, 那么返回1
        // 实例: 人物姓名排序等
        public int Compare(MyString s)
        {
            // 取的两个字符串中长度更小的字符串的长度
            int len = this.GetLength() < s.GetLength() ? this.GetLength() : s.GetLength();

            int index = -1; // 存储不相等的字符的索引位置

            for (int i = 0; i < len; i++)
            {
                if (this[i] != s[i])
                {
                    index = i;
                    break;
                }
            }
            if (index != -1) // 如果index 不等于 -1, 那么就是说明两个字符串有不同的字符
            {
                if (this[index] > s[index]) // 比较不相等的字符串
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else // 如果index=-1 说明在更小的字符串长度里面, 两者是一样的
            {
                if (this.GetLength() == s.GetLength())
                {
                    return 0;
                }
                else // 如果长度不相等
                {
                    //比较长度
                    if (this.GetLength() > s.GetLength())
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }

        // 从string里面取得一个字符串返回
        public MyString SubString(int index, int length)
        {
            char[] newData = new char[length];
            for (int i = index; i < index + length; i++)
            {
                newData[i - index] = data[i];
            }
            return new MyString(newData);
        }


        // 把两个字符串拼接成一个字符串
        public static MyString Connect(MyString s1, MyString s2)
        {
            char[] newData = new char[s1.GetLength() + s2.GetLength()];
            // s1 在索引0~s1.Length-1 的位置.
            // s2 在索引s1.Length~s1.Length+s2.Length-1 的位置
            for (int i = 0; i < s1.GetLength(); i++)
            {
                newData[i] = s1[i];
            }
            for (int i = s1.GetLength(); i < newData.Length; i++)
            {
                newData[i] = s2[i - s1.GetLength()];
            }
            return new MyString(newData);
        }

        // 返回字符中indexof（string）中字串string在父串中首次出现的位置
        public int IndexOf(MyString s)
        {
            // 遍历父串减去子串 s 的长度
            for (int i = 0; i <= this.GetLength() - s.GetLength(); i++)
            {
                bool isEqual = true;

                // 父串减去子串的长度次数下,每次都比较父串J索引下的字符和s[J-I]索引下的字符是否相等
                for (int j = i; j < i + s.GetLength(); j++)
                {
                    if (this[j] != s[j - i])
                    {
                        isEqual = false;
                    }
                }
                if (isEqual) { return i; } else { continue; }
            }
            return -1;
        }


    }
}
