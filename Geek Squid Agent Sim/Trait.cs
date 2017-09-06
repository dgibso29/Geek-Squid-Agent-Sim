using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekSquidAgentSim
{
    class Trait
    {
        public string Name { get; }
        public int TraitID { get; }
        public string Description { get; }
        public int ConflictingTraitID { get; }

        public Trait(int traitID, string name, string description, int conflictingTraitID)
        {
            Name = name;
            TraitID = traitID;
            Description = description;
            ConflictingTraitID = conflictingTraitID;
        }

        /// <summary>
        /// Make sure conflicting traits are not being assigned. Returns true if conflict detected.
        /// </summary>
        /// <param name="traitOne"></param>
        /// <param name="traitTwo"></param>
        /// <returns></returns>
        public static bool CheckForConflict(Trait traitOne, Trait traitTwo)
        {
            if (traitOne.TraitID == traitTwo.ConflictingTraitID || traitTwo.TraitID == traitOne.ConflictingTraitID)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    
}
