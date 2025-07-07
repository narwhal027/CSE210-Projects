using Microsoft.Win32.SafeHandles;

class PoliceMan : Person
{
    private string _weapons;
    public PoliceMan(string firstName, string lastName, int age, string weapons, double salary)
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
        _hoursWorked = hours;
    }
    public string GetPoliceManInformation()
    {
        return $"Weapons: {_weapons} : : {GetPersonInformation()}";
    }
    public string GetPersonInformation()
    {
        return $"Weapons: {_weapons} : : {base.GetPersonInformation()}";
    }
}