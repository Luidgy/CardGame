namespace JeuCarte
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.card1 = new System.Windows.Forms.Panel();
            this.card2 = new System.Windows.Forms.Panel();
            this.card3 = new System.Windows.Forms.Panel();
            this.card4 = new System.Windows.Forms.Panel();
            this.pos2 = new System.Windows.Forms.Panel();
            this.pos1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pioche = new System.Windows.Forms.Panel();
            this.poubelle = new System.Windows.Forms.Panel();
            this.card8 = new System.Windows.Forms.Panel();
            this.card7 = new System.Windows.Forms.Panel();
            this.card6 = new System.Windows.Forms.Panel();
            this.card5 = new System.Windows.Forms.Panel();
            this.endTurn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.partieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(838, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nouvellePartieToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle Partie";
            // 
            // partieToolStripMenuItem
            // 
            this.partieToolStripMenuItem.Name = "partieToolStripMenuItem";
            this.partieToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.partieToolStripMenuItem.Text = "Partie";
            // 
            // card1
            // 
            this.card1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card1.BackgroundImage")));
            this.card1.Location = new System.Drawing.Point(5, 373);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(99, 141);
            this.card1.TabIndex = 3;
            this.card1.Paint += new System.Windows.Forms.PaintEventHandler(this.card1_Paint);
            this.card1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card1_MouseClick);
            this.card1.MouseHover += new System.EventHandler(this.card1_MouseHover);
            // 
            // card2
            // 
            this.card2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card2.BackgroundImage")));
            this.card2.Location = new System.Drawing.Point(110, 373);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(99, 141);
            this.card2.TabIndex = 4;
            this.card2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card2_MouseClick);
            // 
            // card3
            // 
            this.card3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card3.BackgroundImage")));
            this.card3.Location = new System.Drawing.Point(215, 373);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(99, 141);
            this.card3.TabIndex = 4;
            this.card3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card3_MouseClick);
            // 
            // card4
            // 
            this.card4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card4.BackgroundImage")));
            this.card4.Location = new System.Drawing.Point(320, 373);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(99, 141);
            this.card4.TabIndex = 4;
            this.card4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card4_MouseClick);
            // 
            // pos2
            // 
            this.pos2.Location = new System.Drawing.Point(277, 151);
            this.pos2.Name = "pos2";
            this.pos2.Size = new System.Drawing.Size(99, 141);
            this.pos2.TabIndex = 6;
            // 
            // pos1
            // 
            this.pos1.Location = new System.Drawing.Point(347, 197);
            this.pos1.Name = "pos1";
            this.pos1.Size = new System.Drawing.Size(99, 141);
            this.pos1.TabIndex = 6;
            // 
            // panel10
            // 
            this.panel10.Location = new System.Drawing.Point(308, 50);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(99, 141);
            this.panel10.TabIndex = 6;
            // 
            // panel11
            // 
            this.panel11.Location = new System.Drawing.Point(480, 117);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(99, 141);
            this.panel11.TabIndex = 6;
            // 
            // pioche
            // 
            this.pioche.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pioche.BackgroundImage")));
            this.pioche.Location = new System.Drawing.Point(729, 27);
            this.pioche.Name = "pioche";
            this.pioche.Size = new System.Drawing.Size(97, 150);
            this.pioche.TabIndex = 6;
            // 
            // poubelle
            // 
            this.poubelle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poubelle.Location = new System.Drawing.Point(5, 27);
            this.poubelle.Name = "poubelle";
            this.poubelle.Size = new System.Drawing.Size(99, 141);
            this.poubelle.TabIndex = 6;
            // 
            // card8
            // 
            this.card8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card8.BackgroundImage")));
            this.card8.Location = new System.Drawing.Point(741, 373);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(99, 141);
            this.card8.TabIndex = 6;
            this.card8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card8_MouseClick);
            // 
            // card7
            // 
            this.card7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card7.BackgroundImage")));
            this.card7.Location = new System.Drawing.Point(636, 373);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(99, 141);
            this.card7.TabIndex = 7;
            this.card7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card7_MouseClick);
            // 
            // card6
            // 
            this.card6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card6.BackgroundImage")));
            this.card6.Location = new System.Drawing.Point(531, 373);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(99, 141);
            this.card6.TabIndex = 8;
            this.card6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.card6_MouseClick);
            // 
            // card5
            // 
            this.card5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("card5.BackgroundImage")));
            this.card5.Location = new System.Drawing.Point(426, 373);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(99, 141);
            this.card5.TabIndex = 5;
            this.card5.Click += new System.EventHandler(this.card5_Click);
            // 
            // endTurn
            // 
            this.endTurn.Location = new System.Drawing.Point(729, 317);
            this.endTurn.Name = "endTurn";
            this.endTurn.Size = new System.Drawing.Size(97, 33);
            this.endTurn.TabIndex = 9;
            this.endTurn.Text = "Terminer";
            this.endTurn.UseVisualStyleBackColor = true;
            this.endTurn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(477, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(838, 516);
            this.Controls.Add(this.pos1);
            this.Controls.Add(this.pos2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endTurn);
            this.Controls.Add(this.card8);
            this.Controls.Add(this.poubelle);
            this.Controls.Add(this.card7);
            this.Controls.Add(this.card6);
            this.Controls.Add(this.pioche);
            this.Controls.Add(this.card5);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.card4);
            this.Controls.Add(this.card3);
            this.Controls.Add(this.card2);
            this.Controls.Add(this.card1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partieToolStripMenuItem;
        private System.Windows.Forms.Panel card1;
        private System.Windows.Forms.Panel card2;
        private System.Windows.Forms.Panel card3;
        private System.Windows.Forms.Panel card4;
        private System.Windows.Forms.Panel pos2;
        private System.Windows.Forms.Panel pos1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel pioche;
        private System.Windows.Forms.Panel poubelle;
        private System.Windows.Forms.Panel card8;
        private System.Windows.Forms.Panel card7;
        private System.Windows.Forms.Panel card6;
        private System.Windows.Forms.Panel card5;
        private System.Windows.Forms.Button endTurn;
        private System.Windows.Forms.Label label2;
    }
}

