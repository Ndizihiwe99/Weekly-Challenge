//                   Word Occurrence Counter

//                        Scenario

// build a small text-processing utility. It needs to count 
// how many times a particular word appears in a sentence or paragraph.

// the task is to complete `WordCounter.CountOccurrences` 
// so that the supplied tests pass.

//                      Requirements

// 1. Split the input text into words using whitespace as the separator.
// 2. Count only complete word matches, not partial matches.
// 3. Matching must be case-insensitive.
// 4. Ignore the punctuation characters `. , ! ? ; : ( ) [ ]` 
// when they appear at the beginning or end of a word.
// 5. Return `0` if the text is null, empty, or whitespace, 
// or if the target word is null, empty, or whitespace.

// For this exercise, punctuation inside a word is not removed. 
// For example, `co-op` and `coop` are different words.

using System;

public static class WordCounter
{
    
    public static int CountOccurrences(string? text, string? targetWord)
    {
        char[] punctuation = ['.', ',', '!' ,'?', ';' ,':','(',')' , '[',']'];

        if(string.IsNullOrWhiteSpace(text) || string.IsNullOrEmpty(text))
        return 0;

        string[]? words = text?.Split(' ');
        string? target = targetWord?.Trim(punctuation);

        int count = 0;
        foreach(string word in words)
        {
            string cleaned = word.Trim(punctuation);

            if(string.Equals(target, cleaned, StringComparison.OrdinalIgnoreCase))
            {
                count++;
            }
            
        }

        return count;
    }
}