using System;

namespace StringPolymorphism
{
    public class Lowercase : Strings
    {
        private string value;

        public Lowercase(string s)
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
                value = value.Substring(1) + value[0];
            }
        }
    }
}