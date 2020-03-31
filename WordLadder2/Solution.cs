namespace WordLadder2
{
    using System.Collections.Generic;

    public class Solution
    {
        public IList<IList<string>> Findladders(string beginWord, string endWord, List<string> wordList)
        {
            HashSet<string> dict = new HashSet<string>(wordList);
            List<IList<string>> res = new List<IList<string>>();
            
            Dictionary<string, List<string>> nodeNeighbours = new Dictionary<string, List<string>>();
            Dictionary<string, int> distance = new Dictionary<string, int>();
            List<string> solution = new List<string>();

            dict.Add(beginWord);
            bfs(beginWord, endWord, dict, nodeNeighbours, distance);
            dfs(beginWord, endWord, dict, nodeNeighbours, distance, solution, res);
            return res;
        }

        private void dfs(string beginWord, string endWord, HashSet<string> dict, Dictionary<string,List<string>> nodeNeighbours, Dictionary<string,int> distance, List<string> solution, List<IList<string>> res)
        {
            solution.Add(beginWord);
            if (endWord == beginWord)
            {
                res.Add(new List<string>(solution));
            }
            else
            {
                foreach (var next in nodeNeighbours[beginWord])
                {
                    if (distance[next] == distance[beginWord] + 1)
                    {
                        dfs(next, endWord, dict, nodeNeighbours, distance, solution, res);
                    }
                }
            }
            solution.RemoveAt(solution.Count - 1);
            
        }

        private void bfs(string beginWord, string endWord,
            HashSet<string> dict, Dictionary<string,List<string>> nodeNeighbours, 
            Dictionary<string,int> distance)
        {
            foreach (var str in dict)
            {
                nodeNeighbours.Add(str, new List<string>());
            }
            Queue<string> queue = new Queue<string>();
            
            queue.Enqueue(beginWord);
            distance.Add(beginWord, 0);

            while (queue.Count != 0)
            {
                int count = queue.Count;
                bool foundEnd = false;
                for (int i = 0; i < count; i++)
                {
                    var curr = queue.Dequeue();
                    var currDistance = distance[curr];
                    var neighbours = getNeighbours(curr, dict);

                    foreach (var neighbour in neighbours)
                    {
                        nodeNeighbours[curr].Add(neighbour);
                        if (!distance.ContainsKey(neighbour))
                        {
                            distance.Add(neighbour, currDistance + 1);
                            if (endWord == neighbour)
                            {
                                foundEnd = true;
                            }
                            else
                            {
                                queue.Enqueue(neighbour);
                            }
                        }
                    }

                    if (foundEnd)
                    {
                        break;
                    }
                }
            }
        }

        private List<string> getNeighbours(string node
            , HashSet<string> dict)
        {
           List<string> res = new List<string>();
           var chs = node.ToCharArray();

           for (char ch = 'a'; ch <= 'z'; ch++)
           {
               for (int i = 0; i < chs.Length; i++)
               {
                   if(chs[i] == ch) continue;
                   char oldCh = chs[i];
                   chs[i] = ch;
                   if (dict.Contains(new string(chs)))
                   {
                       res.Add(new string(chs));
                   }

                   chs[i] = oldCh;
               }
           }

           return res;
        }
    }
}