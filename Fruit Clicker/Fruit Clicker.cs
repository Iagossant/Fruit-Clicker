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
    public partial class Index : Form
    {
        public int ponto = 0, cliqueUp = 10000, cliqueSkin, segundoUp, segundoSkin, clickLvl, segundoLvl;
        Loja lj;
        public Index()
        {
            InitializeComponent();
            lj = new Loja(this);
            timer.Start();
        }
        private void pbFruit_Click(object sender, EventArgs e)
        {
            ponto += cliqueUp + cliqueSkin;
            lblPonto.Text = ponto.ToString();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            ponto += segundoUp + segundoSkin;
            lblPonto.Text = ponto.ToString();
        }
        private void Interface_Click()
    {
        Button btn = (Button)sender;
        string Painel = "pnl" + btn.Name.Substring(3);
        Panel pnl = this.Controls.Find(Painel, true).FirstOrDefault() as Panel;
        Abrir_Fechar(pnl, btn, btn.Text);
    }

    private void Abrir_Fechar(Panel pnl, Button btn, string btnName)
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
        private void btnConquista_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Conquista cqt = new Conquista(this);
            cqt.ShowDialog();
        }
        private void btnSkin_Click(object sender, EventArgs e)
        {
            lj.pnlSkin.Visible = true;
            lj.pnlSkin.Enabled = true;
            lj.ShowDialog();
        }
        private void btnBackground_Click(object sender, EventArgs e)
        {
            lj.ShowDialog();
        }
        private void btnUpgradeClick_Click(object sender, EventArgs e)
        {
            Upgrade(sender, ref ponto, ref clickLvl, ref cliqueUp);
        }
        private void btnUpgradeTimer_Click(object sender, EventArgs e)
        {
            Upgrade(sender, ref ponto, ref segundoLvl, ref segundoUp);
        }
        private void Upgrade(object sender, ref int ponto, ref int lvl, ref int Up)
        {
            Button btnUp = (Button)sender;
            int preco = int.Parse(btnUp.Text);
            if (ponto >= preco)
            {
                ponto -= preco;
                preco *= 2;
                Up++;
                lvl++;
                lblPonto.Text = ponto.ToString();
                btnUp.Text = preco.ToString();
                //inc.lblUp.Text = lvl.ToString();
            }
            else { new Aviso().ShowDialog(); }
        }
        private void Index_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Conquistas = null;
            Properties.Settings.Default.btnText = null;
            Properties.Settings.Default.btnBool = null;
            Properties.Settings.Default.Save();
        }
    }
}
