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
        /*Index inc;
        Loja lj;
        Aviso av;
        public List<Button> clkSkin = new List<Button>();
        public List<Button> sgSkin = new List<Button>();

        public Codigo()
        {

        }
        public Codigo(Index index)
        {
            inc = index;
        }
        public Codigo(Loja loja)
        {
            lj = loja;
        }
        /*public void Upgrade(object sender, ref int ponto, ref int lvl, ref int Up)
        {
            Button btnUp = (Button)sender;
            int preco = int.Parse(inc.btnUp.Text);
            if (ponto >= preco)
            {
                ponto -= preco;
                preco *= 2;
                Up++;
                lvl++;
                inc.btnUp.Text = preco.ToString();
                inc.lblUp.Text = lvl.ToString();
           }
        }
        public void Comprar(object sender, ref int ponto, ref int Up, object local)
        {
            Button btnSkin = (Button)sender;
            string Box = "pictureBox" + btnSkin.Name.Last(), Label = "label" + btnSkin.Name.Last();
            PictureBox pbSkin = lj.Controls.Find(Box, true).FirstOrDefault() as PictureBox;
            Label lblSkin = lj.Controls.Find(Label, true).FirstOrDefault() as Label;
            int preco = int.Parse(btnSkin.Text);
            int upgrade = int.Parse(lblSkin.Text.Substring(1));

            foreach (Button item in listSkin)
            {
                item.Text = "Selecionar";
                item.Enabled = true;
            }

            if (btnSkin.Tag == "Comprado")
            {
                Up = upgrade;
                if (local is PictureBox)
                {
                    (local as PictureBox).Image = pbSkin.Image;
                }
                else { (local as Index).BackgroundImage = pbSkin.Image; }
                btnSkin.Text = "Selecionado";
                btnSkin.Enabled = false;
            }
            else if (ponto >= preco)
            {
                ponto -= preco;
                Up = upgrade;
                inc.lblPonto.Text = ponto.ToString();
                if (local is PictureBox)
                {
                    (local as PictureBox).Image = pbSkin.Image;
                }
                else { (local as Index).BackgroundImage = pbSkin.Image; }
                btnSkin.Text = "Selecionado";
                btnSkin.Tag = "Comprado";
                btnSkin.Enabled = false;
                //listSkin.Add(btnSkin);
            }
        }*/
    }
}
