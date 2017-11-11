using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuCarte
{
    class Joueur
    {
        String nom;
        String prenom;

        #region constructeurs
        /// <summary>
        /// Si aucune données sur le joueur n'est transmise, celui-ci d'appellera Joueur + son numéro
        /// </summary>
        public Joueur()
        {

        }

        /// <summary>
        /// Constructeur du joueur
        /// </summary>
        /// <param name="jNom">Nom du joueur</param>
        /// <param name="jPrenom">Prénom du joueur</param>
        /// <param name="mesCartes">Liste des cartes du Joeur</param>
        public Joueur(String jNom, String jPrenom, List<Carte> mesCartes)
        {
            nom = jNom;
            prenom = jPrenom;
        }

        #endregion;

        #region getters and setters
        public String getNomJoueur()
        {
            return nom;
        }

        public String getPrenomJoueur()
        {
            return prenom;
        }

        public void setNomJoueur(String nomJou)
        {
            nom = nomJou;
        }

        public void setPrenomJoueur(String prenomJou)
        {
            prenom = prenomJou;
        }

        #endregion;

    }
}
