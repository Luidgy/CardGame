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
            listeJoueur = lesJoueurs;
            attribuerCarteJoueur(lesJoueurs);
        }

        public void Jouer(Dictionary<Joueur, List<Carte>> jeuJ)
        {
           
        }

        public void recupererCarte(Dictionary<List<Joueur>, List<Carte>> lesCartesJouer)
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

        public void createListPlayers()
        {

        }

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

        public int getNbCartePioche()
        {
            return listCartesPioche.Count;
        }

        public List<Carte> getListCartePioche()
        {
            return listCartesPioche;
        }

        public void melangerCarte()
        {
            listCartesPioche.Sort((x, y) => rmd.Next(-1, 7));
        }

        public int getNbCartePile()
        {
            return listCartesPioche.Count;
        }
    }
}