namespace etec.CadastroCelular.Interface
{
    partial class FrmPrincipal
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lblCadastrarCli = new System.Windows.Forms.ToolStripLabel();
            this.lblCadastrarCel = new System.Windows.Forms.ToolStripLabel();
            this.lblConsultar = new System.Windows.Forms.ToolStripLabel();
            this.lblSair = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblCadastrarCli,
            this.lblCadastrarCel,
            this.lblConsultar,
            this.lblSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(850, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lblCadastrarCli
            // 
            this.lblCadastrarCli.Name = "lblCadastrarCli";
            this.lblCadastrarCli.Size = new System.Drawing.Size(97, 22);
            this.lblCadastrarCli.Text = "Cadastrar Cliente";
            this.lblCadastrarCli.Click += new System.EventHandler(this.lblCadastrarCli_Click);
            // 
            // lblCadastrarCel
            // 
            this.lblCadastrarCel.Name = "lblCadastrarCel";
            this.lblCadastrarCel.Size = new System.Drawing.Size(97, 22);
            this.lblCadastrarCel.Text = "Cadastrar Celular";
            this.lblCadastrarCel.Click += new System.EventHandler(this.lblCadastrarCel_Click);
            // 
            // lblConsultar
            // 
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(58, 22);
            this.lblConsultar.Text = "Consultar";
            this.lblConsultar.Click += new System.EventHandler(this.lblConsultar_Click);
            // 
            // lblSair
            // 
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(26, 22);
            this.lblSair.Text = "Sair";
            this.lblSair.Click += new System.EventHandler(this.lblSair_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 472);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Celulares";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel lblCadastrarCli;
        private System.Windows.Forms.ToolStripLabel lblCadastrarCel;
        private System.Windows.Forms.ToolStripLabel lblConsultar;
        private System.Windows.Forms.ToolStripLabel lblSair;
    }
}

