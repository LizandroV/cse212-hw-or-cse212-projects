public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
       // 1: Create 'length' array of doubles
        double[] multiples = new double[length];

        // 2: Fill the array with the multiples
        for (int i = 0; i < length; i++)
        {
            // 3: Each element is the multiple of the number
            multiples[i] = number * (i + 1);
        }

        // 4: Return the array
        return multiples;
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // 1: Obtain the last 'amount' elements
        List<int> lastPart = data.GetRange(data.Count - amount, amount);

        // 2: Obtain the rest elements
        List<int> firstPart = data.GetRange(0, data.Count - amount);

        // 3: Clear the list
        data.Clear();

        // 4: Add the latest
        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}
