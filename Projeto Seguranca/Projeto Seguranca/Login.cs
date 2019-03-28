using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Seguranca
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void pictureMarcador_Click(object sender, EventArgs e)
        {
            Marcador C = new Marcador();
            C.Show();
            
        }

        private void pictureDefesa_Click(object sender, EventArgs e)
        {
            Defesa C = new Defesa();
            C.Show();
        }
    }
}
