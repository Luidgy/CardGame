using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCarte
{
    class Tour
    {
        private int numTour;
        private Joueur leJoueur;
		private Carte laCarteJouer;


		public Tour()
		{

		}

		public Tour(Joueur tLeJoueur, Carte laCarte, int numT)
        {
            leJoueur = tLeJoueur;
			laCarteJouer = laCarte;
			numTour = numT;
        }

        public int getNumTour() {return numTour;}

		public void setNumTour(int numT)
		{
			numTour = numT;
		}
		
        public String getNameJoueurDuTour() { return leJoueur.getNomJoueur(); }

		public Carte getCarteJouer(){ return laCarteJouer; }

		public Joueur GetJoueur()
		{
			return leJoueur;
		}

	}
}
