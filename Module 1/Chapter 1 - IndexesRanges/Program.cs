// Indexes and Ranges example

// Define a sample array 

string[] wordsCollection = new string[]
{
    "this","is","my","first","advance", "C#","learning","class","with","Brajesh"
};

// TODO: The index operator provides access to array elements
Console.WriteLine(wordsCollection[1]);

// TODO: The index-from-end operator indexes from the end of a sequence
// (Note that the end is not zero-based, ^1 (^(hat) operator) is the last item)
Console.WriteLine(wordsCollection[^1]);

// TODO: The range operator (..) defines a range (it means you have lower and upper limit)
// (Note: [..] is equal to [L..U] if an array length is U.)
string[] wordRange = wordsCollection[..];
Console.WriteLine($"{string.Join(",", wordRange)}");

string[] wordRange1 = wordsCollection[..^3];
Console.WriteLine($"{string.Join(",", wordRange1)}");

string[] wordRange2 = wordsCollection[2..5];
Console.WriteLine($"{string.Join(",", wordRange2)}");


// TODO: Indexes and ranges can be variables too
Index idx = ^4;
Console.WriteLine(wordsCollection[idx]);

Range rng = 2..^4;
string[] wordRange5 = wordsCollection[rng];
Console.WriteLine($"{string.Join(",", wordRange5)}");



