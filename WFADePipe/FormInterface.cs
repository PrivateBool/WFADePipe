using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFADePipe
{
    public partial class FormIntreface : Form
    {
        private readonly Controleur controleur;        
        public FormIntreface()        
        {
            InitializeComponent();
            controleur = new Controleur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controleur.GenererDe();
            textBoxTotal.Text = controleur.TotalObtenu.ToString();
            textBoxValeurDe.Text = controleur.DeCourant.Valeur.ToString();
            labelTypeDeDe.Text = controleur.DeCourant.TypeDeDe;

        }
    }
}
