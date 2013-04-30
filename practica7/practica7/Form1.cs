using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace practica7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Terminar_Click(object sender, EventArgs e)
        {

            int puntos = 0;

            if (this.radioGDL.Checked)
                puntos++;

            if (this.suma.Text == "13")
                puntos++;

            if (this.CHECKMX.Checked)
                puntos++;
            if (this.CHECKPERU.Checked)
                puntos++;



            string fechaseleccionado = calendario.SelectionStart.ToString();
            if (fechaseleccionado == "16/04/2013 12:00:00 a. m.")
                puntos++;


            MessageBox.Show("Aciertos " + puntos, "Putos");
          

        }

      

      

      
    }
}
