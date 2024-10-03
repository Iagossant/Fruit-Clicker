using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_Clicker
{
    public class Codigo
    {
        public void Comprar(ref int up, ref int ponto, Button btnSkin, object local, Panel painel)
        {
            Button btnSkin = (Button)sender;
            string Box = "pbSkin" + btnSkin.Name.Last(), Label = "lblSkin" + btnSkin.Name.Last();
            PictureBox pbSkin = Loja.Controls.Find(Box, true).FirstOrDefault() as PictureBox;
            Label lblSkin = Loja.Controls.Find(Label, true).FirstOrDefault() as Label;
            int.TryParse(btnSkin.Text, out int preco);
            int clique = int.Parse(lblSkin.Text.Substring(1));

            foreach (Button item in Loja.painel.Controls.OfType<Button>())
            {
                if (item.Text == "Selecionado" && ponto >= preco)
                {
                    item.Enabled = true;
                    item.Text = "Selecionar";
                }
            }

            if (btnSkin.Text == "Selecionar" || ponto >= preco)
            {
                if (btnSkin.Text != "Selecionar")
                {
                    ponto -= preco;
                }
                up = clique;
                if (local is PictureBox pb) { pb.Image = pbSkin.Image; }
                else if (local is Index index) { index.BackgroundImage = pbSkin.Image; }
                btnSkin.Text = "Selecionado";
                btnSkin.Enabled = false;
            }
            else
            {
                new Aviso().ShowDialog();
            }
        }

        public void Upgrade(ref int ponto, ref int lvl, ref int Up, Button btnUp)
        {
            int preco = int.Parse(btnUp.Text);
            if (ponto >= preco)
            {
                ponto -= preco;
                preco *= 2;
                Up++;
                lvl++;
                btnUp.Text = preco.ToString();
            }
            else
            {
                new Aviso().ShowDialog();
            }
        }

        public void Abrir_Fechar(Panel pnl, Button btn, string btnName)
        {
            if (btn.Text == "Fechar")
            {
                btn.Text = btnName;
                pnl.Enabled = false;
                pnl.Visible = false;
                pnl.Location = new Point(0, 0);
            }
            else
            {
                btn.Text = "Fechar";
                pnl.Location = new Point(255, 133);
                pnl.Enabled = true;
                pnl.Visible = true;
            }
        }
    }
}
