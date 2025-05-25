using System;
using System.Collections.Generic;

namespace TextProcessing
{
    public class TextContainer
    {
        private List<IText> texts;

        public TextContainer()
        {
            texts = new List<IText>();
        }

        public void AddString(string s)
        {
            texts.Add(new String(s));
        }

        public void DeleteString(int index)
        {
            if (index >= 0 && index < texts.Count)
            {
                texts.RemoveAt(index);
            }
        }

        public void ClearText()
        {
            texts.Clear();
        }

        public void UppercaseFirstLetters()
        {
            foreach (var text in texts)
            {
                text.UppercaseFirstLetters();
            }
        }

        public string GetKey(string s)
        {
            return new String(s).GetFirstChars();
        }

        public int GetCountOfLength(int len)
        {
            int count = 0;
            foreach (var text in texts)
            {
                if (text.GetValue().Length == len)
                {
                    count++;
                }
            }
            return count;
        }

        public IReadOnlyList<IText> GetTexts()
        {
            return texts.AsReadOnly();
        }
    }
}