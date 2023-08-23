// The null coalescing operator

// A common scenario is to test a value for null and assign one if it is
void LogString(string? theString) {
    if (theString == null) {
        Console.WriteLine("No string value!");
    }
    else {
        Console.WriteLine(theString);
    }
}

//LogString("Test String");
//LogString(null);

// TODO: the ?? operator returns the left-hand value if not null, or the right one if it is null
void LogStringOperator(string? theString) {
    Console.WriteLine(theString ?? "No String Value");
}

//LogStringOperator("Brajesh");
//LogStringOperator(null);

// TODO: It's also allowable to throw an exception as part of the right-hand expression
void LogStringException(string? theString) {
    Console.WriteLine(theString ?? throw new ArgumentNullException("theString", "Can not be null"));
}

//LogStringException("Brajesh");
//LogStringException(null);


// TODO: The ??= assigns a value if the left-hand value is null
string name = "Today is Sunday";
name ??= "brajesh";
Console.WriteLine(name);

