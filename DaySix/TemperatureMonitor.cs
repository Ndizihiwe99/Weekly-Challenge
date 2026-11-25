//                Temperature Alert System



// Today's challenge focuses on **delegates, events, and event subscription**.
// It introduces a practical use of the `Action<T>` delegate and the `event` keyword.

//                              Scenario

// You are developing a temperature monitoring system for a server room. 
// When the temperature exceeds a configured threshold, the system must notify
// all registered listeners.

//                             Requirements

// 1. The monitor receives its temperature threshold through its constructor.
// 2. When a recorded temperature is strictly greater than the threshold, 
// raise the `ThresholdExceeded` event.
// 3. Pass the actual recorded temperature to all event subscribers.
// 4. Do not raise the event when the temperature is equal to or below the threshold.
// 5. Recording a temperature must work even when no subscribers have registered.

#nullable enable

using System;

public class TemperatureMonitor
{
    private readonly int _threshold;

    public event Action<int>? ThresholdExceeded;

    public TemperatureMonitor(int threshold)
    {
        _threshold = threshold;
    }

    public void RecordTemperature(int temperature)
    {
        
    }
}