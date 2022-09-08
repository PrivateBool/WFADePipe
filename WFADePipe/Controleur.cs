using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFADePipe
{
    public class Controleur
    {
        private int totalObtenu;        
        private De deCourant;
        public Controleur(int totalObtenu)
        {
            this.TotalObtenu = totalObtenu;           
        }

        public int TotalObtenu { get => totalObtenu; set => totalObtenu = value; }
        public De DeCourant { get => deCourant; set => deCourant = value; }

        public void GenererDe()
        {
            Random r = new Random();
            int harard = r.Next(0,2);
            if (harard == 0)
	        {
                DeCourant = new DeOrdinaire();
                DeCourant.Brasser();
                TotalObtenu += DeCourant.Valeur;
            }
            else
	        {
                DeCourant = new DePipe();
                DeCourant.Brasser();
                TotalObtenu += DeCourant.Valeur;
            }            
        }
       
    }
}
