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
        private void btnUp_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "Upgrade")
            {
                btn.Text = "Close";
                pnlUp.Location = new Point(255, 133);
                pnlUp.Enabled = true;
                pnlUp.Visible = true;
            }
            else
            {
                btn.Text = "Upgrade";
                pnlUp.Enabled = false;
                pnlUp.Visible = false;
                pnlUp.Location = new Point(0, 0);
            }
        }
        private void btnLoja_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "Loja")
            {
                btn.Text = "Close";
                pnlLoja.Location = new Point(255, 133);
                pnlLoja.Enabled = true;
                pnlLoja.Visible = true;
            }
            else
            {
                btn.Text = "Loja";
                pnlLoja.Enabled = false;
                pnlLoja.Visible = false;
                pnlLoja.Location = new Point(0, 0);
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
            Aviso av = new Aviso();
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
            else { av.ShowDialog(); }
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
