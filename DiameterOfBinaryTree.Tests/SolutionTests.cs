using FluentAssertions;
using ValidateBinaryTree;
using Xunit;

namespace DiameterOfBinaryTree.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void DiameterOfBinaryTree_ReturnsDiameter()
        {
            // Arrange
            var input = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(5)
                },
                right = new TreeNode(3)
            };
            
            var sut = new Solution();
            
            // Act 
            var res = sut.DiameterOfBinaryTree(input);
            
            // Assert
            res.Should().Be(3);
        }
    }
}