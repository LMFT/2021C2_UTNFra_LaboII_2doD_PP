
namespace PPL2
{
    partial class FrmLlamada
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
            this.txtCodigoPais = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblCodigoPais = new System.Windows.Forms.Label();
            this.txtCodigoArea = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblCodigoArea = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCodigoPais
            // 
            this.txtCodigoPais.Location = new System.Drawing.Point(28, 32);
            this.txtCodigoPais.Name = "txtCodigoPais";
            this.txtCodigoPais.Size = new System.Drawing.Size(86, 23);
            this.txtCodigoPais.TabIndex = 0;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(28, 88);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(145, 41);
            this.btnIngresar.TabIndex = 3;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblCodigoPais
            // 
            this.lblCodigoPais.AutoSize = true;
            this.lblCodigoPais.Location = new System.Drawing.Point(28, 9);
            this.lblCodigoPais.Name = "lblCodigoPais";
            this.lblCodigoPais.Size = new System.Drawing.Size(56, 15);
            this.lblCodigoPais.TabIndex = 5;
            this.lblCodigoPais.Text = "Cod. Pais";
            // 
            // txtCodigoArea
            // 
            this.txtCodigoArea.Location = new System.Drawing.Point(146, 32);
            this.txtCodigoArea.Name = "txtCodigoArea";
            this.txtCodigoArea.Size = new System.Drawing.Size(72, 23);
            this.txtCodigoArea.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(241, 32);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(130, 23);
            this.txtNumero.TabIndex = 2;
            // 
            // lblCodigoArea
            // 
            this.lblCodigoArea.AutoSize = true;
            this.lblCodigoArea.Location = new System.Drawing.Point(146, 9);
            this.lblCodigoArea.Name = "lblCodigoArea";
            this.lblCodigoArea.Size = new System.Drawing.Size(59, 15);
            this.lblCodigoArea.TabIndex = 6;
            this.lblCodigoArea.Text = "Cod. Area";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(241, 9);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(51, 15);
            this.lblNumero.TabIndex = 7;
            this.lblNumero.Text = "Numero";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(224, 88);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(147, 41);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FrmLlamada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(408, 150);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblCodigoArea);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtCodigoArea);
            this.Controls.Add(this.lblCodigoPais);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCodigoPais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLlamada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ingresar Numero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCodigoPais;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblCodigoPais;
        private System.Windows.Forms.TextBox txtCodigoArea;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblCodigoArea;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Button btnCancelar;
    }
}