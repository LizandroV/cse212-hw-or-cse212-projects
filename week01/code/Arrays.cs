public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  
    /// For example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  
    /// Assume that length is a positive integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // Step 1: Create an array of 'length' elements
        double[] multiples = new double[length];

        // Step 2: Loop through the array and calculate multiples
        // The i-th element should be number * (i + 1)
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        // Step 3: Return the array
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  
    /// For example, if the data is List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and amount is 3 then the result is:
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.
    /// This function modifies the original list (in-place).
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // Step 1: Get the last 'amount' elements from the list
        // This will be the new beginning of the list
        List<int> lastPart = data.GetRange(data.Count - amount, amount);

        // Step 2: Get the first part (all items before the rotation point)
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        // Step 3: Clear the original list so we can rebuild it
        data.Clear();

        // Step 4: Add the rotated elements first (lastPart), then the rest (firstPart)
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
