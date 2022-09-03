using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFADePipe
{
    public abstract class De
    {
        private int valeur;
        private readonly int nombreDeFace = 6;
        private readonly string estPipe;
        public Random random = new Random();
        public int NomBreDeFace => nombreDeFace;

        public int Valeur { get => valeur; set => valeur = value; }

        public De(string typeDEDE)
        {
            this.estPipe = typeDEDE;
        }
        public virtual void Brasser(De DeABrasser)
        {
            DeABrasser.Valeur = (int)(random.NextDouble() * DeABrasser.NomBreDeFace);
        }
    }
}
