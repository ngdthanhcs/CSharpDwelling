using System.ComponentModel;

namespace Workout;

public class DesignGraphWithShortestPathCalculator {
    // -- naive djikstra
    /*private int[][] graph;
    private int n;
    private const int INF = 0x3f3f3f3f;
    public Graph(int n, int[][] edges) {
        this.graph = new int[n][];
        this.n = n;
        for (int i = 0; i < n; i++){
            graph[i] = new int[n];
            Array.Fill(graph[i], INF);
        }

        foreach (int[] edge in edges){
            graph[edge[0]][edge[1]] = edge[2];
        }
    }

    public void AddEdge(int[] edge) {
        graph[edge[0]][edge[1]] = edge[2];
    }

    public int ShortestPath(int node1, int node2) {
        int[] dist = new int[n];
        Array.Fill(dist, INF);
        bool[] st = new bool[n];
        dist[node1] = 0;
        for (int i = 0; i < n; i++){
            int t = -1;
            for (int j = 0; j < n; j++){
                if (!st[j] && (t == -1 || dist[j] < dist[t])){
                    t = j;
                }
            }

            st[t] = true;
            for (int j = 0; j < n; j++){
                dist[j] = Math.Min(dist[j], dist[t] + graph[t][j]);
            }
        }

        return dist[node2] == INF ? -1 : dist[node2];
    }*/
    
    //-- heap optimized djikstra
    /*private int[][] graph;
    private int n;
    private const int INF = 0x3f3f3f3f;
    public Graph(int n, int[][] edges) {
        this.graph = new int[n][];
        this.n = n;
        for (int i = 0; i < n; i++){
            graph[i] = new int[n];
            Array.Fill(graph[i], INF);
        }

        foreach (int[] edge in edges){
            graph[edge[0]][edge[1]] = edge[2];
        }
    }

    public void AddEdge(int[] edge) {
        graph[edge[0]][edge[1]] = edge[2];
    }

    public int ShortestPath(int node1, int node2) {
        int[] dist = new int[n];
        Array.Fill(dist, INF);
        bool[] st = new bool[n];
        dist[node1] = 0;
        PriorityQueue<int[], int> queue = new PriorityQueue<int[], int>(); 
        queue.Enqueue(new int[2] {0, node1}, 0);
        while (queue.Count > 0){
            var t = queue.Dequeue();
            int ver = t[1];
            if (st[ver]) continue;
            st[ver] = true;
            for (int i = 0; i < n; i++){
                if (dist[i] > dist[ver] + graph[ver][i]){
                    dist[i] = dist[ver] + graph[ver][i];
                    queue.Enqueue(new int[2] {dist[i], i}, dist[i]);
                }
            }
        }

        return dist[node2] == INF ? -1 : dist[node2];
    }*/
    
    //--floyd
    private int[][] dist;
    private int n;
    private const int INF = 0x3f3f3f3f;
    public DesignGraphWithShortestPathCalculator(int n, int[][] edges) {
        this.dist = new int[n][];
        this.n = n;
        for (int i = 0; i < n; i++){
            dist[i] = new int[n];
            Array.Fill(dist[i], INF);
            dist[i][i] = 0;
        }

        foreach (int[] edge in edges){
            dist[edge[0]][edge[1]] = edge[2];
        }

        for (int k = 0; k < n; k++){
            for (int i = 0; i < n; i++){
                for (int j = 0; j < n; j++){
                    dist[i][j] = Math.Min(dist[i][j], dist[i][k] + dist[k][j]);
                }
            }
        }
    }

    public void AddEdge(int[] edge) {
        if (edge[2] > dist[edge[0]][edge[1]]) return;
        for (int i = 0; i < n; i++){
            for (int j = 0; j < n; j++){
                dist[i][j] = Math.Min(dist[i][j], dist[i][edge[0]] + edge[2] + dist[edge[1]][j]);
            }
        }
    }

    public int ShortestPath(int node1, int node2) {
        return dist[node1][node2] == INF ? -1 : dist[node1][node2];
    }
}

/**
 * Your Graph object will be instantiated and called as such:
 * Graph obj = new Graph(n, edges);
 * obj.AddEdge(edge);
 * int param_2 = obj.ShortestPath(node1,node2);
 */