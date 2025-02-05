namespace ExercicioAbstratos;

abstract class Persons
{
    public string Name { get; set; }
    public double YearAmount { get; set; }
    
    public Persons() { }
    public Persons(string name, double yearAmount)
    {
        Name = name;
        YearAmount = yearAmount;
    }
    public abstract double TaxCalc();

}
