using System;
using Xunit;

public class CollectionSearchTests
{
    [Fact]
    public void FindFirst_ShouldReturnFirstMatchingItem()
    {
        var numbers = new[] { 2, 4, 6, 8 };

        var result = CollectionSearch.FindFirst(
            numbers,
            number => number > 3
        );

        Assert.Equal(4, result);
    }

    [Fact]
    public void FindFirst_NoMatch_ShouldReturnDefaultValue()
    {
        var numbers = new[] { 2, 4, 6 };

        var result = CollectionSearch.FindFirst(
            numbers,
            number => number > 10
        );

        Assert.Equal(0, result);
    }

    [Fact]
    public void FindFirst_ShouldWorkWithStrings()
    {
        var fruits = new[] { "pear", "apple", "apricot" };

        var result = CollectionSearch.FindFirst(
            fruits,
            fruit => fruit.StartsWith(
                "a",
                StringComparison.Ordinal
            )
        );

        Assert.Equal("apple", result);
    }

    [Fact]
    public void FindFirst_NullCollection_ShouldThrowException()
    {
        Assert.Throws<ArgumentNullException>(
            () => CollectionSearch.FindFirst<int>(
                null,
                number => number > 0
            )
        );
    }

    [Fact]
    public void FindFirst_NullPredicate_ShouldThrowException()
    {
        Assert.Throws<ArgumentNullException>(
            () => CollectionSearch.FindFirst(
                new[] { 1, 2, 3 },
                null
            )
        );
    }
}