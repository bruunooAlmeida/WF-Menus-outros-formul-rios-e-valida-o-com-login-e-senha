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
            Brn_DemostracaoKey = new Button();
            Btn_HelloWord = new Button();
            Btn_Mascara = new Button();
            Btn_ValidaSenha = new Button();
            Btn_ValidaCPF = new Button();
            Btn_Sair = new Button();
            SuspendLayout();
            // 
            // Brn_DemostracaoKey
            // 
            Brn_DemostracaoKey.Image = (Image)resources.GetObject("Brn_DemostracaoKey.Image");
            Brn_DemostracaoKey.ImageAlign = ContentAlignment.MiddleLeft;
            Brn_DemostracaoKey.Location = new Point(129, 12);
            Brn_DemostracaoKey.Name = "Brn_DemostracaoKey";
            Brn_DemostracaoKey.Size = new Size(150, 45);
            Brn_DemostracaoKey.TabIndex = 0;
            Brn_DemostracaoKey.Text = "Demostração Key";
            Brn_DemostracaoKey.TextAlign = ContentAlignment.MiddleRight;
            Brn_DemostracaoKey.UseVisualStyleBackColor = true;
            Brn_DemostracaoKey.Click += Brn_DemostracaoKey_Click;
            // 
            // Btn_HelloWord
            // 
            Btn_HelloWord.Image = (Image)resources.GetObject("Btn_HelloWord.Image");
            Btn_HelloWord.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_HelloWord.Location = new Point(10, 11);
            Btn_HelloWord.Name = "Btn_HelloWord";
            Btn_HelloWord.Size = new Size(113, 45);
            Btn_HelloWord.TabIndex = 1;
            Btn_HelloWord.Text = "Hello Word";
            Btn_HelloWord.TextAlign = ContentAlignment.MiddleRight;
            Btn_HelloWord.UseVisualStyleBackColor = true;
            Btn_HelloWord.Click += Btn_HelloWord_Click;
            // 
            // Btn_Mascara
            // 
            Btn_Mascara.Image = (Image)resources.GetObject("Btn_Mascara.Image");
            Btn_Mascara.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Mascara.Location = new Point(285, 11);
            Btn_Mascara.Name = "Btn_Mascara";
            Btn_Mascara.Size = new Size(100, 45);
            Btn_Mascara.TabIndex = 2;
            Btn_Mascara.Text = "Máscara";
            Btn_Mascara.TextAlign = ContentAlignment.MiddleRight;
            Btn_Mascara.UseVisualStyleBackColor = true;
            Btn_Mascara.Click += Btn_Mascara_Click_1;
            // 
            // Btn_ValidaSenha
            // 
            Btn_ValidaSenha.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            Btn_ValidaSenha.Image = (Image)resources.GetObject("Btn_ValidaSenha.Image");
            Btn_ValidaSenha.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_ValidaSenha.Location = new Point(129, 63);
            Btn_ValidaSenha.Name = "Btn_ValidaSenha";
            Btn_ValidaSenha.Size = new Size(150, 45);
            Btn_ValidaSenha.TabIndex = 3;
            Btn_ValidaSenha.Text = "Validador de Senhas";
            Btn_ValidaSenha.TextAlign = ContentAlignment.MiddleRight;
            Btn_ValidaSenha.UseVisualStyleBackColor = true;
            Btn_ValidaSenha.Click += Btn_ValidaSenha_Click;
            // 
            // Btn_ValidaCPF
            // 
            Btn_ValidaCPF.Image = (Image)resources.GetObject("Btn_ValidaCPF.Image");
            Btn_ValidaCPF.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_ValidaCPF.Location = new Point(10, 62);
            Btn_ValidaCPF.Name = "Btn_ValidaCPF";
            Btn_ValidaCPF.Size = new Size(113, 45);
            Btn_ValidaCPF.TabIndex = 4;
            Btn_ValidaCPF.Text = "Valida CPF";
            Btn_ValidaCPF.TextAlign = ContentAlignment.MiddleRight;
            Btn_ValidaCPF.UseVisualStyleBackColor = true;
            Btn_ValidaCPF.Click += Btn_ValidaCPF_Click;
            // 
            // Btn_Sair
            // 
            Btn_Sair.Image = (Image)resources.GetObject("Btn_Sair.Image");
            Btn_Sair.ImageAlign = ContentAlignment.MiddleLeft;
            Btn_Sair.Location = new Point(286, 63);
            Btn_Sair.Name = "Btn_Sair";
            Btn_Sair.Size = new Size(99, 44);
            Btn_Sair.TabIndex = 5;
            Btn_Sair.Text = "   Fechar";
            Btn_Sair.TextAlign = ContentAlignment.MiddleRight;
            Btn_Sair.UseVisualStyleBackColor = true;
            Btn_Sair.Click += Btn_Sair_Click;
            // 
            // Frm_Principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 119);
            Controls.Add(Btn_Sair);
            Controls.Add(Btn_ValidaCPF);
            Controls.Add(Btn_ValidaSenha);
            Controls.Add(Btn_Mascara);
            Controls.Add(Btn_HelloWord);
            Controls.Add(Brn_DemostracaoKey);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_Principal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal";
            ResumeLayout(false);
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