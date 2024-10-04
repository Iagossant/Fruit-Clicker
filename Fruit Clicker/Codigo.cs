using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_Clicker
{
    public class Codigo
    {
        Index inicio;
        Loja loja;
        public Codigo(Index i, Loja lj)
        {
            inicio = i;
            loja = lj;
        }
        public void Comprar(Button btnSkin, Panel painel, object local, ref int up, ref int ponto)
        {
            string Box = "pbSkin" + btnSkin.Name.Last(), Label = "lblSkin" + btnSkin.Name.Last();
            PictureBox pbSkin = loja.Controls.Find(Box, true).FirstOrDefault() as PictureBox;
            Label lblSkin = loja.Controls.Find(Label, true).FirstOrDefault() as Label;

            int.TryParse(btnSkin.Text, out int preco);
            int clique = int.Parse(lblSkin.Text.Substring(1));

            if (btnSkin.Text == "Selecionar" || ponto >= preco)
            {
                foreach (Button item in painel.Controls.OfType<Button>())
                {
                    if (item.Text == "Selecionado")
                    {
                        item.Enabled = true;
                        item.Text = "Selecionar";
                    }
                }
            }

            if (btnSkin.Text == "Selecionar" || ponto >= preco)
            {
                if (btnSkin.Text != "Selecionar")
                {
                    ponto -= preco;
                    inicio.lblPonto.Text = ponto.ToString();
                }
                up = clique;
                if (local is PictureBox pb) { pb.Image = pbSkin.Image; }
                else if (local is Index index) { index.BackgroundImage = pbSkin.Image; }
                btnSkin.Text = "Selecionado";
                btnSkin.Enabled = false;
                loja.SalvarBotoes();
            }
            else
            {
                new Aviso().ShowDialog();
            }
        }
        public void Upgrade(Button btnUp, ref int ponto, ref int lvl, ref int Up)
        {
            string Preco = "lblPreco" + btnUp.Name.Last(), Level = "lblLevel" + btnUp.Name.Last();
            Label lblPreco = inicio.Controls.Find(Preco, true).FirstOrDefault() as Label;
            Label lblLevel = inicio.Controls.Find(Level, true).FirstOrDefault() as Label;
            int preco = int.Parse(lblPreco.Text);
            if (ponto >= preco)
            {
                ponto -= preco;
                preco *= 2;
                Up++;
                lvl++;
                lblPreco. Text = preco.ToString();
                lblLevel.Text = $"Level {lvl}";
                inicio.lblPonto.Text = ponto.ToString();
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