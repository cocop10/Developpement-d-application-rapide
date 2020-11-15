using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace AppPoutreEncastrée
{
    class clsDataExport
    {
        private string logfile;

        public clsDataExport()
        {
            //initialise un fichier si l'utilisateur ne l'a pas fait
            logfile = "log.txt";
        }

        //encapsulation, permet de recuperer ou definir ladresse du file
        public string Logfile
        {
            get { return logfile; }
            set { logfile = value; }
        }
        
        
        public void Log(string textToLog)
        {
            //ecriture dans le log
            using (StreamWriter sw = new StreamWriter(logfile, true))
            {
                sw.WriteLine(textToLog);
                sw.Close();
            }
        }
    }
}
