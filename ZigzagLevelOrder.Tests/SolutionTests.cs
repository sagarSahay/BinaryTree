using FluentAssertions;

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
                left = new TreeNode(9),
                right = new TreeNode(20)
                {
                    left = new TreeNode(15),
                    right = new TreeNode(7)
                }
            };
            
            // var input = new TreeNode(1)
            // {
            //     Left = new TreeNode(2)
            //     {
            //         Left = new TreeNode(4),
            //         Right = new TreeNode(5)
            //     },
            //     Right = new TreeNode(3)
            // };
            
            // var input = new TreeNode(1)
            // {
            //     right = new TreeNode(3)
            //     {
            //         right = new TreeNode(5)
            //     },
            //     left = new TreeNode(2)
            //     {
            //         left = new TreeNode(4)
            //     }
            // };
            
            var sut = new Solution();
            
            // Act
            var result = sut.ZigzagOrder(input);
            
            // Assert
            result[0].Should().BeEquivalentTo(new[] {3});
        }
    }
}