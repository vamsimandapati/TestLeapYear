using LeapYear;
using Xunit;

namespace TestLeapYear
{
    public class LeapYear
    {
        [Fact]
        private void Be_A_Leap_Year_When_Year_Is_Divisible_By_400()
        {
            // Giwen
            var sut = new Year(4000);

            // When
            var actual = sut.IsLeap();

            // Then
            Assert.True(actual);
        }

        [Fact]
        private void Be_A_Leap_Year_When_Year_Is_Divisible_By_4_And_Is_Not_Divisible_By_100()
        {
            // Giwen
            var sut = new Year(2016);

            // When
            var actual = sut.IsLeap();

            // Then
            Assert.True(actual);
        }

        [Fact]
        private void Be_Not_A_Leap_Year_When_Year_Is_Divisible_By_100_And_Is_Not_Divisible_By_400()
        {
            // Giwen
            var sut = new Year(4100);

            // When
            var actual = sut.IsLeap();

            // Then
            Assert.False(actual);
        }

        [Fact]
        private void Be_Not_A_Leap_Year_When_Year_Is_Not_Divisible_By_4()
        {
            // Giwen
            var sut = new Year(2015);

            // When
            var actual = sut.IsLeap();

            // Then
            Assert.False(actual);
        }
    }
}