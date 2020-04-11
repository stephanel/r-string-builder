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
        public void BuildStringContainingUpperCase()
        {
            // Arrange
            var builder = Builder
                .Create(1000)
                .WithUpperCase();

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
                .Create(1000)
                .WithLowerCase();

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
                .Create(1000)
                .WithDigit();

            // Act
            var actual = builder.Generate();

            // Assert
            actual.ShouldContainDigit();
        }

        [Fact]
        [Trait("Category", "UnitTests")]
        public void BuildStringContainingUpperCaseAndLowerCaseAndDigit()
        {
            // Arrange
            var builder = Builder
                .Create(1000)
                .WithDigit()
                .WithLowerCase()
                .WithUpperCase();

            // Act
            var actual = builder.Generate();

            // Assert
            actual.ShouldContainDigit();
            actual.ShouldContainLowerCase();
            actual.ShouldContainUpperCase();
        }
    }
}
