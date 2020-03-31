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
            // var input = new TreeNode(3)
            // {
            //     Left = new TreeNode(9),
            //     Right = new TreeNode(20)
            //     {
            //         Left = new TreeNode(15),
            //         Right = new TreeNode(7)
            //     }
            // };
            
            // var input = new TreeNode(1)
            // {
            //     Left = new TreeNode(2)
            //     {
            //         Left = new TreeNode(4),
            //         Right = new TreeNode(5)
            //     },
            //     Right = new TreeNode(3)
            // };
            
            var input = new TreeNode(1)
            {
                Right = new TreeNode(3)
                {
                    Right = new TreeNode(5)
                },
                Left = new TreeNode(2)
                {
                    Left = new TreeNode(4)
                }
            };
            
            var sut = new Solution();
            
            // Act
            var result = sut.ZigzagOrder(input);
            
            // Assert
            result[0].Should().BeEquivalentTo(new[] {3});
        }
    }
}