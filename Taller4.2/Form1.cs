using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taller4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btnmostrar_Click(object sender, EventArgs e)
        {
            int numeros = int.Parse(txtnumeros.Text);
           // int impar = 0;
           
            lista.Items.Clear();

            for (int i =0; i <= numeros ; i++)
            {

                if (i % 2  == 0)
                {
                    lista.Items.Add("- " + i);
                   
                }

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
