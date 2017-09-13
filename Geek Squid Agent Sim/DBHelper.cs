using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekSquidAgentSim
{
    public static class DBHelper
    {

        private static List<FirstName> firstNameList = Program.mainDB.FirstNames.ToList();
        private static List<LastName> lastNameList = Program.mainDB.LastNames.ToList();
        private static List<Trait> traitList = Program.mainDB.Traits.ToList();

        //public static void AddClientToDatabase(Client clientToAdd)
        //{
        //    Program.mainDB.Clients.Add(clientToAdd);
        //}

        /// <summary>
        /// Add valid data to Main Database.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataToAdd"></param>
        public static void AddToDatabase<T>(T dataToAdd)
        {
            string dataType = dataToAdd.GetType().Name.ToString();
            //Console.WriteLine("Saving data..." + dataType + " there should be a data type here!");
            switch (dataType)
            {
                case "Client":
                    {
                        Program.mainDB.Clients.Add(dataToAdd as Client);
                        Client clientToAdd = dataToAdd as Client;
                        //Console.WriteLine(clientToAdd.FullName + " has the client ID of " + clientToAdd.ID);
                        Program.mainDB.SaveChanges();
                        break;
                    }
                case "Agent":
                    {
                        Program.mainDB.Agents.Add(dataToAdd as Agent);
                        Program.mainDB.SaveChanges();
                        break;
                    }
                case "Suspect":
                    {
                        Program.mainDB.Suspects.Add(dataToAdd as Suspect);
                        Program.mainDB.SaveChanges();
                        break;
                    }
                default:
                    {
                        // Invalid data type, throw exceptions as needed later on
                        break;
                    }
            }
        }
        /// <summary>
        /// Pull data of the indicated type from Main Database using its ID.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="dataID"></param>
        /// <returns></returns>
        public static T GetFromDatabase<T>(int dataID)
        {
            Type typeParamaterType = typeof(T);
            string dataType = typeParamaterType.Name.ToString();
            //Console.WriteLine("Loadng data..." + dataType + " there should be a data type here!");
            switch (dataType)
            {
                case "Client":
                    {
                        Client data = Program.mainDB.Clients.Find(dataID);
                        //Console.WriteLine("It worked! Client name is " + data.FullName);
                        return (T)Convert.ChangeType(data, typeof(T));
                    }
                case "Agent":
                    {
                        Agent data = Program.mainDB.Agents.Find(dataID);
                        return (T)Convert.ChangeType(data, typeof(T));
                    }
                case "Suspect":
                    {
                        Suspect data = Program.mainDB.Suspects.Find(dataID);
                        return (T)Convert.ChangeType(data, typeof(T));
                    }
                case "FirstName":
                    {
                        FirstName data = Program.mainDB.FirstNames.Find(dataID);
                        return (T)Convert.ChangeType(data, typeof(T));
                    }
                case "LastName":
                    {
                        LastName data = Program.mainDB.LastNames.Find(dataID);
                        return (T)Convert.ChangeType(data, typeof(T));
                    }
                case "Trait":
                    {
                        Trait data = Program.mainDB.Traits.Find(dataID);
                        return (T)Convert.ChangeType(data, typeof(T));
                    }
                default:
                    {
                        // Invalid data type, throw exceptions as needed later on
                        return default(T);
                    }
            }
        }

        public static List<T> GetListFromDatabase<T>()
        {
            Type typeParamaterType = typeof(T);
            string dataType = typeParamaterType.Name.ToString();

            switch (dataType)
            {
                case "Client":
                    {
                        return Program.mainDB.Clients.ToList<Client>() as List<T>;
                    }
                case "Agent":
                    {
                        return Program.mainDB.Agents.ToList<Agent>() as List<T>;
                    }
                case "Suspect":
                    {
                        return Program.mainDB.Suspects.ToList<Suspect>() as List<T>;
                    }
                case "FirstName":
                    {
                        return firstNameList as List<T>;
                    }
                case "LastName":
                    {
                        return lastNameList as List<T>;
                    }
                case "Trait":
                    {
                        return traitList as List<T>;
                    }
                default:
                    {
                        // Invalid data type, throw exceptions as needed later on
                        return default(List<T>);
                    }
            }
        }
    }
}
