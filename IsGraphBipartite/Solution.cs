namespace IsGraphBipartite
{
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public bool IsBipartite(int[][] graph)
        {
            var len = graph.Length;
            var color = new int[len];
        
            for(int i=0; i< len; i++){
                color[i] = -1;
            }
        
            for(int i =0 ; i< len; i++){
                if(color[i] == -1){
                    var stack = new Stack<int>();
                    stack.Push(i);
                    color[i]=0;
                
                    while(stack.Count()!=0){
                        var currIndex = stack.Pop();
                        foreach(int j in graph[currIndex]){
                            if(color[j] == -1){
                                stack.Push(j);
                                color[j] = color[j] ^ 1;
                            }else if(color[currIndex] == color[j]){
                                return false;
                            }
                        }
                    }
                }
            }
        
            return true;
        }
    }
}