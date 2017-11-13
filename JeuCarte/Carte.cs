using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCarte
{
	class Carte
    {
        private String nom;
        private String valeur;
        private CouleurCarte couleur;
        private int nbCarte;
		private string path;


		public Carte(String cValeur, CouleurCarte Ccouleur, string cPath)
        {           
            nom = cValeur + " " + Ccouleur;
            valeur = cValeur;
            couleur = Ccouleur;
			path = cPath;
            nbCarte++;
        }

        #region Getters ans setters
        public String getNomcarte()
        {
            return nom;
        }

		public String getPath()
		{
			return path;
		}

        public String getValeur()
        {
            return valeur;
        }

        public CouleurCarte getCouleurCarte()
        {
            return couleur;
        }

        public int getNbCarte()
        {
            return nbCarte;
        }

        #endregion




        

        
    }
}
