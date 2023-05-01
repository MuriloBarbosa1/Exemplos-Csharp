using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestCreatAquivoCsv.Models;

namespace TestCreatAquivoCsv.PersonRepositories
{
    public static class PersonRepository
    {
        public static List<PersonModels> GetPeople()
        {
            return new List<PersonModels>
            {
                new PersonModels
                {
                    Document ="688.414.350-97",
                    Name="João"
                },
                new PersonModels
                {
                    Document = "397.402.898-60",
                    Name = "Luiza"
                },
                new PersonModels
                {
                    Document = "392.936.418-28",
                    Name = "Murilo"
                }
            };
        }
    }
}
