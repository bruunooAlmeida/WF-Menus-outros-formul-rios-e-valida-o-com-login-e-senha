using CursoWindowsFormsBiblioteca;
using System;
using System.Windows.Forms;


namespace CursoWindowsForms
{
    public partial class Frm_ValidaCPF : Form
    {
        public Frm_ValidaCPF()
        {
            InitializeComponent();
        }
       

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            
            Msk_CPF.Text = "";
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {
            bool validaCPF = false;
            validaCPF = Cls_Uteis.Valida(Msk_CPF.Text);
            
        }
    }
}
