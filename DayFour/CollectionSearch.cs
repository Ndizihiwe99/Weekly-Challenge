//                        Find the First Matching Item


//                          Make the tests pass

// Today's exercise focuses on generics, delegates, collections, 
// and exception handling. 


//                             Scenario

// You are building a reusable collection utility. Other developers should be able 
// to search through a collection and retrieve the first item that satisfies a condition.

//                            Requirements

// 1. Search through the collection in its original order.
// 2. Return the first item for which the predicate returns `true`.
// 3. If no item matches, return `default(T)`.
// 4. Throw `ArgumentNullException` if either `items` or `predicate` is null.

#nullable enable

using System;
using System.Collections.Generic;
using Xunit.Abstractions;

public static class CollectionSearch
{
    public static T? FindFirst<T>(IEnumerable<T>? items, Func<T, bool>? predicate)
    {
        if(items == null ||predicate == null)
        {
            throw new ArgumentNullException("no null allowed");
        }
        foreach(T? item in items)
        {
            if (predicate(item))
            {
                return item;
            }
        }
        return default;

        throw new NotImplementedException(
            "Implement this method."
        );
    }
}