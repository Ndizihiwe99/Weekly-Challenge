using System.Collections.Generic;
using Xunit;

public class TemperatureMonitorTests
{
    [Fact]
    public void RecordTemperature_AboveThreshold_ShouldRaiseEvent()
    {
        var monitor = new TemperatureMonitor(30);
        int receivedTemperature = 0;

        monitor.ThresholdExceeded += temperature =>
        {
            receivedTemperature = temperature;
        };

        monitor.RecordTemperature(35);

        Assert.Equal(35, receivedTemperature);
    }

    [Theory]
    [InlineData(30)]
    [InlineData(25)]
    public void RecordTemperature_AtOrBelowThreshold_ShouldNotRaiseEvent(
        int temperature)
    {
        var monitor = new TemperatureMonitor(30);
        bool eventRaised = false;

        monitor.ThresholdExceeded += _ =>
        {
            eventRaised = true;
        };

        monitor.RecordTemperature(temperature);

        Assert.False(eventRaised);
    }

    [Fact]
    public void RecordTemperature_MultipleReadings_ShouldNotifyForEachExceededReading()
    {
        var monitor = new TemperatureMonitor(30);
        var receivedTemperatures = new List<int>();

        monitor.ThresholdExceeded += receivedTemperatures.Add;

        monitor.RecordTemperature(31);
        monitor.RecordTemperature(35);
        monitor.RecordTemperature(28);

        Assert.Equal(new[] { 31, 35 }, receivedTemperatures);
    }

    [Fact]
    public void RecordTemperature_MultipleSubscribers_ShouldNotifyAll()
    {
        var monitor = new TemperatureMonitor(30);

        int firstSubscriber = 0;
        int secondSubscriber = 0;

        monitor.ThresholdExceeded += temperature =>
        {
            firstSubscriber = temperature;
        };

        monitor.ThresholdExceeded += temperature =>
        {
            secondSubscriber = temperature;
        };

        monitor.RecordTemperature(40);

        Assert.Equal(40, firstSubscriber);
        Assert.Equal(40, secondSubscriber);
    }

    [Fact]
    public void RecordTemperature_NoSubscribers_ShouldNotThrow()
    {
        var monitor = new TemperatureMonitor(30);

        var exception = Record.Exception(
            () => monitor.RecordTemperature(40)
        );

        Assert.Null(exception);
    }
}