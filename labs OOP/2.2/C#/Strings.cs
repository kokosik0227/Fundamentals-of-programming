using System;

namespace StringPolymorphism
{
    public abstract class Strings
    {
        public abstract int Length();
        public abstract int Offset(char c);
        public abstract string GetValue();
        public abstract void Shift();
    }
}