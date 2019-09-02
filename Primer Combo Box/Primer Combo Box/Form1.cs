using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Combo_Box
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void ComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int indice = comboBox1.SelectedIndex; //almacena el index del valor seleccionado
            string mensaje = "Que dia es hoy" + comboBox1.Items[indice].ToString();
            MessageBox.Show(mensaje);
        }
    }
}
