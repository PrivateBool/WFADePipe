using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFADePipe
{
    public class Controleur
    {
        
        protected int totalObtenu;

        public void GenererDe()
        {
            Random r = new Random();
            int harard = r.Next(0,1);
            if (harard = 0)
	        {
                DeOrdinaire deABrasser = new DeOrdinaire();
	        }
            else
	        {
                DePiPe deABrasser = new DePiPe();
	        }            
        }
         public void Brasser(De deABrasser)
         {
            deABrasser.Brasser();
         }
       
    }
}
