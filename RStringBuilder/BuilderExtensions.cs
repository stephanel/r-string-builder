
namespace RStringBuilder
{
    public static class BuilderExtensions
    {
        public static Builder WithUpperCase(this Builder builder)
        {
            builder.Pattern.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            return builder;
        }

        public static Builder WithLowerCase(this Builder builder)
        {
            builder.Pattern.Append("abcdefghijklmnopqrstuvwxyz");
            return builder;
        }

        public static Builder WithDigit(this Builder builder)
        {
            builder.Pattern.Append("0123456789");
            return builder;
        }

        public static Builder WithWhiteSpace(this Builder builder)
        {
            builder.Pattern.Append(" ");
            return builder;
        }

        public static Builder WithSpecialChars(this Builder builder)
        {
            builder.Pattern.Append(Builder.SpecialChars);
            return builder;
        }
    }
}
