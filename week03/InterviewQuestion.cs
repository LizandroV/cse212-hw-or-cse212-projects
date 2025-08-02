// Describe how you would write a function to find the intersection of two sets. 
// Your solution should NOT use the built-in intersection method.
List<int> Intersect(List<int> list1, List<int> list2)
{
    List<int> result = new List<int>();

    foreach (int number in list1)
    {
        if (list2.Contains(number) && !result.Contains(number))
        {
            result.Add(number);
        }
    }

    return result;
}

// The Big O performance.
// Using .Contains() inside a loop makes this O(n × m) in the worst case.
Intersect([1, 2, 3], [2, 3, 4]); // => [2, 3]
Intersect([5, 6], [1, 2]); // => []
Intersect([], [1, 2]); // => []


// Describe how you would write a function to find the union of two sets. 
// Your solution should NOT use the built-in union method.
List<int> Union(List<int> list1, List<int> list2)
{
    List<int> result = new List<int>();

    foreach (int number in list1)
    {
        if (!result.Contains(number))
        {
            result.Add(number);
        }
    }

    foreach (int number in list2)
    {
        if (!result.Contains(number))
        {
            result.Add(number);
        }
    }

    return result;
}


// The Big O performance.
// .Contains() is used in loops, this solution is O(n²).
Union([1, 2, 3], [3, 4, 5]); // => [1, 2, 3, 4, 5]
Union([1, 1, 2], [2, 3]); //  => [1, 2, 3]
Union([], [7, 8]); //  => [7, 8]