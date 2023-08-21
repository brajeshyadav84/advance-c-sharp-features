// Tuples provide an easy, lightweight way of returning multiple values
// from a single function call without defining a complex structure
(string, string, string) GetValues(string EmpId)
{
    // Given a EmpId, return Name, Gender, and Location values
    if (EmpId == "1")
    {
        return ("Brajesh", "Male", "India");
    }
    else if (EmpId == "2")
    {
        return ("Divyansh", "Male", "Singapore");
    }
    else
    {
        return ("Reyansh", "Male", "Malaysia");
    }
}

// Working directly with a tuple can be somewhat tedious, having
// to access each value individually using the ItemN syntax:
var result = GetValues("1");
Console.WriteLine($"{result.Item1}, {result.Item2}, {result.Item3}");


// TODO: An easier way can be accomplished using named values and 
// deconstructing the tuple into variables
var (name, gender, location) = GetValues("2");
Console.WriteLine($"{name}, {gender}, {location}");

// TODO: You can also use explicit variable types, and the _ character can be
// used to ignore any values that you don't plan to use
var (_, _, location) = GetValues("2");
Console.WriteLine($"{location}");

var (_, gender, _) = GetValues("2");
Console.WriteLine($"{gender}");



(string[], int[]) GetCollection()
{
    //TODO: put your business logic
    string[] stringArray = { "this", "is", "cool", "feature" };
    int[] intArray = { 1, 2, 3, 4, 5 };

    return (stringArray, intArray);
}

var resultCollection = GetCollection();
Console.WriteLine(string.Join(",", resultCollection.Item1));
Console.WriteLine(string.Join(",", resultCollection.Item2));
