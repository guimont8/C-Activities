using System.Globalization;
using ExercicioAbstratos;

List<Persons> list = new List<Persons>();
Console.Write("Enter the number of tax payers: ");
int payers = int.Parse(Console.ReadLine());

for (int i = 1 ; i <= payers ; i++)
{
    Console.WriteLine($"Tax payer #{i} data:");
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Anual income: ");
    double income = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Individual or company (i/c): ");
    char type = char.Parse(Console.ReadLine().ToLower());
    if(type == 'i')
    {
        Console.Write("Health expenditures: ");
        double healthIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new PersonsPF(name, income, healthIncome));
    }
    else if(type == 'c')
    {
        Console.Write("Number of employees: ");
        int employeesNumber = int.Parse(Console.ReadLine());
        list.Add(new PersonsPJ(name, income, employeesNumber));
    }

}
Console.WriteLine("\nTAXES PAID:");
double totalTaxes = 0.0;

foreach (var person in list)
{
    double tax = person.TaxCalc();
    Console.WriteLine($"{person.Name}: $ {tax.ToString("F2", CultureInfo.InvariantCulture)}");
    totalTaxes += tax;
}
