﻿using System;
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

            MainDatabase.ClientList.Add(new Client("Neo", "Anderson", "Male", 27));
            textBoxMessages.Text = $"Test client number one is {MainDatabase.ClientList[0].FullName}, and his personality traits" +
                $" are {MainDatabase.ClientList[0].TraitOne.Name} and {MainDatabase.ClientList[0].TraitTwo.Name}.";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
    }
}
