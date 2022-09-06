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
            controleur = new Controleur(0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            controleur.GenererDe();
            textBoxTotal.Text = controleur.totalObtenu.ToString();
            textBoxValeurDe.Text = controleur.TrouverValeurDe().ToString();
            labelTypeDeDe.Text = controleur.TrouverTypeDeDe().ToString();
        }
    }
}
