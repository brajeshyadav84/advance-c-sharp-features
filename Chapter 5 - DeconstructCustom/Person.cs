// Using Deconstruction on a custom defined type

public class Person
{
    public string FirstName { get; set; }
    public string MiddleName { get; set; }
    public string LastName { get; set; }
    public string City { get; set; }
    public string State { get; set; }

    public Person(string fname, string mname, string lname,
                  string cityName, string stateName)
    {
        FirstName = fname;
        MiddleName = mname;
        LastName = lname;
        City = cityName;
        State = stateName;
    }

    // TODO: Define a Deconstruct method to return the fname and lname
    public void Deconstruct(out string fname, out string lname)
    {
        fname = FirstName;
        lname = LastName;
    }

    // TODO: Define a Deconstruct method to return the fname, mname and lname
    public void Deconstruct(out string fname, out string lname,
                            out string city, out string state)
    {
        fname = FirstName;
        lname = LastName;
        city = City;
        state = State;
    }


    // TODO: Defining a Deconstruct with the name number of parameters will cause an error
     public void Deconstruct(out string fnameData, out string city)
     {
         fnameData = FirstName;
         city = City;
     }

}