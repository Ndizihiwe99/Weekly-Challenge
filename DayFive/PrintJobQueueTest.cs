//             Testing requirement

// Use xUnit to write at least three tests covering:

// - Processing jobs in FIFO order.
// - Processing an empty queue.
// - Rejecting an invalid job name.


using Xunit;

public class PrintJobQueueTest
{
    [Fact]
    public void TestAddJoB()
    {
        PrintJobQueue printJobQueue = new PrintJobQueue();

        printJobQueue.AddJob("welding");
        printJobQueue.AddJob("plumbing");
        printJobQueue.AddJob("stealing");
        printJobQueue.AddJob("catchingThievies");


        Assert.Equal("welding", printJobQueue.ProcessNext());
    
    }

    [Fact]
    public void Test_Empty_Queue()
    {
        PrintJobQueue printJobQueue = new PrintJobQueue();

        Assert.Null(printJobQueue.ProcessNext());
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData(" ")]
    public void Invalid_Job_Name(string? name)
    {
        var printJobQueue = new PrintJobQueue();
        Assert.Throws<ArgumentNullException>(() => printJobQueue.AddJob(name));
        Assert.Equal(0, printJobQueue.PendingCount);
    }

   
}