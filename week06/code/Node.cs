public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1

        if (value == Data)
            return; // Stop if value already exists in the tree

        if (value < Data)
        {
            // Go left if the value is smaller
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value); // Keep going left
        }
        else
        {
            // Go right if the value is bigger
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value); // Keep going right
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (value == Data)
            return true; // Found the value

        if (value < Data)
        {
            // Search left side if smaller
            if (Left is null)
                return false; // Not found
            return Left.Contains(value);
        }
        else
        {
            // Search right side if bigger
            if (Right is null)
                return false; // Not found
            return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // TODO Start Problem 4
        int leftHeight = (Left != null) ? Left.GetHeight() : 0;
        int rightHeight = (Right != null) ? Right.GetHeight() : 0;

        // Height is 1 (this node) + the tallest subtree
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}