using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;



namespace Genon_PROJET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TBSupprimer_Click(object sender, EventArgs e)
        {
            string Nom, categorie, support;
            float prix = 0;
            int quantite=0;
            categorie = "null";
            support = "null";
            Nom = TBNom.Text;
            gestionBD.deleteFilm(Nom, categorie, prix, support, quantite);
            MessageBox.Show("le film " + "" + Nom + "" + "a bien été supprimé");
        
        }

        private void TBModifier_Click(object sender, EventArgs e)
        {
            string nom, categorie, support;
            int quantite;
            float prix;
            int id;
            id = 0;
            nom = TBNom.Text;
            categorie = TBCategorie.Text;
            prix = Convert.ToInt16(TBPrix.Text);
            support = "";
            quantite = Convert.ToInt16(TBQuantite.Text);
            if (RBDvd.Checked )
            {
                support = "DVD";
            }
            if (RBBluray.Checked)
            {
                support = "Bluray";
            }
            
            gestionBD.updateFilm(nom, categorie, prix, support, quantite);
            MessageBox.Show("Le film" +""+ nom + " " + " a bien été modifié");
}

        

        private void TBAfficher_Click(object sender, EventArgs e)
        {
            
            
           
            foreach(_film unfilm in gestionBD.getAllFilm())
            {
                dataGridView1.Rows.Add(unfilm.getNomF(), unfilm.getCategorieF(), unfilm.getPrixF(), unfilm.getSupportF(),unfilm.getQuantiteF());

            }
        }

        private void TBAjout_Click(object sender, EventArgs e)
        {
            string nom, categorie, support;
            int quantite;
            float prix;
            try
            {


                nom = TBNom.Text;
                categorie = TBCategorie.Text;
                prix = Convert.ToInt16(TBPrix.Text);
                support = "";
                quantite = Convert.ToInt16(TBQuantite.Text);
                if (RBDvd.Checked)
                {
                    support = "DVD";
                }
                if (RBBluray.Checked)
                {
                    support = "Bluray";
                }
                gestionBD.getajoutfilm(nom, categorie, prix, support, quantite);
                MessageBox.Show("Le film a bien été ajouté.");
            }
            catch (Exception ee)
            {
                MessageBox.Show("erreur ! " + ee);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
