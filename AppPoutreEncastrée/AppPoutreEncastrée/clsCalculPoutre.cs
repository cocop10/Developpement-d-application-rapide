using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPoutreEncastrée
{
    class clsCalculPoutre
    {
        /// <summary>
        /// CalculerFleche renvoie la valeur décimale de la fleche avec les entrées ci-dessous.
        /// </summary>
        /// <param name="longueur"> Longeur poutre</param>
        /// <param name="mQuadra"> Moment Quadratique</param>
        /// <param name="mYoung">Module d'Young dépend du matériau</param>
        /// <param name="charge">Charge appliquée</param>

        public double CalculerFleche(double longueur, double mQuadra, double mYoung, double charge)
        {
            return (charge* 9.8 * Math.Pow(longueur, 3)) / (3 * mYoung * mQuadra);
        }

s

        /// <summary>
        /// Calcul du Moment Quadratique pour une section rectangulaire, Math.Pow est équivalent à ** pour les puissssances
        /// </summary>
        /// <param name="hauteur"></param>
        /// <param name="epaisseur"></param>



        public double quadraRectangulaire(double hauteur, double epaisseur)
        {
            return (epaisseur * Math.Pow(hauteur, 3)) / 12;
        }

        /// <summary>
        /// Moment Quadratique pour une section Circulaire
        /// </summary>
        /// <param name="diametre"></param>
        /// 
        public double quadraCirculaire(double diametre)
        {
            return (Math.PI * Math.Pow(diametre, 4)) / 64;
        }

        /// <summary>
        /// MommentQuadratique pour une section creuse.
        /// </summary>
        /// <param name="diametreExt"></param>
        /// <param name="diametreInt"></param>
        /// 
        public double quadraAnnulaire(double diametreExt, double diametreInt)
        {
            return (Math.PI * (Math.Pow(diametreExt, 4) - Math.Pow(diametreInt, 4))) / 64;
        }
    }
}

