
//                             Print Job Queue


// Today's challenge focuses on collections, FIFO behavior,
//  nullable reference types, and exception handling.

//                                Scenario

// A company has a printer shared by several employees. 
// When employees submit documents, the printer must process 
// them in the order they were received.

//                             Requirements

// 1. `AddJob` must add a job to the queue. Job names must not be null, 
//     empty, or whitespace; otherwise, throw `ArgumentException`.
// 2. Remove leading and trailing whitespace from valid job names before storing them.
// 3. `ProcessNext` must return and remove the oldest job (FIFO).
// 4. If there are no jobs, `ProcessNext` must return `null`.
// 5. `PendingCount` must always represent the number of jobs waiting to be processed.

#nullable enable

using System;
using System.Collections.Generic;

public class PrintJobQueue
{
    private readonly Queue<string> _jobs = new();

    public void AddJob(string jobName)
    {
        if(string.IsNullOrEmpty(jobName) || string.IsNullOrWhiteSpace(jobName))
        throw new ArgumentNullException("You can't add empty name");

        String cleaned = jobName.Trim();

        _jobs.Enqueue(cleaned);
    }

    public string? ProcessNext()
    {
        if(_jobs.Count == 0)
        return null;

        return _jobs.Dequeue();
    }

    public int PendingCount => _jobs.Count;
}