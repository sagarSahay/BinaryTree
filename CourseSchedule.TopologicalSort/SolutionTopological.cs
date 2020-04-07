namespace CourseSchedule.TopologicalSort
{
    using System.Collections.Generic;

    public class SolutionTopological
    {
        public class GNode
        {
            public int InDegrees = 0;
            public LinkedList<int> Outnodes =new LinkedList<int>();
        }
        public bool CanFinish(int numCourses, int[][] prerequisites)
        {
            if (prerequisites.GetLength(0) == 0)
            {
                return true;
            }
            
            var graph = new Dictionary<int, GNode>();

            foreach (var prerequisite in prerequisites)
            {
                var prevCourse = GetNode(graph, prerequisite[1]);
                var nextCourse = GetNode(graph, prerequisite[0]);

                prevCourse.Outnodes.AddFirst(prerequisite[0]);
                nextCourse.InDegrees += 1;
            }


            var totalDependencies = prerequisites.GetLength(0);
            Stack<int> noDepCourses = new Stack<int>();
            foreach (var pair in graph)
            {
                var node = pair.Value;
                if (node.InDegrees == 0)
                {
                    noDepCourses.Push(pair.Key);
                }
            }

            int removedEdges = 0;
            while (noDepCourses.Count > 0)
            {
                var course = noDepCourses.Pop();

                foreach (var nextCourse in graph[course].Outnodes)
                {
                    var childNode = graph[nextCourse];
                    childNode.InDegrees -= 1;
                    removedEdges += 1;
                    if (childNode.InDegrees == 0)
                    {
                        noDepCourses.Push(nextCourse);
                    }
                }
            }

            if (removedEdges != totalDependencies)
            {
                return false;
            }

            return true;
        }

        private GNode GetNode(Dictionary<int,GNode> graph, int course)
        {
            GNode node = null;
            if (graph.ContainsKey(course))
            {
                node = graph[course];
            }
            else
            {
                node = new GNode();
                graph.Add(course, node);
            }

            return node;
        }
    }
}