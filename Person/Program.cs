class Program
{
    public static void Main(string[] args)
    {
        Person myPerson = new Person("Bubba", "Bob", 53);
        Console.WriteLine(myPerson.GetPersonInformation());
        PoliceMan myPoliceMan = new PoliceMan("Cooper", "Silver", 34, "Club");
        Console.WriteLine(myPoliceMan.GetPersonInformation());
        Console.WriteLine(myPoliceMan.GetPoliceManInformation());
        Doctor myDoctor = new Doctor("Hodgins", "Smith", 40, "Stethescope");
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
    private static void DisplayPersonInformation(Person person)
    {
        Console.WriteLine(person.GetPersonInformation());
    }
}