namespace SimuladorGravitacional
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnContinueSim = new Button();
            btnNewSim = new Button();
            btnQuitApp = new Button();
            SuspendLayout();
            // 
            // btnContinueSim
            // 
            btnContinueSim.Location = new Point(299, 82);
            btnContinueSim.Name = "btnContinueSim";
            btnContinueSim.Size = new Size(139, 23);
            btnContinueSim.TabIndex = 0;
            btnContinueSim.Text = "Continuar Simulação";
            btnContinueSim.UseVisualStyleBackColor = true;
            btnContinueSim.Click += button1_Click;
            // 
            // btnNewSim
            // 
            btnNewSim.Location = new Point(299, 126);
            btnNewSim.Name = "btnNewSim";
            btnNewSim.Size = new Size(139, 23);
            btnNewSim.TabIndex = 1;
            btnNewSim.Text = "Nova Simulação";
            btnNewSim.UseVisualStyleBackColor = true;
            btnNewSim.Click += btnNewSim_Click;
            // 
            // btnQuitApp
            // 
            btnQuitApp.Location = new Point(299, 170);
            btnQuitApp.Name = "btnQuitApp";
            btnQuitApp.Size = new Size(139, 23);
            btnQuitApp.TabIndex = 2;
            btnQuitApp.Text = "Sair da Aplicação";
            btnQuitApp.UseVisualStyleBackColor = true;
            btnQuitApp.Click += btnQuitApp_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnQuitApp);
            Controls.Add(btnNewSim);
            Controls.Add(btnContinueSim);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnContinueSim;
        private Button btnNewSim;
        private Button btnQuitApp;
    }
}
