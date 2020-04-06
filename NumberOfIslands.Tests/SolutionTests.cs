namespace NumberOfIslands.Tests
{
    using FluentAssertions;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void NumIslands_WhenGiven2DArray_ReturnsNumberOfIslands()
        {
            // Arrange
            var input = new[,]
            {
                {'1', '1', '1', '1', '0'},
                {'1', '1', '0', '1', '0'},
                {'1', '1', '0', '0', '0'},
                {'0', '0', '0', '0', '0'}
            };
            
            var sut = new Solution();
            
            // Act
            var res = sut.NumIslands(input);
            
            // Assert
            res.Should().Be(1);
        }
    }
}