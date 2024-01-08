
namespace InterceptingEvents;

internal class Program
{
    private static List<int[]> events;
    static void Main()
    {
        events = new List<int[]>{
            new int[]{0, 13},
            new int[]{2, 5},
            new int[]{4, 6},
            new int[]{5, 9},
            new int[]{8, 14},
            new int[]{11, 12},
            new int[]{15, 20}
        };

        var sortedEvents = events.OrderBy(x => x[1]).ToList();

        var result = PickNotInterceptingEvents(sortedEvents);

        Console.WriteLine("Selected non-intercepting events:");
        foreach (var selection in result)
        {
            Console.WriteLine($"Strating: {selection[0]}, ending: {selection[1]}");
        }

    }

    private static List<int[]> PickNotInterceptingEvents(List<int[]> sortedEvents)
    {
        var result = new List<int[]>
        {
            sortedEvents[0]
        };

        int resultIdx = 0;
        int sortedIdx = 0;

        while (sortedIdx < sortedEvents.Count)
        {
            if (result[resultIdx][1] <= sortedEvents[sortedIdx][0])
            {
                result.Add(sortedEvents[sortedIdx]);
                resultIdx ++;
                sortedIdx ++;
            }
            else
            {
                sortedIdx ++;
            }
        }

        return result;
    }
}
