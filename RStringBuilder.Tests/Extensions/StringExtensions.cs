using System.Linq;
using Xunit.Sdk;

namespace RStringBuilder.Tests.Extensions
{
    internal static class StringExtensions
    {
        internal static void ShouldContainUpperCaseOnly(this string value)
        {
            var result = value.Any(char.IsLower);
            if (result)
            {
                throw new ContainsException("Value does not contains only upper case", value);
            }
        }

        internal static void ShouldContainLowerCaseOnly(this string value)
        {
            var result = value.Any(char.IsUpper);
            if (result)
            {
                throw new ContainsException("Value does not contains only lower case", value);
            }
        }

        internal static void ShouldContainDigitOnly(this string value)
        {
            foreach(var character in value)
            {
                if(!char.IsDigit(character))
                {
                    throw new ContainsException("Value does not contains only digit", value);
                }
            }
        }
    }
}
