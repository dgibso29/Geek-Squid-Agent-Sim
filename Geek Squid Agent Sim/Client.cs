using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekSquidAgentSim
{
    class Client
    {
        public string FirstName { get; }
        public string LastName { get; }
        public string FullName { get; }
        public string Gender { get; }
        /// <summary>
        /// Formal manner of addressing client (Ex. 'Mr. Anderson').
        /// </summary>
        public string FormalName { get; }
        public int Age { get; }
        public Trait TraitOne { get; }
        public Trait TraitTwo { get; }
        /// <summary>
        /// Client's long-term satisfaction with the Geek Squid.
        /// </summary>
        public int Satisfaction { get; }
        /// <summary>
        /// Client's 
        /// </summary>
        public int Happiness { get; }


        public Client(string firstName, string lastName, string gender, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            FullName = $"{FirstName} {LastName}";
            Gender = gender;
            if(Gender == "Male")
            {
                FormalName = $"Mr. {LastName}";
            }
            else
            {
                FormalName = $"Ms. {LastName}";
            }
            Age = age;
            var traitList = GenerateClientPersonality();
            TraitOne = traitList[0];
            TraitTwo = traitList[1];
        }

        List<Trait> GenerateClientPersonality()
        {
            List<Trait> traits = new List<Trait>();
            // Generate a random number for each trait, using the current system time as a seed.
            Random RNG = new Random((int)DateTime.Now.ToBinary());
            int randomTraitOne = RNG.Next(MainDatabase.TraitList.Count);
            int randomTraitTwo = RNG.Next(MainDatabase.TraitList.Count);
            // Ensure that the traits are not the same, AND that they do not conflict with one another (patient & impatient, for example).
            while(randomTraitOne == randomTraitTwo && !(Trait.CheckForConflict(MainDatabase.TraitList[randomTraitOne], MainDatabase.TraitList[randomTraitTwo])))
            {
                randomTraitTwo = RNG.Next(MainDatabase.TraitList.Count);
            }
            traits.Add(MainDatabase.FindTraitByID(randomTraitOne));
            traits.Add(MainDatabase.FindTraitByID(randomTraitTwo));

            return traits;
        }
    }
}
