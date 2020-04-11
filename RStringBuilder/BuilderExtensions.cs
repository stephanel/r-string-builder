
namespace RStringBuilder
{
    public static class BuilderExtensions
    {
        public static Builder WithUpperCase(this Builder builder)
        {
            builder._pattern.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
            return builder;
        }

        public static Builder WithLowerCase(this Builder builder)
        {
            builder._pattern.Append("abcdefghijklmnopqrstuvwxyz");
            return builder;
        }

        public static Builder WithDigit(this Builder builder)
        {
            builder._pattern.Append("0123456789");
            return builder;
        }

        public static Builder WithWhiteSpace(this Builder builder)
        {
            builder._pattern.Append(" ");
            return builder;
        }
    }
}
