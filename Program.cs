using Lab4;

string root = FileRoot.Root;

string csvFile = root + Path.DirectorySeparatorChar + "data.csv";

string psvFile = root + Path.DirectorySeparatorChar + "data.psv";

List<Person> people = new List<Person>();
using (StreamReader sr = new StreamReader(csvFile))
{
    while (!sr.EndOfStream)
    {
        string line = sr.ReadLine();
        var split = line.Split(",");

        // get and store info from file
        var firstName = split[0];
        var lastName = split[1];
        var streetAddress = split[2];
        var city = split[3];
        var state = split[4];
        var postalCode = split[5];

        var address = new Address(streetAddress, city, state, postalCode);
        people.Add(new Person(firstName, lastName, address));

    }

}
Console.WriteLine();

people.Sort();

using (StreamWriter sw = new StreamWriter(psvFile))
{
    foreach(Person p in people)
    {
        string line = p.FirstName + "|" + p.LastName + "|" + p.Address;
        sw.WriteLine(line);
    }
}


