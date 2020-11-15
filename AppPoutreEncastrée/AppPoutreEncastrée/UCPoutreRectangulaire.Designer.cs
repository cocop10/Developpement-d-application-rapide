namespace AppPoutreEncastrée
{
    partial class UCPoutreRectangulaire
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_dimensionh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_dimensionb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AppPoutreEncastrée.Properties.Resources.rectangulaire;
            this.pictureBox1.Location = new System.Drawing.Point(29, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 195);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "h (en m) :";
            // 
            // textBox_dimensionh
            // 
            this.textBox_dimensionh.Location = new System.Drawing.Point(313, 108);
            this.textBox_dimensionh.Name = "textBox_dimensionh";
            this.textBox_dimensionh.Size = new System.Drawing.Size(100, 22);
            this.textBox_dimensionh.TabIndex = 4;
            this.textBox_dimensionh.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "b (en m) :";
            // 
            // textBox_dimensionb
            // 
            this.textBox_dimensionb.Location = new System.Drawing.Point(313, 147);
            this.textBox_dimensionb.Name = "textBox_dimensionb";
            this.textBox_dimensionb.Size = new System.Drawing.Size(100, 22);
            this.textBox_dimensionb.TabIndex = 6;
            this.textBox_dimensionb.Text = "0";
            // 
            // UCPoutreRectangulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_dimensionb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_dimensionh);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCPoutreRectangulaire";
            this.Size = new System.Drawing.Size(453, 324);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_dimensionh;
        public System.Windows.Forms.TextBox textBox_dimensionb;
    }
}
