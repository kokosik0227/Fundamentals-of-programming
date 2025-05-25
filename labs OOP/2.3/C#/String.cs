using System;
using System.Linq;

namespace TextProcessing
{
    public class String : IText
    {
        private string value;

        public String(string s)
        {
            value = s ?? throw new ArgumentNullException(nameof(s));
        }

        public string GetFirstChars()
        {
            if (string.IsNullOrEmpty(value))
            {
                return "";
            }

            return string.Join("", value.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(word => word[0]));
        }

        public string GetValue()
        {
            return value;
        }

        public void UppercaseFirstLetters()
        {
            if (string.IsNullOrEmpty(value))
            {
                return;
            }

            char[] chars = value.ToCharArray();
            bool newWord = true;

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsWhiteSpace(chars[i]))
                {
                    newWord = true;
                }
                else
                {
                    if (newWord && char.IsLetter(chars[i]))
                    {
                        chars[i] = char.ToUpper(chars[i]);
                    }
                    newWord = false;
                }
            }

            value = new string(chars);
        }
    }
}