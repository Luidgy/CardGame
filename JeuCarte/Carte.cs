using System;
using System.Collections.Generic;
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
        


        public Carte(String cValeur, CouleurCarte Ccouleur)
        {           
            nom = cValeur + " " + Ccouleur;
            valeur = cValeur;
            couleur = Ccouleur;
            nbCarte++;
        }

        #region Getters ans setters
        public String getNomcarte()
        {
            return nom;
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

        public void supprimerCarte(Carte c)
        {
            
        }

        #endregion




        

        
    }
}
