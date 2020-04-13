using FluentAssertions;
using Xunit;
using RStringBuilder.Tests.Extensions;

namespace RStringBuilder.Tests
{
    public class StringBuilderShould
    {
        [Fact]
        [Trait("Category", "UnitTests")]
        public void Generate10CharacterString()
        {
            // Arrange
            var builder = Builder.Create()
                .WithLength(10);

            // Act
            var actual = builder.Generate();

            // Assert
            actual.Length.Should().Be(10);
        }

        [Fact]
        [Trait("Category", "UnitTests")]
        public void BuildStringContainingUpperCase()
        {
            // Arrange
            var builder = Builder
                .Create()
                .UseUpperCase();

            // Act
            var actual = builder.Generate();

            // Assert
            actual.ShouldContainUpperCase();
        }

        [Fact]
        [Trait("Category", "UnitTests")]
        public void BuildStringContainingLowerCase()
        {
            // Arrange
            var builder = Builder
                .Create()
                .UseLowerCase();

            // Act
            var actual = builder.Generate();

            // Assert
            actual.ShouldContainLowerCase();
        }

        [Fact]
        [Trait("Category", "UnitTests")]
        public void BuildStringContainingDigit()
        {
            // Arrange
            var builder = Builder
                .Create()
                .UseDigit();

            // Act
            var actual = builder.Generate();

            // Assert
            actual.ShouldContainDigit();
        }

        [Fact]
        [Trait("Category", "UnitTests")]
        public void BuildStringContainingWhiteSpace()
        {
            // Arrange
            var builder = Builder
                .Create()
                .UseWhiteSpace();

            // Act
            var actual = builder.Generate();

            // Assert
            actual.ShouldContainWhiteSpace();
        }

        [Fact]
        [Trait("Category", "UnitTests")]
        public void BuildStringContainingSpecialChars()
        {
            // Arrange
            var builder = Builder
                .Create()
                .UseSpecialChars();

            // Act
            var actual = builder.Generate();

            // Assert
            actual.ShouldContainSpecialChars();
        }

        [Fact]
        [Trait("Category", "UnitTests")]
        public void BuildStringContainingAllPossibleCharacters()
        {
            // Arrange
            var builder = Builder
                .Create()
                .UseDigit()
                .UseLowerCase()
                .UseSpecialChars()
                .UseUpperCase();

            // Act
            var actual = builder.Generate();

            // Assert
            actual.ShouldContainDigit();
            actual.ShouldContainLowerCase();
            actual.ShouldContainSpecialChars();
            actual.ShouldContainUpperCase();
        }
    }
}
