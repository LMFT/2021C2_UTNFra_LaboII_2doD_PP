
namespace PPL2
{
    partial class FormHistorial
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
            this.dgvDispositivos = new System.Windows.Forms.DataGridView();
            this.idDispositivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoUso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTipoLlamada = new System.Windows.Forms.DataGridView();
            this.tipoLlamada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Minutos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganancias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoLlamada)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDispositivos
            // 
            this.dgvDispositivos.AllowUserToAddRows = false;
            this.dgvDispositivos.AllowUserToDeleteRows = false;
            this.dgvDispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispositivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDispositivo,
            this.tiempoUso});
            this.dgvDispositivos.Location = new System.Drawing.Point(42, 12);
            this.dgvDispositivos.Name = "dgvDispositivos";
            this.dgvDispositivos.ReadOnly = true;
            this.dgvDispositivos.RowTemplate.Height = 25;
            this.dgvDispositivos.Size = new System.Drawing.Size(746, 233);
            this.dgvDispositivos.TabIndex = 0;
            // 
            // idDispositivo
            // 
            this.idDispositivo.HeaderText = "ID DIspositivo";
            this.idDispositivo.Name = "idDispositivo";
            this.idDispositivo.ReadOnly = true;
            this.idDispositivo.Width = 400;
            // 
            // tiempoUso
            // 
            this.tiempoUso.HeaderText = "Tiempo de Uso";
            this.tiempoUso.Name = "tiempoUso";
            this.tiempoUso.ReadOnly = true;
            this.tiempoUso.Width = 300;
            // 
            // dgvTipoLlamada
            // 
            this.dgvTipoLlamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoLlamada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoLlamada,
            this.horas,
            this.Minutos,
            this.ganancias});
            this.dgvTipoLlamada.Location = new System.Drawing.Point(42, 12);
            this.dgvTipoLlamada.Name = "dgvTipoLlamada";
            this.dgvTipoLlamada.RowTemplate.Height = 25;
            this.dgvTipoLlamada.Size = new System.Drawing.Size(746, 233);
            this.dgvTipoLlamada.TabIndex = 1;
            // 
            // tipoLlamada
            // 
            this.tipoLlamada.HeaderText = "Tipo de Llamada";
            this.tipoLlamada.Name = "tipoLlamada";
            this.tipoLlamada.ReadOnly = true;
            this.tipoLlamada.Width = 300;
            // 
            // horas
            // 
            this.horas.HeaderText = "Horas";
            this.horas.Name = "horas";
            this.horas.ReadOnly = true;
            this.horas.Width = 150;
            // 
            // Minutos
            // 
            this.Minutos.HeaderText = "Minutos";
            this.Minutos.Name = "Minutos";
            this.Minutos.ReadOnly = true;
            this.Minutos.Width = 150;
            // 
            // ganancias
            // 
            this.ganancias.HeaderText = "Ganancias";
            this.ganancias.Name = "ganancias";
            this.ganancias.ReadOnly = true;
            this.ganancias.Width = 150;
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTipoLlamada);
            this.Controls.Add(this.dgvDispositivos);
            this.Name = "FormHistorial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.FormHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoLlamada)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDispositivos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoUso;
        private System.Windows.Forms.DataGridView dgvTipoLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganancias;
    }
}