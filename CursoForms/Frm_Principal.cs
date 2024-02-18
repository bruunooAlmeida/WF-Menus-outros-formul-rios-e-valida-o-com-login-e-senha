using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_ValidaCPF_Click(object sender, EventArgs e)
        {
            Frm_ValidaCPF frm = new Frm_ValidaCPF();
            frm.ShowDialog();
        }

        private void Brn_DemostracaoKey_Click(object sender, EventArgs e)
        {
            Frm_DemonstracaoKey frm = new Frm_DemonstracaoKey();
            frm.ShowDialog();
        }

        private void Btn_HelloWord_Click(object sender, EventArgs e)
        {
            Frm_HelloWorld frm = new Frm_HelloWorld();
            frm.ShowDialog();

        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            Frm_ValidaSenha frm_ValidaSenha = new Frm_ValidaSenha();
            frm_ValidaSenha.ShowDialog();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Btn_Mascara_Click_1(object sender, EventArgs e)
        {
            Frm_Mascara frm_Mascara = new Frm_Mascara();
            frm_Mascara.ShowDialog();
        }
    }
}
