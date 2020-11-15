using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace AppPoutreEncastrée
{
    class clsDataImport
    {

        /// <summary>
        /// Méthode d'import de données à partir d'un fichier, vers un dictionnaire de strings
        /// </summary>
        /// <param name="fileToImport">Adresse du fichier à importer</param>
        /// <returns>le Dictionnaire de données</returns>
        public Dictionary<string, int> ImportMateriauFromFile(string fileToImport)
        {
            //Dictionnaire qui stockera les données importées
            Dictionary<string, int> ImportDictionary = new Dictionary<string, int>();

            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader(fileToImport))
                {
                    ///Variable temporaire pour stocker chaque ligne lue
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Découpage de la ligne lue selon le séparateur ";"
                        //Le résultat est un tableau de deux strings: [materiau,young]
                        string[] materiauAndYoung = line.Split(':');
                        //On ajoute un nouveau materiau-young dans le dictionary
                        //le materiau en key, le young en value, dans le dictionnaire
                        ImportDictionary.Add(materiauAndYoung[0], int.Parse(materiauAndYoung[1]));



                    }
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                // Let the user know what went wrong.
                MessageBox.Show(ex.Message, "The file could not be read!");
                
            }
            return ImportDictionary;
        }
    }
}
