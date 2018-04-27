using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genon_PROJET
{
    public class _film
    {
        private int idFilm;
        private string nomF;
        private string categorieF;
        private float prixF;
        private string supportF;
        private int quantiteF;


         public _film( string _nomF, string _categorieF, float _prixF, string _supportF, int _quantiteF)
        {
            
            nomF = _nomF;
            categorieF = _categorieF;
            prixF = _prixF;
            supportF = _supportF;
            quantiteF = _quantiteF;
        } 
        // LES ACCESSEURS
        public int getidFilm() { return idFilm; }
        public string getNomF() { return nomF; }
        public string getCategorieF() { return categorieF; }
        public float getPrixF() { return prixF; }
        public string getSupportF() { return supportF; }
        public int getQuantiteF() { return quantiteF; }

        public void setIdFilm(int unidFilm_) { idFilm = unidFilm_; }
        public void setNomF(string nomF_) { nomF = nomF_; }
        public void setCategorieF(string categorieF_) { categorieF = categorieF_; }
        public void setPrixF(float prixF_) { prixF = prixF_; }
        public void setSupport(string supportF_) { supportF = supportF_; }
        public void setQuantiteF(int quantiteF_) { quantiteF = quantiteF_; }


 }
}