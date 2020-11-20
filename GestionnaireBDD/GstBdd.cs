using MySql.Data.MySqlClient;
using System;
using MetierTrader;
using System.Collections.Generic;
using System.Collections;

namespace GestionnaireBDD
{
    public class GstBdd
    {
        private MySqlConnection cnx;
        private MySqlCommand cmd;
        private MySqlDataReader dr;

        // Constructeur
        public GstBdd()
        {
            string chaine = "Server=localhost;Database=bourse;Uid=root;Pwd=";
            cnx = new MySqlConnection(chaine);
            cnx.Open();
        }

        public List<Trader> getAllTraders()
        {
            List<Trader> mesTrader = new List<Trader>();
            cmd = new MySqlCommand("select idTrader, nomTrader from trader", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                Trader unTrader = new Trader(Convert.ToInt16(dr[0].ToString()), dr[1].ToString());
                mesTrader.Add(unTrader);
            }
            dr.Close();
            return mesTrader;
           
        }
        public List<ActionPerso> getAllActionsByTrader(int numTrader)
        {
            List<ActionPerso> mesActionPerso = new List<ActionPerso>();
            cmd = new MySqlCommand("select numAction, numTrader,prixAchat,quantite from acheter", cnx);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ActionPerso uneActionPerso = new ActionPerso(Convert.ToInt16(dr[0].ToString()), Convert.ToInt16(dr[1].ToString()), Convert.ToInt16(dr[2].ToString()), Convert.ToInt16(dr[3].ToString()));//Convert.ToInt16(dr[4].ToString()), Convert.ToInt16(dr[5].ToString()));
                mesActionPerso.Add(uneActionPerso);
            }
            dr.Close();
            return mesActionPerso;

            
        }

        public IEnumerable getAllActionsByTrader()
        {
           

        
            throw new NotImplementedException();
        }

        public IEnumerable getAllActionsByTrader(object numTrader)
        {
            throw new NotImplementedException();
        }

        public List<MetierTrader.Action> getAllActionsNonPossedees(int numTrader)
        {
            return null;
        }

        public void SupprimerActionAcheter(int numAction, int numTrader)
        {
            
        }

        public void UpdateQuantite(int numAction, int numTrader, int quantite)
        {
            
        }

        public double getCoursReel(int numAction)
        {
            return 0;
        }
        public void AcheterAction(int numAction, int numTrader, double prix, int quantite)
        {

        }
        public double getTotalPortefeuille(int numTrader)
        {
            int quantite;
            int prixAchat;
            int total;
            total = quantite * prixAchat;
            
            return 0;
        }
    }
}
