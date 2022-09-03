using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFADePipe
{
    public class DePiPe: De
    {
        public DePiPe() : base("Dé pipé")
        {

        }
        public override void Brasser(De DeABrasser)
        {
            var resultatDe = (int)(random.NextDouble() * DeABrasser.NomBreDeFace*2);
            if (resultatDe > 6)
            {
                DeABrasser.Valeur = 6;
            }
            else
            {
                DeABrasser.Valeur = resultatDe;
            }
        }
    }
}
