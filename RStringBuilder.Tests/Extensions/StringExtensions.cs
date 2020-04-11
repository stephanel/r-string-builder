﻿using System.Linq;
using Xunit.Sdk;

namespace RStringBuilder.Tests.Extensions
{
    internal static class StringExtensions
    {
        internal static void ShouldContainUpperCase(this string value)
        {
            var result = value.Any(char.IsUpper);
            if (!result)
            {
                throw new ContainsException("Value does not contain upper case.", value);
            }
        }

        internal static void ShouldContainLowerCase(this string value)
        {
            var result = value.Any(char.IsLower);
            if (!result)
            {
                throw new ContainsException("Value does not contain lower case.", value);
            }
        }

        internal static void ShouldContainDigit(this string value)
        {
            var result = value.Any(char.IsDigit);
            if (!result)
            {
                throw new ContainsException("Value does not contain digit.", value);
            }
        }

        internal static void ShouldContainWhiteSpace(this string value)
        {
            var result = value.Any(char.IsWhiteSpace);
            if (!result)
            {
                throw new ContainsException("Value does not contain white space.", value);
            }
        }

    }
}
