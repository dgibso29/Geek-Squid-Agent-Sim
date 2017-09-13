using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeekSquidAgentSim
{
    public partial class GeekSquidAgentSim : Form
    {
        public GeekSquidAgentSim()
        {
            InitializeComponent();
            //ClientHelper.GenerateNewClient("Neo", "Anderson", "Male", 27);
            //ClientHelper.GenerateNewClient("Agent", "Smith", "Male", 34);
            //Client testClient = DBHelper.GetFromDatabase<Client>(1);
            //Console.WriteLine("Traits = " + Program.mainDB.Traits.ToList<Trait>().Count());
            ////Client testClient = Program.mainDB.Clients.Find(1);
            //if (testClient != null)
            //{
            //    textBoxMessages.Text = $"Test client number one is {testClient.FullName}, and he is both " +
            //        $"{DBHelper.GetFromDatabase<Trait>(testClient.TraitOne).Name} and {DBHelper.GetFromDatabase<Trait>(testClient.TraitTwo).Name}.";
            //}
            //else
            //{
            //    textBoxMessages.Text = Program.mainDB.Clients.ToList<Client>().Count().ToString();
            //}
            //for(int i = 0; i < 50; i++)
            //{
            //    ClientHelper.GenerateNewClient();
            //}
            InitializeClientTable();

        }

        private void InitializeUI()
        {

        }

        private void InitializeClientTable()
        {
            dataGridClients.AutoGenerateColumns = false;
            List<Client> clientList = DBHelper.GetListFromDatabase<Client>();
            foreach (Client c in clientList)
            {
                dataGridClients.Rows.Add(ClientDataToRow(c));
            }           

        }

        /// <summary>
        /// Add new client to Client data grid
        /// </summary>
        /// <param name="c"></param>
        public void AddClientToTable(Client c)
        {
            dataGridClients.Rows.Add(ClientDataToRow(c));
        }

        public void UpdateClientInTable(Client c)
        {
        }

        /// <summary>
        /// Convert Client info into string array for data grid.
        /// </summary>
        /// <param name="client"></param>
        /// <returns></returns>
        private string[] ClientDataToRow(Client c)
        {
            string[] newRow = { c.FullName, "None", c.Membership, c.Satisfaction.ToString(), $"{DBHelper.GetFromDatabase<Trait>(c.TraitOne).Name} & {DBHelper.GetFromDatabase<Trait>(c.TraitTwo).Name}" };
            return newRow;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClientHelper.GenerateNewClient();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBoxActions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {

        }
    }
}
