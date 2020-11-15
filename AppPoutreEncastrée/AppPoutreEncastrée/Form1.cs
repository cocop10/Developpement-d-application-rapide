using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppPoutreEncastrée
{
    public partial class Form1 : Form
    {
        private UCPoutreRectangulaire dimensionRectangulaire;
        private UCPoutreCirculaire dimensionCirculaire;
        private UCPoutreAnnulaire dimensionAnnulaire;

        private clsDataImport dataImport;
        private clsDataExport dataExport;
        private clsCalculPoutre calculPoutre;


        /// <summary>
        /// Initialisation de la form
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            dimensionRectangulaire = new UCPoutreRectangulaire();
            dimensionCirculaire = new UCPoutreCirculaire();
            dimensionAnnulaire = new UCPoutreAnnulaire();

            dataImport = new clsDataImport();
            dataExport = new clsDataExport();
            calculPoutre = new clsCalculPoutre();

            panel_dimension.Controls.Add(dimensionRectangulaire);

            CreerComboBox(comboBox_section, imageList_section);
            comboBox_section.SelectedIndex = 0;
        }

        #region ComboBox 
        private void CreerComboBox(ComboBox comboBox, ImageList imageList)
        {
            string[] img = new string[imageList.Images.Count];
            for (int i = 0; i < imageList.Images.Count; i++)
            {
                img[i] = "Item " + i.ToString();
            }
            comboBox.Items.AddRange(img);
        }

        private void comboBox_section_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index != -1)
            {
                e.Graphics.DrawImage(imageList_section.Images[e.Index], e.Bounds.Left, e.Bounds.Top);
            }
            else
            {
                e.Graphics.DrawImage(imageList_section.Images[0], e.Bounds.Left, e.Bounds.Top);
            }
        }

        private void comboBox_section_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = imageList_section.ImageSize.Height;
            e.ItemWidth = imageList_section.ImageSize.Width;
        }
        #endregion

        

        private void radioButton_module_CheckedChanged(object sender, EventArgs e)
        {
            //choix de selection le module et masquer l'autre
            if (radioButton_module.Checked)
            {
                comboBox_module.Enabled = true;
                radioButton_materiau.Checked = false;
                comboBox_materiau.Enabled = false;
            }
            else
            {
                comboBox_module.Enabled = false;
                radioButton_materiau.Checked = true;
                comboBox_materiau.Enabled = true;
            }
        }

        private void radioButton_materiau_CheckedChanged(object sender, EventArgs e)
        {
            //choix de selection le materiau et masquer l'autre
            if (radioButton_module.Checked)
            {
                comboBox_module.Enabled = true;
                radioButton_materiau.Checked = false;
                comboBox_materiau.Enabled = false;
            }
            else
            {
                comboBox_module.Enabled = false;
                radioButton_materiau.Checked = true;
                comboBox_materiau.Enabled = true;
            }
        }

        private void comboBox_section_SelectedIndexChanged(object sender, EventArgs e)
        {
            //affiche le user controler pour rentrer les dimensions suivant la section choisi
            panel_dimension.Controls.Clear();

            if (comboBox_section.SelectedIndex==0)
            {                
                panel_dimension.Controls.Add(dimensionRectangulaire);
            }
            else if (comboBox_section.SelectedIndex == 1)
            {
                panel_dimension.Controls.Add(dimensionCirculaire);
            }
            else if (comboBox_section.SelectedIndex == 2)
            {
                panel_dimension.Controls.Add(dimensionAnnulaire);
            }
        }

        private void comboBox_module_SelectedIndexChanged(object sender, EventArgs e)
        {
            //obtient le materiau correspondant
            if (comboBox_materiau.SelectedIndex != -1)
            {
                comboBox_materiau.SelectedIndex = comboBox_module.SelectedIndex;
            }
            
        }

        private void comboBox_materiau_SelectedIndexChanged(object sender, EventArgs e)
        {
            //obtient le module correspondant
            if (comboBox_module.SelectedIndex != -1)
            {
                comboBox_module.SelectedIndex = comboBox_materiau.SelectedIndex;
            }
            
        }


        #region Parametre Fichier

        private void button_parametre_Click(object sender, EventArgs e)
        {
            //affiche ou non le panel des fichiers
            if (panel_parametre.Visible)
            {
                panel_parametre.Visible = false;
            }
            else
            {
                panel_parametre.Visible = true;
            }
        }

        private void button_materiau_Click(object sender, EventArgs e)
        {
            //ouvre le dialog
            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //recuperation des donnees
            comboBox_materiau.DataSource = new BindingSource(dataImport.ImportMateriauFromFile(openFileDialog1.FileName).Keys,null);
            comboBox_module.DataSource = new BindingSource(dataImport.ImportMateriauFromFile(openFileDialog1.FileName).Values, null);
            //initialisation des combobox
            comboBox_materiau.SelectedIndex = 0;
            comboBox_module.SelectedIndex = 0;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            //ouvre le dialog
            saveFileDialog1.ShowDialog();
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            //recupere le nom de lacces du fichier
            dataExport.Logfile = saveFileDialog1.FileName;
        }

        #endregion



        private void button_calcul_Click(object sender, EventArgs e)
        {
            //permet de calculer la fleche suivant les inputs rentrés
            try
            {
                double mQuadra = 0;
                string typePoutre = "";
                if (comboBox_section.SelectedIndex == 0)
                {
                    typePoutre = "Rectangulaire";
                    mQuadra = calculPoutre.quadraRectangulaire(double.Parse(dimensionRectangulaire.textBox_dimensionh.Text), double.Parse(dimensionRectangulaire.textBox_dimensionb.Text));
                }
                else if (comboBox_section.SelectedIndex == 1)
                {
                    typePoutre = "Circulaire";
                    mQuadra = calculPoutre.quadraCirculaire(double.Parse(dimensionCirculaire.textBox_dimension1.Text));

                }
                else if (comboBox_section.SelectedIndex == 2)
                {
                    typePoutre = "Annulaire";
                    mQuadra = calculPoutre.quadraAnnulaire(double.Parse(dimensionAnnulaire.textBox_dimension2.Text),double.Parse(dimensionAnnulaire.textBox_dimension1.Text));
                }

                textBox_resultat.Text = calculPoutre.CalculerFleche(double.Parse(textBox_longueur.Text), mQuadra, double.Parse(comboBox_module.Text), double.Parse(textBox_charge.Text)).ToString();


                panel_resultat.Visible = true;
                dataExport.Log(DateTime.Now + " : CalculPoutre : Section " + typePoutre + ", " + textBox_longueur.Text + "m, charge de " + textBox_charge.Text + " kg, Flèche de : " + textBox_resultat.Text +"m.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Warning");
            }
        }

        
        private void button_moment_Click(object sender, EventArgs e)
        {
            //calcul le moment suivant la section choisi, si l'utilisation à bien renseigner les valeurs
            double mQuadra = 0;
            try
            {
                if (comboBox_section.SelectedIndex == 0)
                {

                    mQuadra = calculPoutre.quadraRectangulaire(double.Parse(dimensionRectangulaire.textBox_dimensionh.Text), double.Parse(dimensionRectangulaire.textBox_dimensionb.Text));
                }
                else if (comboBox_section.SelectedIndex == 1)
                {

                    mQuadra = calculPoutre.quadraCirculaire(double.Parse(dimensionCirculaire.textBox_dimension1.Text));

                }
                else if (comboBox_section.SelectedIndex == 2)
                {

                    mQuadra = calculPoutre.quadraAnnulaire(double.Parse(dimensionAnnulaire.textBox_dimension2.Text), double.Parse(dimensionAnnulaire.textBox_dimension1.Text));
                }
                
            }
            catch (Exception)
            {
                mQuadra = 0;
            }
            textBox_moment.Text = mQuadra.ToString();
        }
    }
}
