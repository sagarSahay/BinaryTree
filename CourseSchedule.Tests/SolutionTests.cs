namespace CourseSchedule.Tests
{
    using System;
    using FluentAssertions;
    using TopologicalSort;
    using Xunit;

    public class SolutionTests
    {
        [Fact]
        public void CanFinish_WhenValidInput_ReturnsWhetherWeCanFinishACourse()
        {
            // Arrange 
            var prerequisites = new[]
            {
                new[] {1, 0},
                new[] {0, 1}
            };
            var numberOfCourses = 2;

           // var sut = new Solution();
           var sut = new SolutionTopological();

            // Act
            var res = sut.CanFinish(numberOfCourses, prerequisites);

            // Assert
            res.Should().BeFalse();
        }
    }
}