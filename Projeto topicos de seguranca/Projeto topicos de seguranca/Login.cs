using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_topicos_de_seguranca
{
    public partial class LoginJogo : Form
    {
        public LoginJogo()
        {
            InitializeComponent();
        }


        private void pictureDefesa_Click(object sender, EventArgs e)
        {
            Marcagolo C = new Marcagolo();
            C.Show();

        }


        private void pictureMarcador_Click(object sender, EventArgs e)
        {
            Marcagolo C = new Marcagolo();
            C.Show();
        }
    }
}
