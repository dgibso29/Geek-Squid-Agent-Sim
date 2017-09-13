using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekSquidAgentSim
{
    public static class ClientHelper
    {

        static int firstNameCount = Program.mainDB.FirstNames.ToList<FirstName>().Count();
        static int lastNameCount = Program.mainDB.LastNames.ToList<LastName>().Count();

        /// <summary>
        /// Random Client 'constructor,' which will add the new client to the database once complete.
        /// </summary>
        public static void GenerateNewClient()
        {

            Client client = new Client
            {
                ID = Program.mainDB.Clients.ToList<Client>().Count() + 1,
                Gender = RandomizeGender(),
                Age = RandomizeAge(),
                Satisfaction = 100,
                Happiness = 100
            };
            client.FirstName = GenerateFirstName(client.Gender);
            client.LastName = GenerateLastName();
            client.FullName = $"{client.FirstName} {client.LastName}";

            if (client.Gender == "Male")
            {
                client.FormalName = $"Mr. {client.LastName}";
            }
            else if (client.Gender == "Female")
            {
                client.FormalName = $"Ms. {client.LastName}";
            }

            //Console.WriteLine("Client count before adding " + client.FullName + " is " + Program.mainDB.Clients.ToList<Client>().Count());
            List<int> traitIDs = GenerateClientPersonality();
            client.TraitOne = traitIDs[0];
            client.TraitTwo = traitIDs[1];
            client.Membership = "No";
            DBHelper.AddToDatabase(client);
            Program.mainWindow.AddClientToTable(client);
        }

        /// <summary>
        /// Custom Client 'constructor,' which will add the new client to the database once complete.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="gender"></param>
        /// <param name="age"></param>
        /// <returns></returns>
        public static void GenerateNewClient(string firstName, string lastName, string gender, int age)
        {
            // TODO: Randomize all input parameters

            Client client = new Client
            {
                ID = Program.mainDB.Clients.ToList<Client>().Count() + 1,
                FirstName = firstName,
                LastName = lastName,
                FullName = $"{firstName} {lastName}",
                Gender = gender,
                Age = age,
                Satisfaction = 100,
                Happiness = 100
            };
            if (gender == "Male")
            {
                client.FormalName = $"Mr. {lastName}";
            }
            else if(gender == "Female")
            {
                client.FormalName = $"Ms. {lastName}";
            }

            Console.WriteLine("Client count before adding " + client.FullName + " is " + Program.mainDB.Clients.ToList<Client>().Count());
            List<int> traitIDs = GenerateClientPersonality();
            client.TraitOne = traitIDs[0];
            client.TraitTwo = traitIDs[1];
            DBHelper.AddToDatabase(client);            
        }

        /// <summary>
        /// Generate & return client personality traits.
        /// </summary>
        /// <param name="clientID"></param>
        static List<int> GenerateClientPersonality()
        {
            List<int> traitIDs = new List<int>();
            // Generate a random number for each trait, using the current system time as a seed.
            Random RNG = new Random((int)DateTime.Now.ToBinary());
            int traitCount = Program.mainDB.Traits.ToList<Trait>().Count() + 1;
            int randomTraitOne = RNG.Next(1, traitCount);
            int randomTraitTwo = RNG.Next(1, traitCount);

            // Ensure that the traits are not the same, AND that they do not conflict with one another (patient & impatient, for example).
            while(randomTraitOne == randomTraitTwo || CheckForTraitConflict(randomTraitOne, randomTraitTwo))
            {
                randomTraitTwo = RNG.Next(1, traitCount);
            }

            traitIDs.Add(randomTraitOne);
            traitIDs.Add(randomTraitTwo);
            return traitIDs;
        }

        /// <summary>
        /// Check if the given traits conflict. Return true if conflict found.
        /// </summary>
        /// <param name="traitOneID"></param>
        /// <param name="traitTwoID"></param>
        /// <returns></returns>
        static bool CheckForTraitConflict(int traitOneID, int traitTwoID)
        {
            //Console.WriteLine("Checking trait IDs " + traitOneID + " and " + traitTwoID);
            if (DBHelper.GetFromDatabase<Trait>(traitOneID).ConflictingIDs == traitTwoID || DBHelper.GetFromDatabase<Trait>(traitTwoID).ConflictingIDs == traitOneID)
            {
                return true;
            }
            else
                return false;
        }

        static int RandomizeAge()
        {
            Random RNG = new Random((int)DateTime.Now.ToBinary());
            int age = RNG.Next(18, 105);
            return age;
        }

        static string RandomizeGender()
        {
            Random RNG = new Random((int)DateTime.Now.ToBinary());
            int gender = RNG.Next(2);
            if (gender == 0)
            {
                return "Female";
            }
            else
            {
                return "Male";
            }
        }

        static string GenerateFirstName(string gender)
        {
            FirstName firstName;
            int nameID;            
            Random RNG = new Random((int)DateTime.Now.ToBinary());
            nameID = RNG.Next(0, firstNameCount + 1);
            firstName = DBHelper.GetFromDatabase<FirstName>(nameID);
            while (firstName.Gender != gender)
            {
                nameID = RNG.Next(0, firstNameCount + 1);
                firstName = DBHelper.GetFromDatabase<FirstName>(nameID);
            }

            return firstName.Name;
        }

        static string GenerateLastName()
        {
            string lastName;
            int nameID;
            Random RNG = new Random((int)DateTime.Now.ToBinary());
            nameID = RNG.Next(0, lastNameCount + 1);
            lastName = DBHelper.GetFromDatabase<LastName>(nameID).Name;
            return lastName;
        }
    }
}
