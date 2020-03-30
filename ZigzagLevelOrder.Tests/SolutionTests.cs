namespace ZigzagLevelOrder.Tests
{
    using ValidateBinaryTree;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void ZigzagLevelOrder_WhenGivenInput_ReturnsZigzagLevelOrder()
        {
            // Arrange
            var input = new TreeNode(3)
            {
                Left = new TreeNode(9),
                Right = new TreeNode(20)
                {
                    Left = new TreeNode(15),
                    Right = new TreeNode(7)
                }
            };
            
            var sut = new Solution();
            
            // Act
            var 
        }
    }
}