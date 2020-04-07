using FluentAssertions;
using ValidateBinaryTree;
using Xunit;

namespace LCA.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void LowestCommonAncestor_WhenGivenInput_ReturnsLowestCommonAncestor()
        {
            //[3,5,1,6,2,0,8,null,null,7,4]
            //[3,5,1,6,2,0,8,null,null,7,4]
            // Arrange
            var input = new TreeNode(3)
            {
                left = new TreeNode(5)
                {
                    left = new TreeNode(6),
                    right = new TreeNode(2)
                    {
                        left = new TreeNode(7),
                        right = new TreeNode(4)
                    }
                },
                right = new TreeNode(1)
                {
                    left = new TreeNode(0),
                    right = new TreeNode(8)
                }
            };
            
            var p = new TreeNode(5);
            var q = new TreeNode(4);
            
            var sut = new Solution();
            
            // Act
            var res = sut.LowestCommonAncestor(input, p, q);
            
            // Assert
            res.val.Should().Be(3);
        }
    }
}