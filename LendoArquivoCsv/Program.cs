using LendoArquivoCsv.PersonModel;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        var path = @"C:\\Users\\mubar\\OneDrive - EDU - Organização Educacional Barão de Mauá\\Documentos\\Visual Studio 2022\\LendoArquivoCsv\\Pessoa.csv";
        var reader = new StreamReader(File.OpenRead(path));
        var line = reader.ReadLine();
        var columns = line.Split(";");
        (int indexName, int indexDocument) = SetColumnsIndex(columns);
        var people = BuildPeopleList(reader, indexName, indexDocument); 

        foreach ( var person in people)
        {
            Console.WriteLine($"Nome: {person.Name}/ CPF: {person.Document}");
        }
    }

    private static(int,int) SetColumnsIndex(string[] columns)
    {
        Console.WriteLine("Pegando as posiçõs ");
        int indexName = -1;
        int indexDocument = -1;
        for (int i = 0; i < columns.Length; i++) 
        {
            if (string.IsNullOrEmpty(columns[i]))
            continue;

            if (columns[i].ToLower()=="nome")
            {
                indexName = i;
                Console.WriteLine($"Posição da coluna Nome: {indexName}");
            }

            if (columns[i].ToLower()=="cpf")
            {
                indexDocument = i;
                Console.WriteLine($"Posição da coluna CPF: {indexDocument}");
            }
        }
        return(indexName,indexDocument);
    }

    private static List<PersonModel> BuildPeopleList(StreamReader reader, int indexName, int indexDocument)
    {
        Console.WriteLine("Montando lista de pessoas");
        string line;
        var people= new List<PersonModel>();
        PersonModel personModel;

        while((line = reader.ReadLine()) != null)
        {
            var values=line.Split(';');
            personModel= new PersonModel();

            if(indexName != -1)
                personModel.Name = values[indexName];

            if (indexDocument != -1)
                personModel.Document= values[indexDocument];


            people.Add(personModel);
        }
        return people; 
        
    }
    
}