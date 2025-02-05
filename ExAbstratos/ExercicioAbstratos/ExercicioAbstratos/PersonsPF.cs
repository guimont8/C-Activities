namespace ExercicioAbstratos;

internal class PersonsPF : Persons
{
    public double HealthExpenses { get; set; }
    public PersonsPF(string name, double yearAmount, double healthExpenses) : base(name, yearAmount)
    {
        HealthExpenses = healthExpenses;
    }
    public override double TaxCalc()
    {
        double tax = (YearAmount > 20000) ? YearAmount * 0.25 : YearAmount * 0.15;
        tax -= HealthExpenses * 0.50;
        return tax < 0 ? 0 : tax; 
    }
}
