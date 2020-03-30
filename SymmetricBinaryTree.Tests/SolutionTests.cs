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
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(3),
                    Right = new TreeNode(4)
                },
                Right = new TreeNode(2)
                {
                    Left = new TreeNode(4),
                    Right = new TreeNode(3)
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