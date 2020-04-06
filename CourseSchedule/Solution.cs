namespace CourseSchedule
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq.Expressions;

    public class Solution
    {
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            var courseDict = new Dictionary<int, LinkedList<int>>();

            foreach (var prerequisite in prerequisites)
            {
                if (courseDict.ContainsKey(prerequisite[1]))
                {
                    courseDict[prerequisite[1]].AddFirst(prerequisite[0]);
                }
                else
                {
                    var ls = new LinkedList<int>();
                    ls.AddFirst(prerequisite[0]);
                    courseDict.Add(prerequisite[1], ls);
                }
            }

            var path = new bool[numCourses];
            var check = new bool[numCourses];

            for (int currCourse = 0; currCourse < numCourses; currCourse++)
            {
                if (IsCyclic(currCourse,courseDict, path, check))
                {
                    return false;
                }
            }

            return true;
        }

        private bool IsCyclic(int currCourse, Dictionary<int, 
            LinkedList<int>> courseDict,
            bool[] path, bool[] check)
        {
            if (check[currCourse])
            {
                return false;
            }

            if (path[currCourse])
            {
                return true;
            }

            if (!courseDict.ContainsKey(currCourse))
            {
                return false;
            }

            path[currCourse] = true;
            var ret = false;
            foreach (var child in courseDict[currCourse])
            {
                ret = IsCyclic(child, courseDict, path, check);
                if (ret)
                {
                    break;
                }
            }

            path[currCourse] = false;
            check[currCourse] = true;
            return ret;
        }
    }
}