using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calatori_in_timp_si_spatiu
{
    public partial class Autentificare : Form
    {
        public Autentificare()
        {
            InitializeComponent();
        }

        private void btn_admin_Click(object sender, EventArgs e)
        {
            Administrator form = new Administrator();
            form.Show();
            this.Hide();
        }

        private void btn_turist_Click(object sender, EventArgs e)
        {
            Turist form = new Turist();
            form.Show();
            this.Hide();
        }
    }
}
