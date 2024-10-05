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
        public void Comprar(object objeto, Panel painel, object local, ref int up, ref int ponto)
        {
            if(objeto is Button btnSkin)
            {
                PictureBox pbSkin = this.Parent as PictureBox;
                Label lblSkin = pbSkin.Controls["lblSkin" + btnSkin.Name.Last()] as Label;
            }
            else if (objeto is PictureBox pbSkin)
            {
                Button btnSkin = this.Controls["btnSkin" + pbSkin.Name.Last()] as Button;
                Label lblSkin = this.Controls["lblSkin" + pbSkin.Name.Last()] as Label;
            }

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
                return;
            }
            new Aviso().ShowDialog();
        }
        public void Upgrade(Button btnUp, ref int ponto, ref int lvl, ref int Up)
        {
            Label lblPreco = this.Controls[$"lblPreco{btnUp.Name.Last()}"] as Label;
            Label lblLevel = this.Controls["lblLevel" + btnUp.Name.Last()]as Label;
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
                return;
            }
            new Aviso().ShowDialog();
        }
        public void Abrir_Fechar(Panel pnl, Button btn, string btnName)
        {
            if (btn.Text == "Fechar")
            {
                btn.Text = btnName;
                pnl.Enabled = false;
                pnl.Visible = false;
                pnl.Location = new Point(0, 0);
                return;
            }
            btn.Text = "Fechar";
            pnl.Location = new Point(255, 133);
            pnl.Enabled = true;
            pnl.Visible = true;
        }
    }
}
