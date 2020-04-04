using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Threading;

namespace WordLadder
{
    using System;

    public class Solution
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var solution = new List<string>();
            var res = new List<List<string>>();
            var neighbours = new Dictionary<string, List<string>>();
            var distance = new Dictionary<string, int>();
            var dict = new HashSet<string>(wordList);
            dict.Add(beginWord);

            foreach (var word in wordList)
            {
                neighbours.Add(word, new List<string>());
            }
            neighbours.Add(beginWord, new List<string>());

            bfs(beginWord, endWord, dict, neighbours, distance);
            dfs(beginWord, endWord, dict, neighbours, distance, solution, res);
            res.OrderBy(x => x.Count);
            if (res.Count > 0)
            {
                return res[0].Count;
            }

            return 0;
        }

        private void dfs(
            string beginWord,
            string endWord,
            HashSet<string> dict,
            Dictionary<string, List<string>> neighbours,
            Dictionary<string, int> distance,
            List<string> solution,
            List<List<string>> res)
        {
           solution.Add(beginWord);
           if (beginWord == endWord)
           {
               res.Add(new List<string>(solution));
           }
           else
           {
               foreach (var neighbour in neighbours[beginWord])
               {
                   if (distance[neighbour] == distance[beginWord] + 1)
                   {
                       dfs(neighbour, endWord, dict,neighbours,distance,solution,res);
                   }
               }
           }
           solution.RemoveAt(solution.Count - 1);
        }

        private void bfs(string beginWord, string endWord, HashSet<string> dict,
            Dictionary<string, List<string>> neighbours, Dictionary<string, int> distance)
        {
            var queue = new Queue<string>();
            queue.Enqueue(beginWord);
            distance.Add(beginWord, 0);

            while (queue.Count > 0)
            {
                var count = queue.Count;
                bool foundEnd = false;

                for (int i = 0; i < count; i++)
                {
                    var curr = queue.Dequeue();
                    var currDistance = distance[curr];
                    var currentNeighbours = GetNeighbours(curr, dict);
                    foreach (var currentNeighbour in currentNeighbours)
                    {
                        neighbours[curr].Add(currentNeighbour);
                        if (!distance.ContainsKey(currentNeighbour))
                        {
                            distance.Add(currentNeighbour, currDistance + 1);
                            if (currentNeighbour == endWord)
                            {
                                foundEnd = true;
                            }
                            else
                            {
                                queue.Enqueue(currentNeighbour);
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

        private List<string> GetNeighbours(string curr, HashSet<string> dict)
        {
            var result = new List<string>();
            var chs = curr.ToCharArray();

            for (char i = 'a'; i <= 'z'; i++)
            {
                for (int j = 0; j < chs.Length; j++)
                {
                    if (chs[j] == i) continue;
                    var old_ch = chs[j];
                    chs[j] = i;
                    if (dict.Contains(new string(chs)))
                    {
                        result.Add(new string(chs));
                    }

                    chs[j] = old_ch;
                }
            }

            return result;
        }
    }
}