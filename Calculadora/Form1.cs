using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }
        int A = 0, B = 0, R = 0;
        char varialvel;
        private void button1_Click(object sender, EventArgs e)
        {
            if (varialvel == '+')
            {
                R = A + Convert.ToInt16(numero.Text);
                numero.Clear();
                numero.Text = R.ToString();

            }
        }

        
        private void Soma_Click(object sender, EventArgs e)
        {
            A = Convert.ToInt16(numero.Text);
            numero.Clear();
            varialvel = '+';
        }
    }
}
