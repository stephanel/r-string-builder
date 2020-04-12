using System;
using System.Linq;
using System.Text;

namespace RStringBuilder
{
    public class Builder
    {
        public const string SpecialChars = @"/*-+_@&$#%";

        private readonly int _length;
        private static readonly Random random = new Random();

        private readonly string _defaultPattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        internal StringBuilder Pattern { get; } = new StringBuilder();

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
            if(string.IsNullOrWhiteSpace(Pattern.ToString()))
            {
                Pattern.Append(_defaultPattern);
            }

            return new string(Enumerable.Repeat(Pattern, _length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
