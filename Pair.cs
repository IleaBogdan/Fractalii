﻿namespace Fractalii
{
    public class Pair<T, U>
    {
        public Pair(){}

        public Pair(T first, U second)
        {
            this.First = first;
            this.Second = second;
        }

        public static Pair<T, U> make_pair(T first, U second)
        {
            return new Pair<T, U>(first, second);
        }
        public T First { get; set; }
        public U Second { get; set; }
    }
}
