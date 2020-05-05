namespace IsGraphBipartite.Tests
{
    using FluentAssertions;
    using Xunit;

    public class SolutionTests
    {
        
        [Fact]
        public void GivenInput_ReturnsIfGraphIsBipartite()
        {
            // Arrange
            var sut = new Solution();
            var input = new[] {new[] {1, 3}, new[] {0, 2}, new[] {1, 3}, new[] {0, 2}};
            
            // Act
            var res = sut.IsBipartite(input);
            
            // Assert
            res.Should().BeTrue();
            
            
            
            
        }
    }
    
}