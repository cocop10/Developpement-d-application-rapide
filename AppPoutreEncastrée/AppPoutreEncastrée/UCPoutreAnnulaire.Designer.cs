namespace AppPoutreEncastrée
{
    partial class UCPoutreAnnulaire
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_dimension1 = new System.Windows.Forms.TextBox();
            this.textBox_dimension2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPoutreEncastrée.Properties.Resources.annulaire;
            this.pictureBox1.Location = new System.Drawing.Point(29, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_dimension1
            // 
            this.textBox_dimension1.Location = new System.Drawing.Point(307, 105);
            this.textBox_dimension1.Name = "textBox_dimension1";
            this.textBox_dimension1.Size = new System.Drawing.Size(100, 22);
            this.textBox_dimension1.TabIndex = 1;
            this.textBox_dimension1.Text = "0";
            // 
            // textBox_dimension2
            // 
            this.textBox_dimension2.Location = new System.Drawing.Point(307, 161);
            this.textBox_dimension2.Name = "textBox_dimension2";
            this.textBox_dimension2.Size = new System.Drawing.Size(100, 22);
            this.textBox_dimension2.TabIndex = 2;
            this.textBox_dimension2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "d (en m) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "D (en m) :";
            // 
            // UCPoutreAnnulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_dimension2);
            this.Controls.Add(this.textBox_dimension1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCPoutreAnnulaire";
            this.Size = new System.Drawing.Size(453, 324);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_dimension1;
        public System.Windows.Forms.TextBox textBox_dimension2;
    }
}
