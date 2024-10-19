
public class ArrayUtils
{
    
    public void ReverseArray<T>(T[] array)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null");
        }

        int length = array.Length;
        for (int i = 0; i < length / 2; i++)
        {
            T temp = array[i];
            array[i] = array[length - i - 1];
            array[length - i - 1] = temp;
        }
    }

    
    public T FindMax<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty", nameof(array));
        }

        T maxElement = array[0];
        foreach (T element in array)
        {
            if (element.CompareTo(maxElement) > 0)
            {
                maxElement = element;
            }
        }

        return maxElement;
    }
}
