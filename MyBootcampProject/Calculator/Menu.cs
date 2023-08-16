using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Menu : Form
    {
        const string OurPassword = "1";
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
        enterpassword:
            string pasword = password.Show();
            if(pasword == "")
            {
                this.Close();
            }
            if(pasword != OurPassword && pasword != "")
            {
                MessageBox.Show("Попробуйте ещё раз!", "Пароль неверный", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                goto enterpassword;
            }
        }

        private void LBLinkCalculator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form frm = new calculator();
            frm.Show();
        }
    }
}
