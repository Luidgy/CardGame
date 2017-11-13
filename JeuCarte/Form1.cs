using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeuCarte
{
    public partial class Form1 : Form
    {
        Joueur j1 = new Joueur("Mwaka", "Moon", new List<Carte>());
        Joueur j2 = new Joueur("Maco", "Maila", new List<Carte>());
        Joueur j3 = new Joueur("Lisa", "McCorty", new List<Carte>());
        Carte carteJouer;
        //Dictionary<Joueur, Carte> lesCartesJouer = new Dictionary<Joueur, Carte>();

        List<Joueur> maList;
        Tour leTour;
        List<Carte> carteJ1;
        List<Carte> carteJ2;
        //List<Carte> listCarteJou = new List<Carte>();
		Jeu maPartie;
		int numTour = 1;
		static string appPath = System.IO.Path.GetDirectoryName(Application.ExecutablePath);


		public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            maList = new List<Joueur> { j1, j2, j3 };
            maPartie = new Jeu(maList);
            carteJ1 = maPartie.getCarteJoueur(j1);
            carteJ2 = maPartie.getCarteJoueur(j2);

            
            card1.BackgroundImage = ResizeImage(Image.FromFile(appPath + carteJ1.ElementAt(0).getPath()), 99, 141);
            card2.BackgroundImage = ResizeImage(Image.FromFile(appPath + carteJ1.ElementAt(1).getPath()), 99, 141);
            card3.BackgroundImage = ResizeImage(Image.FromFile(appPath + carteJ1.ElementAt(2).getPath()), 99, 141);
            card4.BackgroundImage = ResizeImage(Image.FromFile(appPath + carteJ1.ElementAt(3).getPath()), 99, 141);
            card5.BackgroundImage = ResizeImage(Image.FromFile(appPath + carteJ1.ElementAt(4).getPath()), 99, 141);
            card6.BackgroundImage = ResizeImage(Image.FromFile(appPath + carteJ1.ElementAt(5).getPath()), 99, 141);
            card7.BackgroundImage = ResizeImage(Image.FromFile(appPath + carteJ1.ElementAt(6).getPath()), 99, 141);
            card8.BackgroundImage = ResizeImage(Image.FromFile(appPath + carteJ1.ElementAt(7).getPath()), 99, 141);

			card1.Name = carteJ1.ElementAt(0).getNomcarte();
            card2.Name = carteJ1.ElementAt(1).getNomcarte();
            card3.Name = carteJ1.ElementAt(2).getNomcarte();
            card4.Name = carteJ1.ElementAt(3).getNomcarte();
            card5.Name = carteJ1.ElementAt(4).getNomcarte();
            card6.Name = carteJ1.ElementAt(5).getNomcarte();
            card7.Name = carteJ1.ElementAt(6).getNomcarte();
            card8.Name = carteJ1.ElementAt(7).getNomcarte();

			leTour = new Tour(maPartie.getPremierJoueur(), carteJouer, numTour);

			label2.Text = "C'est le tour de " + maList.ElementAt(0).getNomJoueur();
        }

        private void card1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void card1_MouseClick(object sender, MouseEventArgs e)
        {
            pos1.BackgroundImage = card1.BackgroundImage;
			carteJouer = new Carte(getValeurCarte(card1.Name)[0], 
				getCouleurCarte(getValeurCarte(card1.Name)[1]),
				maPartie.genererPath(getValeurCarte(card1.Name)[0], 
				getCouleurCarte(getValeurCarte(card1.Name)[1])));

		}

		private void card2_MouseClick(object sender, MouseEventArgs e)
        {
            pos1.BackgroundImage = card2.BackgroundImage;
			carteJouer = new Carte(getValeurCarte(card2.Name)[0], 
				getCouleurCarte(getValeurCarte(card2.Name)[1]),
				maPartie.genererPath(getValeurCarte(card2.Name)[0],
				getCouleurCarte(getValeurCarte(card2.Name)[1])));
		}

        private void card3_MouseClick(object sender, MouseEventArgs e)
        {
            pos1.BackgroundImage = card3.BackgroundImage;
			carteJouer = new Carte(getValeurCarte(card3.Name)[0],
				getCouleurCarte(getValeurCarte(card3.Name)[1]),
				maPartie.genererPath(getValeurCarte(card3.Name)[0],
				getCouleurCarte(getValeurCarte(card3.Name)[1])));
		}

        private void card4_MouseClick(object sender, MouseEventArgs e)
        {
            pos1.BackgroundImage = card4.BackgroundImage;
			carteJouer = new Carte(getValeurCarte(card4.Name)[0], 
				getCouleurCarte(getValeurCarte(card4.Name)[1]),
				maPartie.genererPath(getValeurCarte(card4.Name)[0],
				getCouleurCarte(getValeurCarte(card4.Name)[1])));
		}

        private void card5_Click(object sender, EventArgs e)
        {
            pos1.BackgroundImage = card5.BackgroundImage;
			carteJouer = new Carte(getValeurCarte(card5.Name)[0], 
				getCouleurCarte(getValeurCarte(card5.Name)[1]),
				maPartie.genererPath(getValeurCarte(card5.Name)[0],
				getCouleurCarte(getValeurCarte(card5.Name)[1])));
		}

        private void card6_MouseClick(object sender, MouseEventArgs e)
        {
            pos1.BackgroundImage = card6.BackgroundImage;
			carteJouer = new Carte(getValeurCarte(card6.Name)[0], 
				getCouleurCarte(getValeurCarte(card6.Name)[1]),
				maPartie.genererPath(getValeurCarte(card6.Name)[0],
				getCouleurCarte(getValeurCarte(card6.Name)[1])));
		}

        private void card7_MouseClick(object sender, MouseEventArgs e)
        {
            pos1.BackgroundImage = card7.BackgroundImage;
			carteJouer = new Carte(getValeurCarte(card7.Name)[0], 
				getCouleurCarte(getValeurCarte(card7.Name)[1]),
				maPartie.genererPath(getValeurCarte(card7.Name)[0],
				getCouleurCarte(getValeurCarte(card7.Name)[1])));
		}

        private void card8_MouseClick(object sender, MouseEventArgs e)
        {
            pos1.BackgroundImage = card8.BackgroundImage;
			carteJouer = new Carte(getValeurCarte(card8.Name)[0],
				getCouleurCarte(getValeurCarte(card8.Name)[1]),
				maPartie.genererPath(getValeurCarte(card8.Name)[0],
				getCouleurCarte(getValeurCarte(card8.Name)[1])));
		}

        private void button1_Click(object sender, EventArgs e)
        {
			tourSuivant();
			
		}

		private void tourSuivant()
		{
			pos2.BackgroundImage = pos1.BackgroundImage;

			pos1.BackgroundImage = null;
			numTour++;
			// Je remet le numero du tour à 1 pour reprendre à zéro

			if (numTour > maPartie.getListJoueur().Count)
				numTour = 1;

			label2.Text = "C'était le tour de " + leTour.getNameJoueurDuTour() + " et elle a jouer : " + carteJouer.getNomcarte();
			leTour = new Tour(maPartie.getJoueurSuivant(leTour.getNumTour()), carteJouer, numTour);
			label3.Text = "C'est le tour de " + leTour.getNameJoueurDuTour();
			
		}




		private CouleurCarte getCouleurCarte(string coul)
		{
			CouleurCarte val = CouleurCarte.Pique;
			if (coul.Equals(CouleurCarte.Carreau.ToString()))
				val = CouleurCarte.Carreau;
			if (coul.Equals(CouleurCarte.Coeur.ToString()))
				val = CouleurCarte.Coeur;
			if (coul.Equals(CouleurCarte.Pique.ToString()))
				val = CouleurCarte.Pique;
			if (coul.Equals(CouleurCarte.Trèfle.ToString()))
				val = CouleurCarte.Trèfle;

			return val;
		}

		private void trouverCarteJouer(string nomCarte, List<Carte> listeCarte)
		{
			foreach (Carte c in listeCarte)
			{
				if (c.getNomcarte().Equals(nomCarte))
					carteJouer = c;
			}
		}

		private string[] getValeurCarte(String nomCarte)
		{
			string[] carte = nomCarte.Split(' ');

			return carte;
		}

		private void card1_MouseHover(object sender, EventArgs e)
        {
            label2.Text = card1.Name;
        }

        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

		static string getPath()
		{
			return appPath;
		}
    }
}
