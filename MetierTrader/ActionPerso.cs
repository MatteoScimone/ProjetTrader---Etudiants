using System;
using System.Collections.Generic;
using System.Text;

namespace MetierTrader
{
    public class ActionPerso
    {
        private int numAction;
        private int idTrader;
        //private double total;
        //private string nomAction;
        private double prixAchat;
        private int quantite; 
        public ActionPerso(int unNum,int unId,double unPrix,int uneQuantite)
        {
            NumAction = unNum;
            IdTrader = unId;
          //  Total = unTotal;
           // NomAction = unNom;
            PrixAchat = unPrix;
            Quantite = uneQuantite;
        }

       
        public double PrixAchat { get => prixAchat; set => prixAchat = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public int IdTrader { get => idTrader; set => idTrader = value; }
        //public double Total { get => total; set => total = value; }
        public int NumAction { get => numAction; set => numAction = value; }
        //public string NomAction { get => nomAction; set => nomAction = value; }
    }
}
