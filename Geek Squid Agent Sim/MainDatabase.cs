using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekSquidAgentSim
{
    static class MainDatabase
    {

        public static List<Client> ClientList = new List<Client>();
        public static List<Trait> TraitList = new List<Trait>();

        static MainDatabase()
        {
            PopulateTraits();
        }
        

#region Traits
        public const int TRAIT_BY_ID_IMPATIENT = 0;
        public const int TRAIT_BY_ID_PATIENT = 1;
        public const int TRAIT_BY_ID_KIND = 2;
        public const int TRAIT_BY_ID_MEAN = 3;

        // Add traits to trait list
        private static void PopulateTraits()
        {
            TraitList.Add(new Trait(TRAIT_BY_ID_IMPATIENT, "Impatient", "Very quick to become frustrated.", TRAIT_BY_ID_PATIENT));
            TraitList.Add(new Trait(TRAIT_BY_ID_PATIENT, "Patient", "Unlikely to be bothered by smaller things.", TRAIT_BY_ID_IMPATIENT));
            TraitList.Add(new Trait(TRAIT_BY_ID_KIND, "Kind", "Very friendly and likeable.", TRAIT_BY_ID_MEAN));
            TraitList.Add(new Trait(TRAIT_BY_ID_MEAN, "Mean", "Unpleasant, uncouth, and vindictive.", TRAIT_BY_ID_KIND));
        }


        public static Trait FindTraitByID(int traitID)
        {
            return TraitList[traitID];
        }


#endregion
    }
}
