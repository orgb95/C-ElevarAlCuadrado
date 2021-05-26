using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TxtEdad_Enter(object sender, EventArgs e)
        {

            txtEdad.Text = "";
        }

        private void TxtEdad_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEdad.Text))
            {
                txtEdad.Text = "Edad";
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            int? edad = GetIntValue(txtEdad.Text);
            if (edad == null)
            {
                return;
            }
            string categoria = cmbCategoria.SelectedItem.ToString();
            string mensaje = "No coinciden la edad con la categoria";
            switch (categoria)
            {
                case "Bebe":
                    if (validarEdad(edad ?? 0, 0, 4))
                    {
                        mensaje = "Usted es un bebe";
                    }
                    break;
                case "Niño":
                    if (validarEdad(edad ?? 5, 5,11))
                    {
                        mensaje = "Usted es un Niño";
                    }
                    break;
                case "Adolescente":
                    if (validarEdad(edad ?? 12,12, 17))
                    {
                        mensaje = "Usted es un Adolescente";
                    }
                    break;
                case "Joven":
                    if (validarEdad(edad ?? 18, 18, 23))
                    {
                        mensaje = "Usted es un Joven";
                    }
                    break;
                case "Adulto":
                    if (validarEdad(edad ?? 24, 24, 60))
                    {
                        mensaje = "Usted es un Adulto";
                    }
                    break;
                case "Adulto Mayor":
                    if (validarEdad(edad ?? 61, 61, 120))
                    {
                        mensaje = "Usted es un Adulto Mayor";
                    }
                    break;
                    
            }
            MessageBox.Show(mensaje);
        }
        private bool validarEdad(int edad ,int min, int max)
        {
            return (edad >= min && edad <= max);
        }
        private int? GetIntValue(String value)
        {
            if (int.TryParse(txtEdad.Text, out int edad))
            {
               return edad;
            }
          return null;

        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            object obj = 3;
            long j = 4;
            if(obj is int i)
            {
                MessageBox.Show($"{i} x {j} = {i * j}");
            }
            else
            {
                MessageBox.Show($"La variable obj ({obj.GetType()}) no es un entero");
            }
        }
    }
}
