using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFADePipe
{
    public class Controleur
    {
        private int totalObtenu = 0;        
        protected De deCourant;

        public int TotalObtenu { get => totalObtenu; }
        public De DeCourant { get => deCourant; set => deCourant = value; }
        public Controleur() { }                 
        
        public void GenererDe()
        {
            Random r = new Random();
            int harard = r.Next(0,2);
            if (harard == 0)
	        {
                DeCourant = new DeOrdinaire();
                DeCourant.Brasser();
                totalObtenu += DeCourant.Valeur;
            }
            else
	        {
                DeCourant = new DePipe();
                DeCourant.Brasser();
                totalObtenu += DeCourant.Valeur;
            }            
        }
       
    }
}
