using System.Drawing;
using System.Windows.Forms;

namespace CursoWindowsForms
{
    partial class Frm_Principal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.Brn_DemostracaoKey = new System.Windows.Forms.Button();
            this.Btn_Mascara = new System.Windows.Forms.Button();
            this.Btn_ValidaSenha = new System.Windows.Forms.Button();
            this.Btn_ValidaCPF = new System.Windows.Forms.Button();
            this.Btn_Sair = new System.Windows.Forms.Button();
            this.Btn_HelloWord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Brn_DemostracaoKey
            // 
            this.Brn_DemostracaoKey.Image = global::CursoWindowsForms.Properties.Resources.number_icon_143541;
            this.Brn_DemostracaoKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Brn_DemostracaoKey.Location = new System.Drawing.Point(147, 13);
            this.Brn_DemostracaoKey.Name = "Brn_DemostracaoKey";
            this.Brn_DemostracaoKey.Size = new System.Drawing.Size(193, 48);
            this.Brn_DemostracaoKey.TabIndex = 0;
            this.Brn_DemostracaoKey.Text = "Demostração Key";
            this.Brn_DemostracaoKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Brn_DemostracaoKey.UseVisualStyleBackColor = true;
            this.Brn_DemostracaoKey.Click += new System.EventHandler(this.Brn_DemostracaoKey_Click);
            // 
            // Btn_Mascara
            // 
            this.Btn_Mascara.Image = global::CursoWindowsForms.Properties.Resources.comedymask_theapplication_comedi_2949;
            this.Btn_Mascara.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Mascara.Location = new System.Drawing.Point(346, 13);
            this.Btn_Mascara.Name = "Btn_Mascara";
            this.Btn_Mascara.Size = new System.Drawing.Size(114, 48);
            this.Btn_Mascara.TabIndex = 2;
            this.Btn_Mascara.Text = "Máscara";
            this.Btn_Mascara.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Mascara.UseVisualStyleBackColor = true;
            this.Btn_Mascara.Click += new System.EventHandler(this.Btn_Mascara_Click_1);
            // 
            // Btn_ValidaSenha
            // 
            this.Btn_ValidaSenha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Btn_ValidaSenha.Image = global::CursoWindowsForms.Properties.Resources._3775732_access_padlock_passkey_password_security_108981;
            this.Btn_ValidaSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ValidaSenha.Location = new System.Drawing.Point(147, 67);
            this.Btn_ValidaSenha.Name = "Btn_ValidaSenha";
            this.Btn_ValidaSenha.Size = new System.Drawing.Size(194, 48);
            this.Btn_ValidaSenha.TabIndex = 3;
            this.Btn_ValidaSenha.Text = "Validador de Senhas";
            this.Btn_ValidaSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ValidaSenha.UseVisualStyleBackColor = true;
            this.Btn_ValidaSenha.Click += new System.EventHandler(this.Btn_ValidaSenha_Click_1);
            // 
            // Btn_ValidaCPF
            // 
            this.Btn_ValidaCPF.Image = global::CursoWindowsForms.Properties.Resources._3643745_human_man_people_person_profile_113435;
            this.Btn_ValidaCPF.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ValidaCPF.Location = new System.Drawing.Point(11, 66);
            this.Btn_ValidaCPF.Name = "Btn_ValidaCPF";
            this.Btn_ValidaCPF.Size = new System.Drawing.Size(129, 48);
            this.Btn_ValidaCPF.TabIndex = 4;
            this.Btn_ValidaCPF.Text = "Valida CPF";
            this.Btn_ValidaCPF.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ValidaCPF.UseVisualStyleBackColor = true;
            this.Btn_ValidaCPF.Click += new System.EventHandler(this.Btn_ValidaCPF_Click_1);
            // 
            // Btn_Sair
            // 
            this.Btn_Sair.Image = global::CursoWindowsForms.Properties.Resources.signout_106525;
            this.Btn_Sair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Sair.Location = new System.Drawing.Point(347, 68);
            this.Btn_Sair.Name = "Btn_Sair";
            this.Btn_Sair.Size = new System.Drawing.Size(113, 47);
            this.Btn_Sair.TabIndex = 5;
            this.Btn_Sair.Text = "   Fechar";
            this.Btn_Sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Sair.UseVisualStyleBackColor = true;
            this.Btn_Sair.Click += new System.EventHandler(this.Btn_Sair_Click);
            // 
            // Btn_HelloWord
            // 
            this.Btn_HelloWord.Image = global::CursoWindowsForms.Properties.Resources.gesture_hi_hand_hello_interaction_greeting_icon_233463;
            this.Btn_HelloWord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_HelloWord.Location = new System.Drawing.Point(11, 12);
            this.Btn_HelloWord.Name = "Btn_HelloWord";
            this.Btn_HelloWord.Size = new System.Drawing.Size(129, 48);
            this.Btn_HelloWord.TabIndex = 1;
            this.Btn_HelloWord.Text = "Hello Word";
            this.Btn_HelloWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_HelloWord.UseVisualStyleBackColor = true;
            this.Btn_HelloWord.Click += new System.EventHandler(this.Btn_HelloWord_Click);
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 117);
            this.Controls.Add(this.Btn_Sair);
            this.Controls.Add(this.Btn_ValidaCPF);
            this.Controls.Add(this.Btn_ValidaSenha);
            this.Controls.Add(this.Btn_Mascara);
            this.Controls.Add(this.Btn_HelloWord);
            this.Controls.Add(this.Brn_DemostracaoKey);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Brn_DemostracaoKey;
        private System.Windows.Forms.Button Btn_HelloWord;
        private System.Windows.Forms.Button Btn_Mascara;
        private System.Windows.Forms.Button Btn_ValidaSenha;
        private System.Windows.Forms.Button Btn_ValidaCPF;
        private System.Windows.Forms.Button Btn_Sair;
    }
}