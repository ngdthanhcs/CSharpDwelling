namespace Workout;

public class RandomizedSet
{
    /*private Dictionary<int, int> counter;
    private HashSet<int> set;

    public RandomizedSet() {
        counter = new Dictionary<int, int>();
        set = new HashSet<int>();
    }
    
    public bool Insert(int val)
    {
        return set.Add(val);
    }
    
    public bool Remove(int val) {
        if (!set.Contains(val)) return false;
        
        set.Remove(val);
        return true;

    }
    
    public int GetRandom() {
        var rand = new Random();

        return set.ElementAt(rand.Next(set.Count));
    }*/
    
    private readonly Random random = new Random();
    private readonly IDictionary < int, int> locations;
    private readonly IList<int> nums;

    public RandomizedSet()
    {
        locations = new Dictionary < int, int>();
        nums = new List<int>();
    }

    public bool Insert(int val)
    {
        if (locations.ContainsKey(val)) return false;
        locations.Add(val, nums.Count);
        nums.Add(val);
        return true;
    }
    
    public bool Remove(int val)
    {
        if (!locations.ContainsKey(val)) return false;
        if (locations[val] != nums.Count - 1)
        {
            nums[locations[val]] = nums[^1];
            locations[nums[^1]] = locations[val];
        }

        locations.Remove(val);
        nums.RemoveAt(nums.Count - 1);
        return true;
    }
    
    public int GetRandom()
    {
        var index = random.Next(nums.Count);
        return nums[index];
    }
}