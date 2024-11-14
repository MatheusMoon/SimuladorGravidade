namespace SimuladorGravitacional
{
    partial class NewSimForm
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
            labelPlanets = new Label();
            btnStartSim = new Button();
            tBoxqtdPlanet = new TextBox();
            labelInteractions = new Label();
            tBoxqtdInteractions = new TextBox();
            btnBackMainMenu = new Button();
            SuspendLayout();
            // 
            // labelPlanets
            // 
            labelPlanets.AutoSize = true;
            labelPlanets.Location = new Point(311, 57);
            labelPlanets.Name = "labelPlanets";
            labelPlanets.Size = new Size(162, 15);
            labelPlanets.TabIndex = 0;
            labelPlanets.Text = "Informe quantidade Planetas:";
            // 
            // btnStartSim
            // 
            btnStartSim.Location = new Point(351, 182);
            btnStartSim.Name = "btnStartSim";
            btnStartSim.Size = new Size(75, 23);
            btnStartSim.TabIndex = 1;
            btnStartSim.Text = "Começar!";
            btnStartSim.UseVisualStyleBackColor = true;
            btnStartSim.Click += btnStartSim_Click;
            // 
            // tBoxqtdPlanet
            // 
            tBoxqtdPlanet.Location = new Point(311, 75);
            tBoxqtdPlanet.Name = "tBoxqtdPlanet";
            tBoxqtdPlanet.Size = new Size(162, 23);
            tBoxqtdPlanet.TabIndex = 2;
            tBoxqtdPlanet.KeyPress += tBoxqtdPlanet_KeyPress;
            // 
            // labelInteractions
            // 
            labelInteractions.AutoSize = true;
            labelInteractions.Location = new Point(311, 112);
            labelInteractions.Name = "labelInteractions";
            labelInteractions.Size = new Size(172, 15);
            labelInteractions.TabIndex = 3;
            labelInteractions.Text = "Informe quantidade interações:";
            // 
            // tBoxqtdInteractions
            // 
            tBoxqtdInteractions.Location = new Point(311, 130);
            tBoxqtdInteractions.Name = "tBoxqtdInteractions";
            tBoxqtdInteractions.Size = new Size(162, 23);
            tBoxqtdInteractions.TabIndex = 4;
            tBoxqtdInteractions.KeyPress += tBoxqtdInteractions_KeyPress;
            // 
            // btnBackMainMenu
            // 
            btnBackMainMenu.Location = new Point(351, 329);
            btnBackMainMenu.Name = "btnBackMainMenu";
            btnBackMainMenu.Size = new Size(75, 23);
            btnBackMainMenu.TabIndex = 5;
            btnBackMainMenu.Text = "Sair";
            btnBackMainMenu.UseVisualStyleBackColor = true;
            btnBackMainMenu.Click += btnBackMainMenu_Click;
            // 
            // NewSimForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBackMainMenu);
            Controls.Add(tBoxqtdInteractions);
            Controls.Add(labelInteractions);
            Controls.Add(tBoxqtdPlanet);
            Controls.Add(btnStartSim);
            Controls.Add(labelPlanets);
            Name = "NewSimForm";
            Text = "NewSimForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPlanets;
        private Button btnStartSim;
        private TextBox tBoxqtdPlanet;
        private Label labelInteractions;
        private TextBox tBoxqtdInteractions;
        private Button btnBackMainMenu;
    }
}