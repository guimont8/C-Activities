internal class Program
{
    private static void Main(string[] args)
    {
        int totalStudents = TotalStudents();
        Console.WriteLine("Total Students: " + totalStudents);
    }

    public static int TotalStudents()
    {
        HashSet<int> aluno = new HashSet<int>();

        Console.Write("How many students for course A? ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int idAluno = int.Parse(Console.ReadLine());
            aluno.Add(idAluno);
        }

        Console.Write("How many students for course B? ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int idAluno = int.Parse(Console.ReadLine());
            aluno.Add(idAluno);
        }

        Console.Write("How many students for course C? ");
        n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int idAluno = int.Parse(Console.ReadLine());
            aluno.Add(idAluno);
        }

        return aluno.Count;
    }
}

