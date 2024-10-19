public class Cache<TKey, TValue>
{
    private readonly int maxSize;
    private readonly Dictionary<TKey, TValue> cacheMap;


    public Cache(int mSize)
    {
        if (mSize <= 0)
        {
            throw new ArgumentException("Cache size must be greater than zero.", nameof(maxSize));
        }

        maxSize = mSize;
        cacheMap = new Dictionary<TKey, TValue>();
    }

    public void Add(TKey key, TValue value)
    {
        if (cacheMap.ContainsKey(key))
        {

            cacheMap[key] = value;
        }
        else
        {
     
            if (cacheMap.Count >= maxSize)
            {
              
                Console.WriteLine("not enough space in cache");
                return;
            }

            cacheMap[key] = value;

        }
    }

 
    public TValue Get(TKey key)
    {
        if (cacheMap.ContainsKey(key))
        {
            return cacheMap[key];
        }
        else
        {
            throw new KeyNotFoundException($"Key '{key}' not found in cache.");
        }
    }

    
    public void Remove(TKey key)
    {
        if (cacheMap.ContainsKey(key))
        {
            cacheMap.Remove(key);

        }else{

            throw new KeyNotFoundException($"Key '{key}' not found in cache.");
        }
    }

  
}
