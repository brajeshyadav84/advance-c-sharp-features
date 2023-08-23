// Using Deconstruction on a custom defined type

// Create some classes with data
var p = new Person("John", "Quincy", "Adams", "Boston", "MA");


// TODO: Use Deconstruction to get the fname and lname
//var (fName, lName) = p;
//Console.WriteLine($"Hello {fName} {lName}");


// TODO: Use Deconstruction to get the all details
var (fName, lName, city, _) = p;
Console.WriteLine($"Hello {fName} {lName} of {city}!");
