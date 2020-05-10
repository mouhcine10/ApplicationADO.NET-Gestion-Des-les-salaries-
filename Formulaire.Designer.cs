namespace gest
{
    partial class Formulaire
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
            this.textBoxmatricule = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dateTimePicker_fin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_debut = new System.Windows.Forms.DateTimePicker();
            this.comboBox_typec = new System.Windows.Forms.ComboBox();
            this.radioButton_F = new System.Windows.Forms.RadioButton();
            this.radioButton1_H = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_prenom = new System.Windows.Forms.TextBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_site = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBoxmatricule
            // 
            this.textBoxmatricule.Location = new System.Drawing.Point(275, 73);
            this.textBoxmatricule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxmatricule.Name = "textBoxmatricule";
            this.textBoxmatricule.Size = new System.Drawing.Size(149, 22);
            this.textBoxmatricule.TabIndex = 37;
            this.textBoxmatricule.TextChanged += new System.EventHandler(this.textBoxmatricule_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(569, 635);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 37);
            this.button2.TabIndex = 36;
            this.button2.Text = "Fermer";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(400, 635);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 37);
            this.button1.TabIndex = 35;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(583, 496);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(132, 22);
            this.textBox1.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 496);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 17);
            this.label9.TabIndex = 33;
            this.label9.Text = "Nomber des jours";
            // 
            // dateTimePicker_fin
            // 
            this.dateTimePicker_fin.Location = new System.Drawing.Point(665, 352);
            this.dateTimePicker_fin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_fin.Name = "dateTimePicker_fin";
            this.dateTimePicker_fin.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_fin.TabIndex = 32;
            this.dateTimePicker_fin.ValueChanged += new System.EventHandler(this.dateTimePicker_fin_ValueChanged);
            // 
            // dateTimePicker_debut
            // 
            this.dateTimePicker_debut.Location = new System.Drawing.Point(248, 352);
            this.dateTimePicker_debut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_debut.Name = "dateTimePicker_debut";
            this.dateTimePicker_debut.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker_debut.TabIndex = 31;
            this.dateTimePicker_debut.ValueChanged += new System.EventHandler(this.dateTimePicker_debut_ValueChanged);
            // 
            // comboBox_typec
            // 
            this.comboBox_typec.FormattingEnabled = true;
            this.comboBox_typec.Items.AddRange(new object[] {
            "Maladé",
            "matirneté"});
            this.comboBox_typec.Location = new System.Drawing.Point(692, 134);
            this.comboBox_typec.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_typec.Name = "comboBox_typec";
            this.comboBox_typec.Size = new System.Drawing.Size(160, 24);
            this.comboBox_typec.TabIndex = 30;
            // 
            // radioButton_F
            // 
            this.radioButton_F.AutoSize = true;
            this.radioButton_F.Location = new System.Drawing.Point(791, 73);
            this.radioButton_F.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton_F.Name = "radioButton_F";
            this.radioButton_F.Size = new System.Drawing.Size(37, 21);
            this.radioButton_F.TabIndex = 28;
            this.radioButton_F.TabStop = true;
            this.radioButton_F.Text = "F";
            this.radioButton_F.UseVisualStyleBackColor = true;
            // 
            // radioButton1_H
            // 
            this.radioButton1_H.AutoSize = true;
            this.radioButton1_H.Location = new System.Drawing.Point(692, 73);
            this.radioButton1_H.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1_H.Name = "radioButton1_H";
            this.radioButton1_H.Size = new System.Drawing.Size(40, 21);
            this.radioButton1_H.TabIndex = 27;
            this.radioButton1_H.TabStop = true;
            this.radioButton1_H.Text = "M";
            this.radioButton1_H.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(565, 359);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 26;
            this.label8.Text = "Date de din";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(136, 359);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Date de debut ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(579, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Type de congé";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(596, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 23;
            this.label5.Text = "Site";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(592, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sexe";
            // 
            // textBox_prenom
            // 
            this.textBox_prenom.Location = new System.Drawing.Point(264, 197);
            this.textBox_prenom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_prenom.Name = "textBox_prenom";
            this.textBox_prenom.Size = new System.Drawing.Size(160, 22);
            this.textBox_prenom.TabIndex = 21;
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(264, 134);
            this.textBox_Nom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(160, 22);
            this.textBox_Nom.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 201);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Matricule";
            // 
            // comboBox_site
            // 
            this.comboBox_site.FormattingEnabled = true;
            this.comboBox_site.Items.AddRange(new object[] {
            "Lisasfa",
            "Omar Slaoui ",
            "Ain sebaa",
            " "});
            this.comboBox_site.Location = new System.Drawing.Point(692, 191);
            this.comboBox_site.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_site.Name = "comboBox_site";
            this.comboBox_site.Size = new System.Drawing.Size(160, 24);
            this.comboBox_site.TabIndex = 29;
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 801);
            this.Controls.Add(this.textBoxmatricule);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dateTimePicker_fin);
            this.Controls.Add(this.dateTimePicker_debut);
            this.Controls.Add(this.comboBox_typec);
            this.Controls.Add(this.comboBox_site);
            this.Controls.Add(this.radioButton_F);
            this.Controls.Add(this.radioButton1_H);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_prenom);
            this.Controls.Add(this.textBox_Nom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Formulaire";
            this.Text = "Formulaire";
            this.Load += new System.EventHandler(this.Formulaire_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox textBoxmatricule;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.DateTimePicker dateTimePicker_fin;
        public System.Windows.Forms.DateTimePicker dateTimePicker_debut;
        public System.Windows.Forms.ComboBox comboBox_typec;
        public System.Windows.Forms.RadioButton radioButton_F;
        public System.Windows.Forms.RadioButton radioButton1_H;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_prenom;
        public System.Windows.Forms.TextBox textBox_Nom;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox comboBox_site;
    }
}