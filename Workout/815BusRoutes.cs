namespace Workout;

public static class BusRoutes {
    public static int NumBusesToDestination(int[][] routes, int source, int target)
    {
        if (source == target)
            return 0;
        
        var dict = new Dictionary<int, List<int>>();
        var usedBuses = new HashSet<int>();
        for (int i = 0; i < routes.Length; i++)
        {
            foreach (var stop in routes[i])
            {
                if (!dict.ContainsKey(stop))
                {
                    dict.Add(stop, new List<int>() {i });
                }
                else 
                    dict[stop].Add(i);
            }
        }
        
        int ans = 0;
        var q = new Queue<int>();
        q.Enqueue(source);

        while (q.Count != 0) {
            ++ans;
            for (int sz = q.Count; sz > 0; --sz) {
                foreach (int bus in dict[q.Dequeue()])
                    if (!usedBuses.Contains(bus))
                    {
                        usedBuses.Add(bus);
                        foreach (int stop in routes[bus]) {
                            if (stop == target)
                                return ans;
                            q.Enqueue(stop);
                        }
                    }
            }
        }

        return -1;
    }
}