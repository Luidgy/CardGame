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
		private Carte laCarteJouer;
		private List<Joueur> laListe;
		Random rmd;

		public Tour(Joueur tLeJoueur, Carte laCarte)
        {
            leJoueur = tLeJoueur;
			laCarteJouer = laCarte;
            numTour++;
        }

        public int getNumTour() {return numTour;}

        public void setNumTour(int sNumTour) => numTour = sNumTour;

        public String getNameJoueurDuTour() { return leJoueur.getNomJoueur(); }

		public Carte getCarteJouer(){ return laCarteJouer; }

		

	}
}
