using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue 3 items with different priorities and ensure highest priority is dequeued first.
    // Expected Result: "High" should be returned first because it has the highest priority.
    // Defect(s) Found: The loop in Dequeue() didn't check the last element due to incorrect loop boundary.
    public void TestPriorityQueue_HighestPriorityFirst()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Medium", 5);
        priorityQueue.Enqueue("High", 10);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("High", result);
    }

    [TestMethod]
    // Scenario: Two items have the same highest priority; FIFO should decide.
    // Expected Result: "First" should be removed first because it was enqueued before "Second".
    // Defect(s) Found: Used >= in comparison, causing last-in to be removed instead of first-in.
    public void TestPriorityQueue_TieBreakerFIFO()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("First", 7);
        priorityQueue.Enqueue("Second", 7);
        priorityQueue.Enqueue("Third", 5);

        var result = priorityQueue.Dequeue();
        Assert.AreEqual("First", result);
    }

    [TestMethod]
    // Scenario: Ensure Enqueue adds to the back regardless of priority.
    // Expected Result: Order in internal queue after Enqueue calls should be insertion order.
    // Defect(s) Found: None in Enqueue (adds to back correctly).
    public void TestPriorityQueue_AddsToBack()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 1);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 3);

        var queueString = priorityQueue.ToString();
        StringAssert.StartsWith(queueString, "[A (Pri:1), B (Pri:2), C (Pri:3)]");
    }

    [TestMethod]
    // Scenario: Removing from an empty queue should throw InvalidOperationException with correct message.
    // Expected Result: Exception thrown with message "The queue is empty."
    // Defect(s) Found: None — handled correctly.
    public void TestPriorityQueue_EmptyQueueThrows()
    {
        var priorityQueue = new PriorityQueue();

        var ex = Assert.ThrowsException<InvalidOperationException>(() => priorityQueue.Dequeue());
        Assert.AreEqual("The queue is empty.", ex.Message);
    }

    [TestMethod]
    // Scenario: Ensure item is actually removed after Dequeue.
    // Expected Result: After removing "Max", next Dequeue should return the next highest ("Mid").
    // Defect(s) Found: Original code didn't remove item after returning it.
    public void TestPriorityQueue_RemovesItemAfterDequeue()
    {
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("Low", 1);
        priorityQueue.Enqueue("Mid", 5);
        priorityQueue.Enqueue("Max", 10);

        var first = priorityQueue.Dequeue();
        var second = priorityQueue.Dequeue();

        Assert.AreEqual("Max", first);
        Assert.AreEqual("Mid", second);
    }
}