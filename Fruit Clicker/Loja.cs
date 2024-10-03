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
    public partial class Loja : Form
    {
        Index I;
        List<Button> btnList;
        Codigo codigo;

        public Loja(Index index)
        {
            InitializeComponent();
            I = index;
            codigo = new Codigo();
            btnList = new List<Button> { btnSkin1, btnSkin2, btnSkin3, btnSkin4, btnSkin5, btnSkin6, btnSkin7, btnSkin8 };
            AtualizarBotoes();
        }

        private void AtualizarBotoes()
        {
            string[] texto = (!string.IsNullOrEmpty(Properties.Settings.Default.btnText)) ? Properties.Settings.Default.btnText.Split(';') : new string[0];
            string[] estado = (!string.IsNullOrEmpty(Properties.Settings.Default.btnBool)) ? Properties.Settings.Default.btnBool.Split(';') : new string[0];

            if (texto.Length != 0)
            {
                for (int i = 0; i < btnList.Count; i++)
                {
                    btnList[i].Text = texto[i];
                    btnList[i].Enabled = bool.Parse(estado[i]);
                }
            }
        }

        private void ClickSkin_Click(object sender, EventArgs e)
        {
            Button btnSkin = (Button)sender;
            string Box = "pbSkin" + btnSkin.Name.Last(), Label = "lblSkin" + btnSkin.Name.Last();
            PictureBox pbSkin = this.Controls.Find(Box, true).FirstOrDefault() as PictureBox;
            Label lblSkin = this.Controls.Find(Label, true).FirstOrDefault() as Label;
            codigo.Comprar(ref I.cliqueSkin, ref I.ponto, btnSkin, pbSkin, lblSkin, I.pbFruit, pnlSkin), this, I;
            I.lblPonto.Text = I.ponto.ToString();
        }

        private void SecondSkin_Click(object sender, EventArgs e)
        {
            Button btnSkin = (Button)sender;
            string Box = "pbSkin" + btnSkin.Name.Last(), Label = "lblSkin" + btnSkin.Name.Last();
            PictureBox pbSkin = this.Controls.Find(Box, true).FirstOrDefault() as PictureBox;
            Label lblSkin = this.Controls.Find(Label, true).FirstOrDefault() as Label;
            codigo.Comprar(ref I.cliqueSkin, ref I.ponto, btnSkin, pbSkin, lblSkin, I, pnlSkin, this, I);
            I.lblPonto.Text = I.ponto.ToString();
        }

        private void pbFechar_Click(object sender, EventArgs e)
        {
            I.btnLoja.Text = "Loja";
            I.pnlLoja.Enabled = false;
            I.pnlLoja.Visible = false;
            I.pnlLoja.Location = new Point(0, 0);
            this.Close();
            pnlSkin.Enabled = false;
            pnlSkin.Visible = false;
        }

        public void SalvarBotoes()
        {
            List<string> texto = new List<string>();
            List<string> estado = new List<string>();

            foreach (Button item in btnList)
            {
                texto.Add(item.Text);
                estado.Add(item.Enabled.ToString());
            }
            Properties.Settings.Default.btnText = string.Join(";", texto);
            Properties.Settings.Default.btnBool = string.Join(";", estado);
            Properties.Settings.Default.Save();
        }
    }
}
