using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCarte
{
    class Jeu
    {
        Random rmd = new Random();
        List<Carte> listCartesPioche = new List<Carte>(); // Liste des cartes dans la pioche
        Dictionary<Joueur, List<Carte>> jeuDuJoueur;
        List<Carte> listeCarteJ;
		List<Joueur> listeJoueur;
        List<Carte> carteDuJoueur = new List<Carte>();



        public Jeu(List<Joueur> lesJoueurs)
        {
            melangerCarte();
            genererPioche();
            listeJoueur = melangeListe(lesJoueurs);
            attribuerCarteJoueur(lesJoueurs);
        }

        public void Jouer(Dictionary<Joueur, List<Carte>> jeuJ)
        {
           
        }

        /// <summary>
        /// Génère les Huits cartes du joueur
        /// </summary>
        public List<Carte> genererCarteJoueur()
        {
            listeCarteJ = new List<Carte>();
            
            
            foreach (Carte carteHasard in listCartesPioche.GetRange(0, listCartesPioche.Count))
            {
                listCartesPioche.Sort((x, y) => rmd.Next(-1, 2));
                listeCarteJ.Add(carteHasard);
                supprimerCarte(carteHasard);
                if (listeCarteJ.Count == 8)
                    break;
                
            }
            return listeCarteJ;
        }

        public void attribuerCarteJoueur(List<Joueur> j)
        {
            jeuDuJoueur = new Dictionary<Joueur, List<Carte>>();
            melangerCarte();
            foreach (Joueur jou in listeJoueur)
            {
                melangerCarte();
                List<Carte> monDeck = new List<Carte>();
                monDeck = genererCarteJoueur();
                jeuDuJoueur.Add(jou, listeCarteJ);
            }
        }

        /// <summary>
		/// Supprime la carte rentrée en paramètre
		/// </summary>
		/// <param name="maCarte"></param>
        public void supprimerCarte(Carte maCarte)
        {
            listCartesPioche.Remove(maCarte);
        }

        /// <summary>
        /// Retourne les cartes du joueur rentré en paramètre
        /// </summary>
        /// <param name="j"></param>
        /// <returns></returns>
        public List<Carte> getCarteJoueur(Joueur j)
        {
            
            foreach (var entry in jeuDuJoueur)
            {
                if (entry.Key.Equals(j))
                {
                    carteDuJoueur = entry.Value;
                }
            }
            return carteDuJoueur;
        }

		/// <summary>
		/// Génère la pioche
		/// </summary>
        public void genererPioche()
        {
            for (int i = 2; i <= 10; i++)
            {
                listCartesPioche.Add(new Carte(i.ToString(), CouleurCarte.Coeur));
                listCartesPioche.Add(new Carte(i.ToString(), CouleurCarte.Carreau));
                listCartesPioche.Add(new Carte(i.ToString(), CouleurCarte.Pique));
                listCartesPioche.Add(new Carte(i.ToString(), CouleurCarte.Trèfle));
            }

            listCartesPioche.Add(new Carte(ValeurCartes.Valet.ToString(), CouleurCarte.Coeur));
            listCartesPioche.Add(new Carte(ValeurCartes.Valet.ToString(), CouleurCarte.Carreau));
            listCartesPioche.Add(new Carte(ValeurCartes.Valet.ToString(), CouleurCarte.Pique));
            listCartesPioche.Add(new Carte(ValeurCartes.Valet.ToString(), CouleurCarte.Trèfle));

            listCartesPioche.Add(new Carte(ValeurCartes.Dame.ToString(), CouleurCarte.Coeur));
            listCartesPioche.Add(new Carte(ValeurCartes.Dame.ToString(), CouleurCarte.Carreau));
            listCartesPioche.Add(new Carte(ValeurCartes.Dame.ToString(), CouleurCarte.Pique));
            listCartesPioche.Add(new Carte(ValeurCartes.Dame.ToString(), CouleurCarte.Trèfle));

            listCartesPioche.Add(new Carte(ValeurCartes.Roi.ToString(), CouleurCarte.Coeur));
            listCartesPioche.Add(new Carte(ValeurCartes.Roi.ToString(), CouleurCarte.Carreau));
            listCartesPioche.Add(new Carte(ValeurCartes.Roi.ToString(), CouleurCarte.Pique));
            listCartesPioche.Add(new Carte(ValeurCartes.Roi.ToString(), CouleurCarte.Trèfle));

            listCartesPioche.Add(new Carte(ValeurCartes.As.ToString(), CouleurCarte.Coeur));
            listCartesPioche.Add(new Carte(ValeurCartes.As.ToString(), CouleurCarte.Carreau));
            listCartesPioche.Add(new Carte(ValeurCartes.As.ToString(), CouleurCarte.Pique));
            listCartesPioche.Add(new Carte(ValeurCartes.As.ToString(), CouleurCarte.Trèfle));

        }
		/// <summary>
		/// Retourne la liste des joueurs
		/// </summary>
		/// <returns></returns>
		public List<Joueur> getListJoueur()
		{
			return listeJoueur;
		}
		/// <summary>
		/// Retourne le nombre de cartes dans la pioche
		/// </summary>
		/// <returns></returns>
        public int getNbCartePioche()
        {
            return listCartesPioche.Count;
        }
		/// <summary>
		/// Retourne les cartes qui sont encore dans la pioche
		/// </summary>
		/// <returns></returns>
        public List<Carte> getListCartePioche()
        {
            return listCartesPioche;
        }
		/// <summary>
		/// Mélange les cartes
		/// </summary>
        public void melangerCarte()
        {
            listCartesPioche.Sort((x, y) => rmd.Next(-1, 7));
        }

		/// <summary>
		/// Retourne le joueur selectionner au hasard qui peut commencer la partie
		/// </summary>
		/// <returns></returns>
		public List<Joueur> melangeListe(List<Joueur> maList)
		{
			rmd = new Random();
			maList.Sort((x, y) => rmd.Next(0, maList.Count));
			return maList;
		}

		public Joueur getPremierJoueur()
		{
			return listeJoueur.ElementAt(0);
		}


		// Quand c'est le tour du premier Joueur, le programme refuse de passer au suivant
		public Joueur getJoueurSuivant(int i)
		{
			if (i > listeJoueur.Count - 1)
				return listeJoueur.ElementAt(0);				
			return listeJoueur.ElementAt(i);
		}
	}
}