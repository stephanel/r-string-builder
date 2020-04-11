
namespace RStringBuilder
{
    public static class BuilderExtensions
    {
        public static Builder UseOnlyUpperCase(this Builder builder)
        {
            builder._pattern = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            return builder;
        }
    }
}
