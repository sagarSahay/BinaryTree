using System.Collections.Generic;
using System.Linq;

namespace WordLadder
{
    public class Solution
    {
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            var solution = new List<string>();
            var res = new List<List<string>>();
            var neighbours = new Dictionary<string,List<string>>();
            var distance  = new Dictionary<string, int>();
            var dict = new HashSet<string>(wordList);

            foreach (var word in wordList)
            {
                neighbours.Add(word, new List<string>());
            }

            bfs(beginWord, endWord, dict, neighbours, distance);
            
        }

        private void bfs(string beginWord, string endWord, HashSet<string> dict, Dictionary<string,List<string>> neighbours, Dictionary<string,int> distance)
        {
            var queue = new Queue<string>();
            queue.Enqueue(beginWord);
            distance.Add(beginWord, 0);

            while (queue.Count > 0)
            {
                var curr = queue.Dequeue();
                var currentNeighbours = GetNeighbours(curr, dict);
            }
        }

        private List<string> GetNeighbours(string curr, HashSet<string> dict)
        {
            var result = new List<string>();
            var chs = curr.ToCharArray();

            for (char i = 'a'; i <= 'z'; i++)
            {
                foreach (var word in dict)
                {
                    
                }
            }
        }
    }
}