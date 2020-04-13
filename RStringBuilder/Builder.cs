using System;
using System.Linq;
using System.Text;

namespace RStringBuilder
{
    public class Builder
    {
        public const string SpecialChars = @"/*-+_@&$#%";

        private int _length = 0;
        private const int DefaultMaxLength = 1000;
        private static readonly Random random = new Random();

        private readonly string _defaultPattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
        internal StringBuilder Pattern { get; } = new StringBuilder();

        private Builder()
        { }

        public static Builder Create()
        {
            return new Builder();
        }

        public string Generate()
        {
            if(string.IsNullOrWhiteSpace(Pattern.ToString()))
            {
                Pattern.Append(_defaultPattern);
            }

            if(_length == 0)
            {
                _length = new Random().Next(DefaultMaxLength);
            }

            return new string(Enumerable.Repeat(Pattern, _length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
