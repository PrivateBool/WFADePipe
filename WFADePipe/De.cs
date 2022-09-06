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
        private string typeDeDe;
        public Random random = new Random();
        public int NomBreDeFace => nombreDeFace;

        public int Valeur { get => valeur; set => valeur = value; }
        public string TypeDeDe { get => typeDeDe; set => typeDeDe = value; }

        public De(string typeDEDE)
        {
            this.TypeDeDe = typeDEDE;
        }
        public virtual void Brasser()
        {
            this.Valeur = (int)(Math.Ceiling((random.NextDouble()) * this.NomBreDeFace));
        }
    }
}
