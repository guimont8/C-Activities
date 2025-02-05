namespace ExercicioAbstratos;

internal class PersonsPJ : Persons
{
    public int Employees { get; set; }
    public PersonsPJ() { }
    public PersonsPJ(string name, double yearAmount, int employees) : base(name, yearAmount)
    {
        Employees = employees;
    }
    public override double TaxCalc()
    {
        return Employees > 10 ? YearAmount * 0.14 : YearAmount * 0.16;
    }
}
