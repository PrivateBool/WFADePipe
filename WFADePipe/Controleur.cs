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
        public De deHasard;
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
                deHasard = new DeOrdinaire();
                deHasard.Brasser();
                totalObtenu += deHasard.Valeur;
            }
            else
	        {
                deHasard = new DePipe();
                deHasard.Brasser();
                totalObtenu += deHasard.Valeur;
            }            
        }
       
    }
}
