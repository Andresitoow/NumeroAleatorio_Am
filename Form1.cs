using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroAleatorio_Am
{
    public partial class Form1 : Form
    {
        int intentos = 0; // Inicializar la variable intentos
        Random rand = new Random(); // Crear el objeto rand con la función Random
        int Aleatorio = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            intentos = 5; // Cantidad de intentos
            txtIntentos.Text = intentos.ToString();
            Aleatorio = rand.Next(1, 100); // Aleatorio es igual aun número entre 1 y 100
        }

        private void txtadivina_Click(object sender, EventArgs e)
        {

        }

        private void txtIntentos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtNumero.Text, out int num))
            {
                if (num == Aleatorio)
                {
                    MessageBox.Show($"Ganaste el juego, el número es: {Aleatorio}");
                    DialogResult resultado = MessageBox.Show("¿Quieres volver a jugar?", "Reintentar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.No)
                    {
                        MessageBox.Show("Gracias por jugar :)");
                        Application.Exit();
                    }
                    else
                    {
                        intentos = 5;
                        txtIntentos.Text = intentos.ToString();
                        Aleatorio = rand.Next(1, 100);
                    }
                }
                if (num > Aleatorio)
                {
                    MessageBox.Show($"{num} es Mayor al número");
                }
                if (num < Aleatorio)
                {
                    MessageBox.Show($"{num} es Menor al número");
                }
            } 
            else
            {
                MessageBox.Show("Ingrese una cantidad valida");
            }
        }
    }
}