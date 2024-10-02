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
        List<Button> btnList = new List<Button>();
        public Loja(Index index)
        {
            InitializeComponent();
            I = index;
            btnList.AddRange(new Button[] { btnSkin1, btnSkin2, btnSkin3, btnSkin4, btnSkin5, btnSkin6, btnSkin7, btnSkin8 });
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
                    bool boleano = bool.Parse(estado[i]);
                    btnList[i].Enabled = boleano;
                }
            }
        }
        private void ClickSkin_Click(object sender, EventArgs e)
        {
            Comprar(sender, ref I.cliqueSkin, I.pbFruit, pnlSkin);
        }
        public void SecondSkin_Click(object sender, EventArgs e)
        {
            Comprar(sender, ref I.segundoSkin, I, pnlSkin);
        }
        private void Comprar(object sender, ref int up, object local, Panel painel)
        {
            Aviso av = new Aviso();

            Button btnSkin = (Button)sender;
            string Box = "pbSkin" + btnSkin.Name.Last(), Label = "lblSkin" + btnSkin.Name.Last();
            PictureBox pbSkin = this.Controls.Find(Box, true).FirstOrDefault() as PictureBox;
            Label lblSkin = this.Controls.Find(Label, true).FirstOrDefault() as Label;

            int.TryParse(btnSkin.Text, out int preco);
            int clique = int.Parse(lblSkin.Text.Substring(1));

            foreach (Button item in painel.Controls.OfType<Button>())
            {
                if (item.Text == "Selecionado")
                {
                    item.Enabled = true;
                    item.Text = "Selecionar";
                }
            }
            if (btnSkin.Text == "Selecionar")
            {
                up = clique;
                if (local is PictureBox)
                {
                    (local as PictureBox).Image = pbSkin.Image;
                }
                else { (local as Index).BackgroundImage = pbSkin.Image; }
                btnSkin.Text = "Selecionado";
                btnSkin.Enabled = false;
                SalvarBotoes();
            }
            else if (I.ponto >= preco)
            {
                I.ponto -= preco;
                up = clique;
                I.lblPonto.Text = I.ponto.ToString();
                if (local is PictureBox)
                {
                    (local as PictureBox).Image = pbSkin.Image;
                }
                else { (local as Index).BackgroundImage = pbSkin.Image; }
                btnSkin.Text = "Selecionado";
                btnSkin.Enabled = false;
                SalvarBotoes();
            }
            else { av.ShowDialog(); }
        }
        private void SalvarBotoes()
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
    }
}
