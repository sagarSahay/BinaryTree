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
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                },
                left = new TreeNode(9)
            };
            
            var sut= new Solution();
            
            // Act
            var result = sut.MaxPathSum(input);
            
            // Assert
            
            result.Should().Be(42);
        }
    }
}