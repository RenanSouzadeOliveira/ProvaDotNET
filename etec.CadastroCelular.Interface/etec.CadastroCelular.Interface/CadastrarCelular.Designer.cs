namespace etec.CadastroCelular.Interface
{
    partial class CadastrarCelular
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
            this.macAdress = new System.Windows.Forms.Label();
            this.txbMacAdress = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.lblModelo = new System.Windows.Forms.Label();
            this.txbModelo = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.CPF = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // macAdress
            // 
            this.macAdress.AutoSize = true;
            this.macAdress.Location = new System.Drawing.Point(8, 38);
            this.macAdress.Name = "macAdress";
            this.macAdress.Size = new System.Drawing.Size(77, 13);
            this.macAdress.TabIndex = 0;
            this.macAdress.Text = "MAC ADRESS";
            // 
            // txbMacAdress
            // 
            this.txbMacAdress.Location = new System.Drawing.Point(96, 35);
            this.txbMacAdress.Name = "txbMacAdress";
            this.txbMacAdress.Size = new System.Drawing.Size(100, 20);
            this.txbMacAdress.TabIndex = 1;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(8, 64);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Marca";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(96, 61);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(100, 20);
            this.txbMarca.TabIndex = 3;
            // 
            // lblModelo
            // 
            this.lblModelo.AutoSize = true;
            this.lblModelo.Location = new System.Drawing.Point(8, 90);
            this.lblModelo.Name = "lblModelo";
            this.lblModelo.Size = new System.Drawing.Size(42, 13);
            this.lblModelo.TabIndex = 4;
            this.lblModelo.Text = "Modelo";
            // 
            // txbModelo
            // 
            this.txbModelo.Location = new System.Drawing.Point(96, 87);
            this.txbModelo.Name = "txbModelo";
            this.txbModelo.Size = new System.Drawing.Size(100, 20);
            this.txbModelo.TabIndex = 5;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(105, 113);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.Location = new System.Drawing.Point(8, 9);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(27, 13);
            this.CPF.TabIndex = 7;
            this.CPF.Text = "CPF";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(96, 6);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(100, 20);
            this.txbCPF.TabIndex = 8;
            // 
            // CadastrarCelular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 136);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txbModelo);
            this.Controls.Add(this.lblModelo);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txbMacAdress);
            this.Controls.Add(this.macAdress);
            this.Name = "CadastrarCelular";
            this.Text = "CadastrarCelular";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label macAdress;
        private System.Windows.Forms.TextBox txbMacAdress;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Label lblModelo;
        private System.Windows.Forms.TextBox txbModelo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.TextBox txbCPF;
    }
}