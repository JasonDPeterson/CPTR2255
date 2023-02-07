using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LAIRSLib
{

    public class DnDLib
    {
        public readonly List<string> FemaleElfNames = new List<string>
        {
            "Firlia",
            "Kyrrha",
            "Raerauntha",
            "Andriel",
            "Taeriel",
            "Doreah",
            "Teharissa",
            "Daenestra",
            "Holone",
            "Gaylia"
        };

        public readonly List<string> MaleElfNames = new List<string>
        {
            "Halor",
            "Curuthir",
            "Nesterin",
            "Arandir",
            "Thalien",
            "Laelithar",
            "Usunaar",
            "Larethian",
            "Aelorothi",
            "Tehlmar"
        };

        public readonly List<string> FemaleHumanNames = new List<string>
        {
            "Olivia",
            "Emma",
            "Charlotte",
            "Amelia",
            "Ava",
            "Sophia",
            "Isabella",
            "Mia",
            "Evelyn",
            "Harper"        
        };

        public readonly List<string> MaleHumanNames = new List<string>
        {
            "Liam",
            "Noah",
            "Oliver",
            "Elijah",
            "James",
            "William",
            "Benjamin",
            "Lucas",
            "Henry",
            "Theodore"
        };

        public string GenerateMaleHumanName()
        {
            Random random = new Random();
            return MaleHumanNames[random.Next(10)];
        }

        public string GenerateFemaleHumanName()
        {
            Random random = new Random();
            return FemaleHumanNames[random.Next(10)];
        }

        public string GenerateMaleElfName()
        {
            Random random = new Random();
            return MaleHumanNames[random.Next(10)];
        }

        public string GenerateFemaleElfName()
        {
            Random random = new Random();
            return FemaleHumanNames[random.Next(10)];
        }
    }
}
