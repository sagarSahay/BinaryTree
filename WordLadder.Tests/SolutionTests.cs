using System.Collections.Generic;
using FluentAssertions;
using Xunit;

namespace WordLadder.Tests
{
    public class SolutionTests
    {
        [Fact]
        public void FindLadders_GivenDict_ReturnsTransformationSequence()
        {
            // Arrange
            var beginWord = "hit";
            var endWord = "cog";
            var wordList = new List<string> {"hot", "dot", "dog", "lot", "log", "cog"};
            
            var sut = new Solution();
            
            // Act
            var res = sut.LadderLength(beginWord, endWord, wordList);
            
            // Assert
            res.Should().Be(5);
        }
    }
}