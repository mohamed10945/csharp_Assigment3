namespace generics;

class Program
{
    static void Main(string[] args)
    {

        //Assignment 1: Create a utility class ArrayUtils with generic methods:

        int[] intArray = { 1, 2, 3, 4, 5 };
        ArrayUtils arrayUtils = new ArrayUtils();
        arrayUtils.ReverseArray(intArray);
        Console.WriteLine("Reversed array: " + string.Join(", ", intArray));

    
        double[] doubleArray = { 3.5, 2.1, 9.7, 4.4, 7.9 };
        double max = arrayUtils.FindMax(doubleArray);
        Console.WriteLine("Maximum element: " + max);


        //Assignment 2: generic class Cache<TKey, TValue>


        Cache<int, string> cache = new Cache<int, string>(3);
        cache.Add(1, "One");
        cache.Add(2, "Two");
        cache.Add(3, "Three");
        Console.WriteLine("Get item with key 2: " + cache.Get(2)); 
        cache.Add(4, "Four");
        try
        {
            Console.WriteLine("Get item with key 1: " + cache.Get(1)); 
        }
        catch (KeyNotFoundException e)
        {
            Console.WriteLine(e.Message);
        }
        Console.WriteLine("Get item with key 3: " + cache.Get(3)); 
        cache.Remove(3);
        Console.WriteLine("Get item with key 3: " + cache.Get(3));
    }
}
