namespace BinaryTreeMaximumSumPath.Tests
{
    using FluentAssertions;
    using ValidateBinaryTree;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void MaxPathSum_WhenGivenValidTree_ReturnsMaxSum()
        {
            // Arrange
            var input = new TreeNode(-10)
            {
                Right = new TreeNode(20)
                {
                    Left = new TreeNode(15),
                    Right = new TreeNode(7)
                },
                Left = new TreeNode(9)
            };
            
            var sut= new Solution();
            
            // Act
            var result = sut.MaxPathSum(input);
            
            // Assert
            
            result.Should().Be(42);
        }
    }
}