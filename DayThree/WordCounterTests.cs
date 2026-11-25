using Xunit;

public class WordCounterTests
{
    [Fact]
    public void CountOccurrences_ShouldIgnoreCase()
    {
        var result = WordCounter.CountOccurrences(
            "Cat cat CAT",
            "cat"
        );

        Assert.Equal(3, result);
    }

    [Fact]
    public void CountOccurrences_ShouldIgnorePunctuationAtWordBoundaries()
    {
        var result = WordCounter.CountOccurrences(
            "cat, dog! (cat).",
            "cat!"
        );

        Assert.Equal(2, result);
    }

    [Fact]
    public void CountOccurrences_ShouldMatchCompleteWordsOnly()
    {
        var result = WordCounter.CountOccurrences(
            "concatenate cat scatter",
            "cat"
        );

        Assert.Equal(1, result);
    }

    [Fact]
    public void CountOccurrences_ShouldPreserveInternalPunctuation()
    {
        var result = WordCounter.CountOccurrences(
            "co-op coop",
            "coop"
        );

        Assert.Equal(1, result);
    }

    [Theory]
    [InlineData(null, "cat", 0)]
    [InlineData("   ", "cat", 0)]
    [InlineData("cat", null, 0)]
    [InlineData("cat", "  ", 0)]
    public void CountOccurrences_InvalidInput_ShouldReturnZero(
        string? text,
        string? targetWord,
        int expected)
    {
        var result = WordCounter.CountOccurrences(text, targetWord);

        Assert.Equal(expected, result);
    }
}