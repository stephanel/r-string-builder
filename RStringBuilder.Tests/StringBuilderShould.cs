using FluentAssertions;
using Xunit;
using RStringBuilder.Tests.Extensions;

namespace RStringBuilder.Tests
{
    public class StringBuilderShould
    {
        [Fact]
        [Trait("Category", "UnitTests")]
        public void GenerateString10CharactersLong()
        {
            // Arrange
            var builder = Builder.Create(10);

            // Act
            var actual = builder.Generate();

            // Assert
            actual.Length.Should().Be(10);
        }

        [Fact]
        [Trait("Category", "UnitTests")]
        public void BuildStringContainingOnlyUpperCase()
        {
            // Arrange
            var builder = Builder
                .Create(1000)
                .UseOnlyUpperCase();

            // Act
            var actual = builder.Generate();

            // Assert
            actual.ShouldContainUpperCaseOnly();
        }

        [Fact]
        [Trait("Category", "UnitTests")]
        public void BuildStringContainingOnlyLowerCase()
        {
            // Arrange
            var builder = Builder
                .Create(1000)
                .UseOnlyLowerCase();

            // Act
            var actual = builder.Generate();

            // Assert
            actual.ShouldContainLowerCaseOnly();
        }

        [Fact]
        [Trait("Category", "UnitTests")]
        public void BuildStringContainingOnlyDigit()
        {
            // Arrange
            var builder = Builder
                .Create(1000)
                .UseOnlyDigit();

            // Act
            var actual = builder.Generate();

            // Assert
            actual.ShouldContainDigitOnly();
        }

    }
}
