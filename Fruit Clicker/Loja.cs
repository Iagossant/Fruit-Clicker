﻿using System;
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
            codigo = new Codigo(I, this);
            btnList = new List<Button> { btnSkin1, btnSkin2, btnSkin3, btnSkin4, btnSkin5, btnSkin4, btnSkin7, btnSkin8 };
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
            Button button = (Button)sender;
            codigo.Comprar(button, pnlSkin, I.pbFruit, ref I.cliqueSkin, ref I.ponto);
        }
        private void SecondSkin_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            codigo.Comprar(button, pnlSkin, I, ref I.segundoSkin, ref I.ponto);
        }
        private void pbFechar_Click(object sender, EventArgs e)
        {
            I.btnLoja.Text = "Loja";
            I.pnlLoja.Enabled = false;
            I.pnlLoja.Visible = false;
            I.pnlLoja.Location = new Point(0, 0);
            pnlSkin.Enabled = false;
            pnlSkin.Visible = false;
            this.Hide();
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