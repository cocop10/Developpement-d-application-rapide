namespace AppPoutreEncastrée
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_longueur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_section = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_moment = new System.Windows.Forms.TextBox();
            this.comboBox_materiau = new System.Windows.Forms.ComboBox();
            this.radioButton_materiau = new System.Windows.Forms.RadioButton();
            this.comboBox_module = new System.Windows.Forms.ComboBox();
            this.radioButton_module = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_charge = new System.Windows.Forms.TextBox();
            this.button_parametre = new System.Windows.Forms.Button();
            this.panel_parametre = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.button_materiau = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_calcul = new System.Windows.Forms.Button();
            this.imageList_section = new System.Windows.Forms.ImageList(this.components);
            this.panel_dimension = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_resultat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_resultat = new System.Windows.Forms.Panel();
            this.button_moment = new System.Windows.Forms.Button();
            this.panel_parametre.SuspendLayout();
            this.panel_resultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Longueur de la poutre L (en m) :";
            // 
            // textBox_longueur
            // 
            this.textBox_longueur.Location = new System.Drawing.Point(253, 27);
            this.textBox_longueur.Name = "textBox_longueur";
            this.textBox_longueur.Size = new System.Drawing.Size(128, 22);
            this.textBox_longueur.TabIndex = 1;
            this.textBox_longueur.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Forme de la section S :";
            // 
            // comboBox_section
            // 
            this.comboBox_section.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBox_section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_section.FormattingEnabled = true;
            this.comboBox_section.ItemHeight = 70;
            this.comboBox_section.Location = new System.Drawing.Point(253, 62);
            this.comboBox_section.Name = "comboBox_section";
            this.comboBox_section.Size = new System.Drawing.Size(128, 76);
            this.comboBox_section.TabIndex = 3;
            this.comboBox_section.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox_section_DrawItem);
            this.comboBox_section.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.comboBox_section_MeasureItem);
            this.comboBox_section.SelectedIndexChanged += new System.EventHandler(this.comboBox_section_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(213, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Moment quadratique I (en m^4) :";
            // 
            // textBox_moment
            // 
            this.textBox_moment.Location = new System.Drawing.Point(252, 181);
            this.textBox_moment.Name = "textBox_moment";
            this.textBox_moment.ReadOnly = true;
            this.textBox_moment.Size = new System.Drawing.Size(128, 22);
            this.textBox_moment.TabIndex = 5;
            this.textBox_moment.Text = "0";
            // 
            // comboBox_materiau
            // 
            this.comboBox_materiau.Enabled = false;
            this.comboBox_materiau.FormattingEnabled = true;
            this.comboBox_materiau.Location = new System.Drawing.Point(253, 256);
            this.comboBox_materiau.Name = "comboBox_materiau";
            this.comboBox_materiau.Size = new System.Drawing.Size(128, 24);
            this.comboBox_materiau.TabIndex = 7;
            this.comboBox_materiau.SelectedIndexChanged += new System.EventHandler(this.comboBox_materiau_SelectedIndexChanged);
            // 
            // radioButton_materiau
            // 
            this.radioButton_materiau.AutoSize = true;
            this.radioButton_materiau.Location = new System.Drawing.Point(34, 259);
            this.radioButton_materiau.Name = "radioButton_materiau";
            this.radioButton_materiau.Size = new System.Drawing.Size(92, 21);
            this.radioButton_materiau.TabIndex = 6;
            this.radioButton_materiau.Text = "Matériau :";
            this.radioButton_materiau.UseVisualStyleBackColor = true;
            this.radioButton_materiau.CheckedChanged += new System.EventHandler(this.radioButton_materiau_CheckedChanged);
            // 
            // comboBox_module
            // 
            this.comboBox_module.FormattingEnabled = true;
            this.comboBox_module.Location = new System.Drawing.Point(253, 216);
            this.comboBox_module.Name = "comboBox_module";
            this.comboBox_module.Size = new System.Drawing.Size(128, 24);
            this.comboBox_module.TabIndex = 9;
            this.comboBox_module.SelectedIndexChanged += new System.EventHandler(this.comboBox_module_SelectedIndexChanged);
            // 
            // radioButton_module
            // 
            this.radioButton_module.AutoSize = true;
            this.radioButton_module.Checked = true;
            this.radioButton_module.Location = new System.Drawing.Point(34, 217);
            this.radioButton_module.Name = "radioButton_module";
            this.radioButton_module.Size = new System.Drawing.Size(214, 21);
            this.radioButton_module.TabIndex = 10;
            this.radioButton_module.TabStop = true;
            this.radioButton_module.Text = "Module d\'Young E (en GPa) :";
            this.radioButton_module.UseVisualStyleBackColor = true;
            this.radioButton_module.CheckedChanged += new System.EventHandler(this.radioButton_module_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Charge appliquée (en kg) :";
            // 
            // textBox_charge
            // 
            this.textBox_charge.Location = new System.Drawing.Point(252, 295);
            this.textBox_charge.Name = "textBox_charge";
            this.textBox_charge.Size = new System.Drawing.Size(128, 22);
            this.textBox_charge.TabIndex = 12;
            this.textBox_charge.Text = "0";
            // 
            // button_parametre
            // 
            this.button_parametre.Location = new System.Drawing.Point(12, 430);
            this.button_parametre.Name = "button_parametre";
            this.button_parametre.Size = new System.Drawing.Size(109, 48);
            this.button_parametre.TabIndex = 13;
            this.button_parametre.Text = "Paramétrage des fichiers";
            this.button_parametre.UseVisualStyleBackColor = true;
            this.button_parametre.Click += new System.EventHandler(this.button_parametre_Click);
            // 
            // panel_parametre
            // 
            this.panel_parametre.Controls.Add(this.label5);
            this.panel_parametre.Controls.Add(this.button_materiau);
            this.panel_parametre.Controls.Add(this.button_save);
            this.panel_parametre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_parametre.Location = new System.Drawing.Point(0, 484);
            this.panel_parametre.Name = "panel_parametre";
            this.panel_parametre.Size = new System.Drawing.Size(890, 133);
            this.panel_parametre.TabIndex = 14;
            this.panel_parametre.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Choix des emplacements :";
            // 
            // button_materiau
            // 
            this.button_materiau.Location = new System.Drawing.Point(251, 47);
            this.button_materiau.Name = "button_materiau";
            this.button_materiau.Size = new System.Drawing.Size(148, 56);
            this.button_materiau.TabIndex = 1;
            this.button_materiau.Text = "Fichier Matériau";
            this.button_materiau.UseVisualStyleBackColor = true;
            this.button_materiau.Click += new System.EventHandler(this.button_materiau_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(52, 47);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(148, 56);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Fichier Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_calcul
            // 
            this.button_calcul.Location = new System.Drawing.Point(282, 342);
            this.button_calcul.Name = "button_calcul";
            this.button_calcul.Size = new System.Drawing.Size(372, 31);
            this.button_calcul.TabIndex = 15;
            this.button_calcul.Text = "Calcul";
            this.button_calcul.UseVisualStyleBackColor = true;
            this.button_calcul.Click += new System.EventHandler(this.button_calcul_Click);
            // 
            // imageList_section
            // 
            this.imageList_section.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_section.ImageStream")));
            this.imageList_section.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_section.Images.SetKeyName(0, "rectangulairelist.jpg");
            this.imageList_section.Images.SetKeyName(1, "circulairelist.jpg");
            this.imageList_section.Images.SetKeyName(2, "annulairelist.jpg");
            // 
            // panel_dimension
            // 
            this.panel_dimension.Location = new System.Drawing.Point(425, 12);
            this.panel_dimension.Name = "panel_dimension";
            this.panel_dimension.Size = new System.Drawing.Size(453, 324);
            this.panel_dimension.TabIndex = 16;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File | *.txt";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // textBox_resultat
            // 
            this.textBox_resultat.Location = new System.Drawing.Point(249, 26);
            this.textBox_resultat.Name = "textBox_resultat";
            this.textBox_resultat.ReadOnly = true;
            this.textBox_resultat.Size = new System.Drawing.Size(128, 22);
            this.textBox_resultat.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Flèche de (en m) :";
            // 
            // panel_resultat
            // 
            this.panel_resultat.Controls.Add(this.textBox_resultat);
            this.panel_resultat.Controls.Add(this.label6);
            this.panel_resultat.Location = new System.Drawing.Point(266, 379);
            this.panel_resultat.Name = "panel_resultat";
            this.panel_resultat.Size = new System.Drawing.Size(441, 71);
            this.panel_resultat.TabIndex = 19;
            this.panel_resultat.Visible = false;
            // 
            // button_moment
            // 
            this.button_moment.Location = new System.Drawing.Point(387, 181);
            this.button_moment.Name = "button_moment";
            this.button_moment.Size = new System.Drawing.Size(32, 23);
            this.button_moment.TabIndex = 20;
            this.button_moment.UseVisualStyleBackColor = true;
            this.button_moment.Click += new System.EventHandler(this.button_moment_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 617);
            this.Controls.Add(this.button_moment);
            this.Controls.Add(this.panel_resultat);
            this.Controls.Add(this.panel_dimension);
            this.Controls.Add(this.button_calcul);
            this.Controls.Add(this.panel_parametre);
            this.Controls.Add(this.button_parametre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_charge);
            this.Controls.Add(this.radioButton_module);
            this.Controls.Add(this.comboBox_materiau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.radioButton_materiau);
            this.Controls.Add(this.comboBox_section);
            this.Controls.Add(this.comboBox_module);
            this.Controls.Add(this.textBox_longueur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_moment);
            this.Name = "Form1";
            this.Text = "Poutre Encastrée";
            this.panel_parametre.ResumeLayout(false);
            this.panel_parametre.PerformLayout();
            this.panel_resultat.ResumeLayout(false);
            this.panel_resultat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_longueur;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_moment;
        private System.Windows.Forms.ComboBox comboBox_materiau;
        private System.Windows.Forms.RadioButton radioButton_materiau;
        private System.Windows.Forms.ComboBox comboBox_module;
        private System.Windows.Forms.RadioButton radioButton_module;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_charge;
        private System.Windows.Forms.Button button_parametre;
        private System.Windows.Forms.Panel panel_parametre;
        private System.Windows.Forms.Button button_materiau;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_calcul;
        private System.Windows.Forms.ImageList imageList_section;
        private System.Windows.Forms.Panel panel_dimension;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.ComboBox comboBox_section;
        private System.Windows.Forms.TextBox textBox_resultat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_resultat;
        private System.Windows.Forms.Button button_moment;
    }
}

