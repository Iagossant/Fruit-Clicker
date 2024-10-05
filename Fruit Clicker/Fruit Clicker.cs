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
        Loja loja;
        Codigo codigo;
        public Index()
        {
            InitializeComponent();
            loja = new Loja(this);
            codigo = new Codigo(this, loja);
            timer.Start();
        }
        private void btnSkin_Click(object sender, EventArgs e)
        {
            loja.pnlSkin.Visible = loja.pnlSkin.Enabled = true;
            loja.Show();
        }
        private void btnBackground_Click(object sender, EventArgs e)
        {
            loja.pnlSkin.Visible = loja.pnlSkin.Enabled = true;
            loja.Show();
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
        private void Interface_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string Painel = "pnl" + btn.Name.Substring(3);
            Panel pnl = this.Controls.Find(Painel, true).FirstOrDefault() as Panel;
            codigo.Abrir_Fechar(pnl, btn, btn.Tag.ToString());
        }
        private void btnUpgradeClick_Click(object sender, EventArgs e)
        {
            Button btnUp = (Button)sender;
            codigo.Upgrade(btnUp, ref ponto, ref clickLvl, ref cliqueUp);
        }
        private void btnUpgradeTimer_Click(object sender, EventArgs e)
        {
            Button btnUp = (Button)sender;
            codigo.Upgrade(btnUp, ref ponto, ref segundoLvl, ref segundoUp);
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
