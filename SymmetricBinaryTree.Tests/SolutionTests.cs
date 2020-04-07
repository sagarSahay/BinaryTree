namespace SymmetricBinaryTree.Tests
{
    using FluentAssertions;
    using ValidateBinaryTree;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void IsSymmetric_WithInput_ReturnsTrueIfTreeIsSymmetric()
        {
            // Arrange
            var node = new TreeNode(1)
            {
                left = new TreeNode(2)
                {
                    left = new TreeNode(3),
                    right = new TreeNode(4)
                },
                right = new TreeNode(2)
                {
                    left = new TreeNode(4),
                    right = new TreeNode(3)
                }
            };
            
            var sut = new Solution();
            
            // Act
            var result = sut.IsSymmetric(node);
            
            // Assert
            result.Should().BeTrue();
        }
    }
}