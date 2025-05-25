using System;

namespace StringPolymorphism
{
    public class Numbers : Strings
    {
        private string value;

        public Numbers(string s)
        {
            value = s;
        }

        public override int Length()
        {
            return value.Length;
        }

        public override int Offset(char c)
        {
            int pos = value.IndexOf(c);
            return pos;
        }

        public override string GetValue()
        {
            return value;
        }

        public override void Shift()
        {
            if (!string.IsNullOrEmpty(value))
            {
                char last = value[^1];
                value = last + value.Substring(0, value.Length - 1);
            }
        }
    }
}