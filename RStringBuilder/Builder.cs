using System;
using System.Linq;
using System.Text;

namespace RStringBuilder
{
    public class Builder
    {
        public const string SpecialChars = @"/*-+_@&$#%";

        internal readonly int _length;
        internal static readonly Random random = new Random();

        internal string _defaultPattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        internal StringBuilder _pattern = new StringBuilder();

        internal Builder(int length)
        {
            _length = length;

        }

        public static Builder Create(int length)
        {
            return new Builder(length);
        }

        public string Generate()
        {
            if(string.IsNullOrWhiteSpace(_pattern.ToString()))
            {
                _pattern.Append(_defaultPattern);
            }

            return new string(Enumerable.Repeat(_pattern, _length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
