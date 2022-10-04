using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
        var tree = new Dictionary<int, List<int>> {
            {10, new List<int>{8, 13}},
            {8, new List<int>{3, 9}},
            {13, new List<int>{15}},
            {3, new List<int>()},
            {9, new List<int>()},
            {15, new List<int>()},
        };
		
        Bfs(tree, 10, 9);
	}
		
	public static int Bfs(Dictionary<int, List<int>> tree, int rootNode, int goal)
	{
		var visited = new List<int>();
		var queue = new Queue<int>();
		
		visited.Add(rootNode);
		queue.Enqueue(rootNode);

		while(queue.Count > 0)
        {
			var node = queue.Dequeue();
			Console.WriteLine(node.ToString() + " ");
			if (node == goal)
			{            
				Console.WriteLine("\nFound goal");
				return node;
			}

			foreach(var neighbor in tree[node])
            {
				if (!visited.Contains(neighbor))
                {
					visited.Add(neighbor);
					queue.Enqueue(neighbor);
                }
            }
        }
		return -1;
	}
}