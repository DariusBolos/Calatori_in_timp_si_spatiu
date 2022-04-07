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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void btn_autentificare_Click(object sender, EventArgs e)
        {
            if (textBox_parola.Text == "")
            {
                MessageBox.Show("Introduceti datele de autentificare");
                return;
            }
            
            if (textBox_parola.Text == "agentie2015")
            {
                this.Hide();
                App_Admin form = new App_Admin();
                form.Show();
            }

            if (textBox_parola.Text != "agentie2015")
            { 
                MessageBox.Show("Parola este incorecta");
                return;
            }
        }
    }
}
