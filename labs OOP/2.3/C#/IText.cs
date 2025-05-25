using System;

namespace TextProcessing
{
    public interface IText
    {
        string GetFirstChars();
        string GetValue();
        void UppercaseFirstLetters();
    }
}