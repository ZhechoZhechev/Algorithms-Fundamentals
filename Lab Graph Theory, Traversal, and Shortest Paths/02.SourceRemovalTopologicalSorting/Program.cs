namespace _02.SourceRemovalTopologicalSorting;

using System;
using System.Linq;
using System.Collections.Generic;

internal class Program
{
    private static Dictionary<string, List<string>> graph;
    private static Dictionary<string, int> dependencies;
    static void Main()
    {
        int nodesCount = int.Parse(Console.ReadLine());

        graph = GraphRead(nodesCount);

        dependencies = ExtractDependencies(graph);

        var isLoop = false;
        List<string> sorted = new List<string>();
        while (dependencies.Count > 0)
        {
            var nodeToRemove = dependencies.FirstOrDefault(x => x.Value == 0).Key;

            if (nodeToRemove == null)
            {
                isLoop = true;
                break;
            }

            dependencies.Remove(nodeToRemove);
            sorted.Add(nodeToRemove);

            foreach (var child in graph[nodeToRemove])
            {
                dependencies[child] -= 1;
            }
        }
        if (isLoop)
        {
            Console.WriteLine("Invalid topological sorting");
        }
        else
        {
            Console.WriteLine($"Topological sorting: {string.Join(", ", sorted)}");
        }
    }

    private static Dictionary<string, int> ExtractDependencies(Dictionary<string, List<string>> graph)
    {
        var result = new Dictionary<string, int>();

        foreach (var kvp in graph)
        {
            var node = kvp.Key;
            var children = kvp.Value;

            if (!result.ContainsKey(node))
            {
                result[node] = 0;
            }

            foreach (var child in children)
            {
                if (!result.ContainsKey(child))
                {
                    result[child] = 1;
                }
                else
                {
                    result[child] += 1;
                }
            }
        }

        return result;
    }

    private static Dictionary<string, List<string>> GraphRead(int nodesCount)
    {
        var result = new Dictionary<string, List<string>>();

        for (int i = 0; i < nodesCount; i++)
        {
            var parts = Console.ReadLine()
                .Split("->", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x.Trim())
                .ToArray();

            var node = parts[0];
            if (parts.Length == 1)
            {
                result[node] = new List<string>();
            }
            else
            {
                var children = parts[1].Split(", ").ToList();
                result[node] = children;
            }
        }

        return result;
    }
}
