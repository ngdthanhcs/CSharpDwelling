namespace Workout;

public static class BusRoutes {
    public static int NumBusesToDestination(int[][] routes, int source, int target)
    {
        /*if (source == target)
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

        return -1;*/
        
        // -bellman ford
        if (source == target) {
            return 0;
        }
        var maxStop = routes.SelectMany(route => route).Max();
        if (maxStop < target) {
            return -1;
        }
        var n = routes.Length;
        var minBusesToReach = new int[maxStop + 1];
        Array.Fill(minBusesToReach, n + 1);
        minBusesToReach[source] = 0;
        var flag = true;
        while (flag) {
            flag = false;
            foreach (var route in routes) {
                var min = route.Select(stop => minBusesToReach[stop]).Min();
                min++;
                foreach (var stop in route)
                {
                    if (minBusesToReach[stop] <= min) continue;
                    minBusesToReach[stop] = min;
                    flag = true;
                }
            }
            
        }
        return (minBusesToReach[target] < n + 1 ? minBusesToReach[target] : -1);
    }
}