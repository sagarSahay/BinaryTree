namespace ValidateBinaryTree.Tests
{
    using FluentAssertions;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void ValidateBinaryTree_WhenGivenInput_ValidatesTree()
        {
            // Arrange
            var node = new TreeNode(2)
            {
                Left = new TreeNode(1),
                Right= new TreeNode(3)
            };
            
            var sut = new Solution();
            
            // Act 
            var result = sut.IsValidBST(node);
            
            // Assert
            result.Should().BeTrue();
        }
    }
}