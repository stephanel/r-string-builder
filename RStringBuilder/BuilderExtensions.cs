
namespace RStringBuilder
{
    public static class BuilderExtensions
    {
        public static Builder UseOnlyUpperCase(this Builder builder)
        {
            builder._pattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return builder;
        }

        public static Builder UseOnlyLowerCase(this Builder builder)
        {
            builder._pattern = "abcdefghijklmnopqrstuvwxyz";
            return builder;
        }

        public static Builder UseOnlyDigit(this Builder builder)
        {
            builder._pattern = "0123456789";
            return builder;
        }
    }
}
