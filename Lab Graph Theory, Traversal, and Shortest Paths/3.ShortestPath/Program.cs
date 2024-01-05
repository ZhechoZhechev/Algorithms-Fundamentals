namespace _03.ShortestPath
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    internal class Program
    {
        private static List<int>[] graph;
        private static bool[] visited;
        private static int[] parent;
        static void Main()
        {
            var nodesCount = int.Parse(Console.ReadLine()!);
            var edgesCount = int.Parse(Console.ReadLine()!);

            graph = new List<int>[nodesCount + 1];
            visited = new bool[graph.Length];

            parent = new int[graph.Length];
            Array.Fill(parent, -1);

            for (int i = 0; i < graph.Length; i++)
            {
                graph[i] = new List<int>();
            }

            for (int i = 0; i < edgesCount; i++)
            {
                var edge = Console.ReadLine()
                    .Split()
                    .Select(x => int.Parse(x))
                    .ToArray();

                var firstNode = edge[0];
                var secondNode = edge[1];

                graph[firstNode].Add(secondNode);
                graph[secondNode].Add(firstNode);
            }

            var start = int.Parse(Console.ReadLine()!);
            var end = int.Parse(Console.ReadLine()!);

            BFS(start, end);
        }

        private static void BFS(int startNode, int destination)
        {
            var queue = new Queue<int>();
            queue.Enqueue(startNode);

            visited[startNode] = true;

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                if (node == destination)
                {
                    var path = GetPath(destination);
                    path.Reverse();

                    Console.WriteLine($"Shortest path length is: {path.Count - 1}");
                    Console.WriteLine($"{string.Join(" ",path)}");

                    break;
                }

                foreach (var child in graph[node])
                {
                    if (!visited[child])
                    {
                        parent[child] = node;
                        queue.Enqueue(child);
                        visited[child] = true;
                    }
                }
            }
        }

        private static List<int> GetPath(int destination)
        {
            var path = new List<int>();

            var idx = destination;

            while (idx != -1)
            {
                path.Add(idx);
                idx = parent[idx];
            }

            return path;
        }
    }
}
