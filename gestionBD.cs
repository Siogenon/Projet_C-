using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Genon_PROJET
{
    class gestionBD
    {
        ArrayList ListFilm;

        static MySqlConnection connect;
        static MySqlDataReader lecteur;

        // CONNECTION A LA BASE DE DONNEE 

        public static void connectDB()
        {
            try
            {
                string connexion = @"server=localhost;userid=root;database=genonF"; 
                connect = new MySqlConnection(connexion);
            }
            catch (Exception)
            {
                MessageBox.Show("une erreur est survenue lors de la tentative de connexion" );
            }
        }

        // FONCTION RECHERCHE FILM

        public static ArrayList getAllFilm()
        {
            ArrayList ListFilm = new ArrayList();
            try
            {
                connectDB();
                connect.Open();
                string reqF = "SELECT * FROM film";
                _film unfilm; 
                MySqlCommand command = new MySqlCommand(reqF, connect);
                lecteur = command.ExecuteReader();
                while (lecteur.Read()) 
                {
                    unfilm = new _film(lecteur.GetString(1), lecteur.GetString(2), lecteur.GetFloat(3), lecteur.GetString(4), lecteur.GetInt32(5)); 
                    ListFilm.Add(unfilm);  // on ajoute 
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Problème lors de l'affichage des film. "+ e);
            }
            return ListFilm;
        }


        //------------------------------------------ AJOUT FILM --------------------------------------//

        public static void getajoutfilm(string Nom, string Categorie, float Prix, string Support, int Quantite)
        {
            try
            {
                _film unfilm = new _film (Nom, Categorie, Prix, Support, Quantite);
                connectDB();
                MySqlCommand requete = new MySqlCommand();
                int idFilm = 0+1;
                requete.CommandText = "INSERT INTO film (nomF,categorieF,prixF,supportF,quantiteF) Values('"+ unfilm.getNomF() + "','" + unfilm.getCategorieF() + "'," + unfilm.getPrixF() + ",'" + unfilm.getSupportF() + "'," + unfilm.getQuantiteF()+ ");";
               
                requete.Connection = connect;
                connect.Open();
                requete.Prepare();
                try
                {
                    requete.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    MessageBox.Show("erreur" + error);
                }
            }
            catch (MySqlException ajout)
            {
                MessageBox.Show("erreur lors de l'ajout du film. :" + ajout);
            }
        }

        // -------------------------------------- SUPRRESSION D'UN FILM ---------------------------------------------//

        public static void deleteFilm(string Nom, string Categorie, float Prix, string Support, int Quantite)
        {
            try
            {
                connectDB();
                connect.Open();
                _film unfilm = new _film(Nom, Categorie, Prix, Support, Quantite);
                MySqlCommand requete = new MySqlCommand();
                requete.Connection = connect;
                requete.CommandText = "DELETE FROM film WHERE nomF='"+ unfilm.getNomF()+"'";
                requete.Prepare();
                requete.ExecuteNonQuery();
            }
            catch (MySqlException suppFilm)
            {
                MessageBox.Show("erreur suppression du film :" + suppFilm);
            }
        }

        // ----------------------------------- MODOFICATION D'UN FILM ----------------------------------//
        public static void updateFilm(string Nom, string Categorie, float Prix, string Support, int Quantite)
        {
            try
            {
                connectDB();
                connect.Open();
                _film unfilm = new _film(Nom, Categorie, Prix, Support, Quantite);
                MySqlCommand modif = new MySqlCommand();
                modif.Connection = connect;
                modif.CommandText = "UPDATE film SET nomF='" + unfilm.getNomF() + "', categorieF='" + unfilm.getCategorieF() + "' ,prixF=" + unfilm.getPrixF() + ", supportF='" + unfilm.getSupportF() + "' ,quantiteF='" + unfilm.getQuantiteF() + "' WHERE nomF='"+ unfilm.getNomF()+"';";
                modif.Prepare();
                modif.ExecuteNonQuery();
            }
            catch (Exception modiFilm)
            {
                MessageBox.Show("erreur lors de la modification du film" + modiFilm);

            }
        }
    }
}