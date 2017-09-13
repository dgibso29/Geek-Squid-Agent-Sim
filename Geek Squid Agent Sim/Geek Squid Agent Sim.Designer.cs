namespace GeekSquidAgentSim
{
    partial class GeekSquidAgentSim
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GeekSquidAgentSim));
            this.textBoxMessages = new System.Windows.Forms.RichTextBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataTabs = new System.Windows.Forms.TabControl();
            this.currentClientTab = new System.Windows.Forms.TabPage();
            this.clientsTab = new System.Windows.Forms.TabPage();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.precinctTab = new System.Windows.Forms.TabPage();
            this.contextAction1 = new System.Windows.Forms.Button();
            this.contextAction2 = new System.Windows.Forms.Button();
            this.contextAction3 = new System.Windows.Forms.Button();
            this.contextAction4 = new System.Windows.Forms.Button();
            this.clientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSuspects = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientSatisfaction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientPersonality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.dataTabs.SuspendLayout();
            this.clientsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMessages
            // 
            this.textBoxMessages.Enabled = false;
            this.textBoxMessages.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.textBoxMessages.Location = new System.Drawing.Point(965, 552);
            this.textBoxMessages.Name = "textBoxMessages";
            this.textBoxMessages.ReadOnly = true;
            this.textBoxMessages.Size = new System.Drawing.Size(896, 460);
            this.textBoxMessages.TabIndex = 0;
            this.textBoxMessages.Text = "";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxImage.Image")));
            this.pictureBoxImage.Location = new System.Drawing.Point(40, 65);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(896, 411);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 2;
            this.pictureBoxImage.TabStop = false;
            this.pictureBoxImage.Click += new System.EventHandler(this.pictureBoxImage_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1898, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.Location = new System.Drawing.Point(967, 408);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 68);
            this.button1.TabIndex = 5;
            this.button1.Text = "Generate Client";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.Location = new System.Drawing.Point(1657, 408);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(206, 68);
            this.button4.TabIndex = 5;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button2.Location = new System.Drawing.Point(1197, 408);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 68);
            this.button2.TabIndex = 5;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button3_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button3.Location = new System.Drawing.Point(1427, 408);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(206, 68);
            this.button3.TabIndex = 5;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataTabs
            // 
            this.dataTabs.Controls.Add(this.currentClientTab);
            this.dataTabs.Controls.Add(this.precinctTab);
            this.dataTabs.Controls.Add(this.clientsTab);
            this.dataTabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dataTabs.ItemSize = new System.Drawing.Size(109, 30);
            this.dataTabs.Location = new System.Drawing.Point(965, 36);
            this.dataTabs.Name = "dataTabs";
            this.dataTabs.SelectedIndex = 0;
            this.dataTabs.Size = new System.Drawing.Size(896, 366);
            this.dataTabs.TabIndex = 6;
            // 
            // currentClientTab
            // 
            this.currentClientTab.Location = new System.Drawing.Point(4, 34);
            this.currentClientTab.Name = "currentClientTab";
            this.currentClientTab.Padding = new System.Windows.Forms.Padding(3);
            this.currentClientTab.Size = new System.Drawing.Size(888, 328);
            this.currentClientTab.TabIndex = 0;
            this.currentClientTab.Text = "Current Client";
            this.currentClientTab.UseVisualStyleBackColor = true;
            // 
            // clientsTab
            // 
            this.clientsTab.Controls.Add(this.dataGridClients);
            this.clientsTab.Location = new System.Drawing.Point(4, 34);
            this.clientsTab.Name = "clientsTab";
            this.clientsTab.Padding = new System.Windows.Forms.Padding(3);
            this.clientsTab.Size = new System.Drawing.Size(888, 328);
            this.clientsTab.TabIndex = 1;
            this.clientsTab.Text = "Clients";
            this.clientsTab.UseVisualStyleBackColor = true;
            // 
            // dataGridClients
            // 
            this.dataGridClients.AllowUserToAddRows = false;
            this.dataGridClients.AllowUserToDeleteRows = false;
            this.dataGridClients.AllowUserToOrderColumns = true;
            this.dataGridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientName,
            this.clientSuspects,
            this.membershipStatus,
            this.clientSatisfaction,
            this.clientPersonality});
            this.dataGridClients.Location = new System.Drawing.Point(3, 6);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.ReadOnly = true;
            this.dataGridClients.RowTemplate.Height = 28;
            this.dataGridClients.ShowEditingIcon = false;
            this.dataGridClients.Size = new System.Drawing.Size(879, 321);
            this.dataGridClients.TabIndex = 0;
            // 
            // precinctTab
            // 
            this.precinctTab.Location = new System.Drawing.Point(4, 34);
            this.precinctTab.Name = "precinctTab";
            this.precinctTab.Size = new System.Drawing.Size(888, 328);
            this.precinctTab.TabIndex = 2;
            this.precinctTab.Text = "Precinct";
            this.precinctTab.UseVisualStyleBackColor = true;
            // 
            // contextAction1
            // 
            this.contextAction1.BackColor = System.Drawing.Color.SteelBlue;
            this.contextAction1.FlatAppearance.BorderSize = 0;
            this.contextAction1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.contextAction1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.contextAction1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contextAction1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.contextAction1.ForeColor = System.Drawing.Color.White;
            this.contextAction1.Location = new System.Drawing.Point(40, 552);
            this.contextAction1.Name = "contextAction1";
            this.contextAction1.Size = new System.Drawing.Size(895, 91);
            this.contextAction1.TabIndex = 7;
            this.contextAction1.Text = "contextAction1";
            this.contextAction1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contextAction1.UseVisualStyleBackColor = false;
            // 
            // contextAction2
            // 
            this.contextAction2.BackColor = System.Drawing.Color.SteelBlue;
            this.contextAction2.FlatAppearance.BorderSize = 0;
            this.contextAction2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.contextAction2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.contextAction2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contextAction2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.contextAction2.ForeColor = System.Drawing.Color.White;
            this.contextAction2.Location = new System.Drawing.Point(40, 675);
            this.contextAction2.Name = "contextAction2";
            this.contextAction2.Size = new System.Drawing.Size(895, 91);
            this.contextAction2.TabIndex = 7;
            this.contextAction2.Text = "contextAction2";
            this.contextAction2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contextAction2.UseVisualStyleBackColor = false;
            // 
            // contextAction3
            // 
            this.contextAction3.BackColor = System.Drawing.Color.SteelBlue;
            this.contextAction3.FlatAppearance.BorderSize = 0;
            this.contextAction3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.contextAction3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.contextAction3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contextAction3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.contextAction3.ForeColor = System.Drawing.Color.White;
            this.contextAction3.Location = new System.Drawing.Point(40, 798);
            this.contextAction3.Name = "contextAction3";
            this.contextAction3.Size = new System.Drawing.Size(895, 91);
            this.contextAction3.TabIndex = 7;
            this.contextAction3.Text = "contextAction3";
            this.contextAction3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contextAction3.UseVisualStyleBackColor = false;
            // 
            // contextAction4
            // 
            this.contextAction4.BackColor = System.Drawing.Color.SteelBlue;
            this.contextAction4.FlatAppearance.BorderSize = 0;
            this.contextAction4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.contextAction4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.contextAction4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contextAction4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.contextAction4.ForeColor = System.Drawing.Color.White;
            this.contextAction4.Location = new System.Drawing.Point(40, 921);
            this.contextAction4.Name = "contextAction4";
            this.contextAction4.Size = new System.Drawing.Size(895, 91);
            this.contextAction4.TabIndex = 7;
            this.contextAction4.Text = "contextAction4";
            this.contextAction4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.contextAction4.UseVisualStyleBackColor = false;
            // 
            // clientName
            // 
            this.clientName.FillWeight = 2F;
            this.clientName.HeaderText = "Name";
            this.clientName.MinimumWidth = 100;
            this.clientName.Name = "clientName";
            this.clientName.ReadOnly = true;
            this.clientName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // clientSuspects
            // 
            this.clientSuspects.FillWeight = 1F;
            this.clientSuspects.HeaderText = "Suspects";
            this.clientSuspects.MinimumWidth = 45;
            this.clientSuspects.Name = "clientSuspects";
            this.clientSuspects.ReadOnly = true;
            this.clientSuspects.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clientSuspects.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // membershipStatus
            // 
            this.membershipStatus.FillWeight = 1F;
            this.membershipStatus.HeaderText = "Member";
            this.membershipStatus.MinimumWidth = 45;
            this.membershipStatus.Name = "membershipStatus";
            this.membershipStatus.ReadOnly = true;
            // 
            // clientSatisfaction
            // 
            this.clientSatisfaction.FillWeight = 1F;
            this.clientSatisfaction.HeaderText = "Satisfaction";
            this.clientSatisfaction.MinimumWidth = 45;
            this.clientSatisfaction.Name = "clientSatisfaction";
            this.clientSatisfaction.ReadOnly = true;
            // 
            // clientPersonality
            // 
            this.clientPersonality.FillWeight = 3F;
            this.clientPersonality.HeaderText = "Personality";
            this.clientPersonality.MinimumWidth = 150;
            this.clientPersonality.Name = "clientPersonality";
            this.clientPersonality.ReadOnly = true;
            // 
            // GeekSquidAgentSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.contextAction4);
            this.Controls.Add(this.contextAction3);
            this.Controls.Add(this.contextAction2);
            this.Controls.Add(this.contextAction1);
            this.Controls.Add(this.dataTabs);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.textBoxMessages);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "GeekSquidAgentSim";
            this.Text = "Geek Squad Agent Sim";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dataTabs.ResumeLayout(false);
            this.clientsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxMessages;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabControl dataTabs;
        private System.Windows.Forms.TabPage currentClientTab;
        private System.Windows.Forms.TabPage clientsTab;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.TabPage precinctTab;
        private System.Windows.Forms.Button contextAction1;
        private System.Windows.Forms.Button contextAction2;
        private System.Windows.Forms.Button contextAction3;
        private System.Windows.Forms.Button contextAction4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSuspects;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientSatisfaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientPersonality;
    }
}

