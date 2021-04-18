using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Películas
{
    public partial class fPeliculas : Form
    {
        #region variables globales
        String[] aPeliculas;
        int Ultimo = -1; 
        int Tope = 20;       
        #endregion
        public fPeliculas()
        {
            InitializeComponent();
            aPeliculas = new String[20];
        }

        private void tPeliculas_TextChanged(object sender, EventArgs e)
        {
            ++Ultimo
            if (tPeliculas.Text == "")
                MessageBox.Show("Ingrese el nombre de la película");
            else(aPeliculas[Ultimo])
        }
    }
}
