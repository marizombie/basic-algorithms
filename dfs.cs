using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
        var graph = new Dictionary<int, List<int>> {
            {10, new List<int>{8, 13}},
            {8, new List<int>{3, 9}},
            {13, new List<int>{15}},
            {3, new List<int>()},
            {9, new List<int>()},
            {15, new List<int>()},
        };

		var visited = new HashSet<int>();

        Dfs(graph, visited, 10, 9);
	}
		
	public static int Dfs(Dictionary<int, List<int>> graph, HashSet<int> visited, int node, int goal)
	{
		if (visited.Contains(node)) {return int.MinValue;}
		
        Console.WriteLine(node);
        if (node == goal)
        {
            Console.WriteLine("Found goal!");
            return node;
        }
		
        visited.Add(node);
        foreach (var neighbor in graph[node])
        {
            var res = Dfs(graph, visited, neighbor, goal);
            if (res != int.MinValue)
            {
                return res;
            }
        }
        return int.MinValue;
    }
}
