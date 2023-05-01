using System.Text;
using TestCreatAquivoCsv.PersonRepositories;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Buscar  as pessoas");
        var people = PersonRepository.GetPeople();
        StringBuilder sb = new StringBuilder();
        Console.WriteLine("Montar arquivo");
        sb.AppendLine("Nome;CPF");
        people.ForEach(x => sb.AppendLine($"{x.Name};{x.Document}"));
        var filePath = @"C:\Users\mubar\OneDrive - EDU - Organização Educacional Barão de Mauá\Documentos\Visual Studio 2022\TestCreatAquivoCsv\Pessoa.csv";
        Console.WriteLine("Salvando arquivo");
        File.WriteAllText(filePath, sb.ToString());
        Console.ReadKey();
    }
}