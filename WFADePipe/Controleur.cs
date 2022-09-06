using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFADePipe
{
    public class Controleur
    {
        public int totalObtenu;
        public int valeur;
        public string typeDeDe;
        public Controleur(int totalObtenu)
        {
            this.totalObtenu = totalObtenu;           
        }

        public void GenererDe()
        {
            Random r = new Random();
            int harard = r.Next(0,2);
            if (harard == 0)
	        {
                DeOrdinaire deABrasser = new DeOrdinaire();
                deABrasser.Brasser();
                valeur = deABrasser.Valeur;
                typeDeDe = deABrasser.TypeDeDe;
                totalObtenu += deABrasser.Valeur;
            }
            else
	        {
                DePipe deABrasser = new DePipe();
                deABrasser.Brasser();
                valeur = deABrasser.Valeur;
                typeDeDe = deABrasser.TypeDeDe;
                totalObtenu += deABrasser.Valeur;
            }            
        }
        public int TrouverValeurDe()
        {
            return valeur;
        }
        public string TrouverTypeDeDe()
        {
            return typeDeDe;
        }
    }
}
