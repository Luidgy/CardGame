using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCarte
{
    class Tour
    {
        private int numTour = 1;
        private Jeu leJeu;
        private Joueur leJoueur;

        public Tour(Joueur tLeJoueur)
        {
            leJoueur = tLeJoueur;
            numTour++;
        }

        public int getNumTour() {return numTour;}

        public void setNumTour(int sNumTour) => numTour = sNumTour;

        public String getNameJoueurDuTour() { return leJoueur.getNomJoueur(); }

    }
}
