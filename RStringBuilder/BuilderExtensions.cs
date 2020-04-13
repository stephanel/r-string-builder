
namespace RStringBuilder
{
    public static class BuilderExtensions
    {
        public static Builder UseUpperCase(this Builder builder)
        {
            builder.Pattern.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            return builder;
        }

        public static Builder UseLowerCase(this Builder builder)
        {
            builder.Pattern.Append("abcdefghijklmnopqrstuvwxyz");
            return builder;
        }

        public static Builder UseDigit(this Builder builder)
        {
            builder.Pattern.Append("0123456789");
            return builder;
        }

        public static Builder UseWhiteSpace(this Builder builder)
        {
            builder.Pattern.Append(" ");
            return builder;
        }

        public static Builder UseSpecialChars(this Builder builder)
        {
            builder.Pattern.Append(Builder.SpecialChars);
            return builder;
        }

        public static Builder WithLength(this Builder builder, int length)
        {
            builder.Length = length;
            return builder;
        }
    }
}
