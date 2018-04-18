namespace etec.CadastroCelular.Interface
{
    partial class Consultar
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
            this.dtClienteCelular = new System.Windows.Forms.DataGridView();
            this.btnCadClie = new System.Windows.Forms.Button();
            this.btnCadCelu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtClienteCelular)).BeginInit();
            this.SuspendLayout();
            // 
            // dtClienteCelular
            // 
            this.dtClienteCelular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClienteCelular.Location = new System.Drawing.Point(22, 25);
            this.dtClienteCelular.Name = "dtClienteCelular";
            this.dtClienteCelular.Size = new System.Drawing.Size(493, 145);
            this.dtClienteCelular.TabIndex = 0;
            // 
            // btnCadClie
            // 
            this.btnCadClie.Location = new System.Drawing.Point(57, 177);
            this.btnCadClie.Name = "btnCadClie";
            this.btnCadClie.Size = new System.Drawing.Size(101, 23);
            this.btnCadClie.TabIndex = 1;
            this.btnCadClie.Text = "Cadastrar Clientes";
            this.btnCadClie.UseVisualStyleBackColor = true;
            this.btnCadClie.Click += new System.EventHandler(this.btnCadClie_Click);
            // 
            // btnCadCelu
            // 
            this.btnCadCelu.Location = new System.Drawing.Point(179, 177);
            this.btnCadCelu.Name = "btnCadCelu";
            this.btnCadCelu.Size = new System.Drawing.Size(97, 23);
            this.btnCadCelu.TabIndex = 2;
            this.btnCadCelu.Text = "Cadastrar Celular";
            this.btnCadCelu.UseVisualStyleBackColor = true;
            this.btnCadCelu.Click += new System.EventHandler(this.btnCadCelu_Click);
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 212);
            this.Controls.Add(this.btnCadCelu);
            this.Controls.Add(this.btnCadClie);
            this.Controls.Add(this.dtClienteCelular);
            this.Name = "Consultar";
            this.Text = "Consultar";
            this.Load += new System.EventHandler(this.Consultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtClienteCelular)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtClienteCelular;
        private System.Windows.Forms.Button btnCadClie;
        private System.Windows.Forms.Button btnCadCelu;
    }
}