using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_Clicker
{
    public partial class Conquista : Form
    {
        bool[] conquista = new bool[10];
        Index I;
        public Conquista(Index index)
        {
            I = index;
            InitializeComponent();

            AtualizarConquista();
        }
        private void AtualizarConquista()
        {
            string[] estado = (!string.IsNullOrEmpty(Properties.Settings.Default.Conquistas)) ? Properties.Settings.Default.Conquistas.Split(';') : new string[0];

            if (estado.Length != 0)
            {
                for (int i = 0; i < conquista.Length; i++)
                {
                    bool boleano = bool.Parse(estado[i]);
                    conquista[i] = boleano;
                }
            }
        }
        public void ConquistaPontos()
        {
            if (conquista[0])
                goto Conquista2;
            else if (I.ponto >= 1000)
            {
                I.ponto += 200;
                I.lblPonto.Text = I.ponto.ToString();
                conquista[0] = true;
            }

        Conquista2:
            if (conquista[1])
                goto Conquista3;
            else if (I.ponto >= 5000)
            {
                I.ponto += 750;
                I.lblPonto.Text = I.ponto.ToString();
                conquista[1] = true;
            }

        Conquista3:
            if (conquista[2])
                return;
            else if (I.ponto >= 10000)
            {
                I.ponto += 2500;
                I.lblPonto.Text = I.ponto.ToString();
                conquista[2] = true;
            }
        }

        public void ConquistaSkin()
        {
            if (conquista[3])
                goto Conquista5;
            else if (true)
            {
                I.ponto += 200;
                I.lblPonto.Text = I.ponto.ToString();
                conquista[3] = true;
            }

            Conquista5:
            if (conquista[4])
                return;
            else if (true)
            {
                I.ponto += 200;
                I.lblPonto.Text = I.ponto.ToString();
                conquista[4] = true;
            }
        }
        private void CriarImagen(PictureBox pb)
        {
            PictureBox pbCompleta = new PictureBox
            {
                Size = pb.Size,
                BackColor = pb.BackColor,
                Location = pb.Location,
                //Image = Properties.Resources.Nome,
                SizeMode = pb.SizeMode
            };
            this.Controls.Add(pbCompleta);
        }
        private void SalvarConquista()
        {
            List<string> estado = new List<string>();

            foreach (bool item in conquista)
            {
                estado.Add(item.ToString());
            }

            Properties.Settings.Default.Conquistas = string.Join(";", estado);
            Properties.Settings.Default.Save();
        }
        private void pbFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
