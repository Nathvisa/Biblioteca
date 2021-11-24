using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyecFinal
{
    public partial class Form1 : Form
    {
        Biblioteca ingresar;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if ((txtusuario.Text != "") && (txtpassword.Text != ""))
            {
                if ((txtusuario.Text == "Nathali") && (txtpassword.Text == "5555"))
                {
                    ingresar = new Biblioteca();
                    ingresar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(" POR FAVOR VALIDAR DATOS");
                }

            }



        }
    }
}
