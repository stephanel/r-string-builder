using System;
using System.Linq;

namespace RStringBuilder
{
    public class Builder
    {
        internal readonly int _length;
        internal static readonly Random random = new Random();

        internal string _pattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 ";

        internal Builder(int length)
        {
            _length = length;

        }

        public static Builder Create(int length)
        {
            return new Builder(length);
        }

        //public static Builder UseOnlyUpperCase(this Builder builder)
        //{
        //    builder._pattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        //    return builder;
        //}

        public string Generate()
        {
            return new string(Enumerable.Repeat(_pattern, _length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
