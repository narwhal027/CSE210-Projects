class Doctor : Person
{
    private string _tools;
    private double _salary;
    public Doctor(string firstName, string lastName, int age, string tools, double salary)
    : base(firstName, lastName, age)
    {
        _tools = tools;
    }
    public string GetDoctorInformation()
    {
        return $"Tools: {_tools} : : {GetPersonInformation()}";
    }
    public override string GetPersonInformation()
    {
        return $"Tools: {_tools} : : {base.GetPersonInformation()}";
    }
    public override double GetSalary()
    {
        return _salary;
    }
}