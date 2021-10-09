
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
            this.btnListarComputadora = new System.Windows.Forms.Button();
            this.btnListarTelefono = new System.Windows.Forms.Button();
            this.btnLlamadas = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.gpbCajaDatos = new System.Windows.Forms.GroupBox();
            this.lblTelefonos = new System.Windows.Forms.Label();
            this.lblComputadoras = new System.Windows.Forms.Label();
            this.lblGanancias = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoLlamada)).BeginInit();
            this.gpbCajaDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDispositivos
            // 
            this.dgvDispositivos.AllowUserToAddRows = false;
            this.dgvDispositivos.AllowUserToDeleteRows = false;
            this.dgvDispositivos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDispositivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispositivos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDispositivo,
            this.tiempoUso});
            this.dgvDispositivos.Location = new System.Drawing.Point(301, 12);
            this.dgvDispositivos.Name = "dgvDispositivos";
            this.dgvDispositivos.ReadOnly = true;
            this.dgvDispositivos.RowTemplate.Height = 25;
            this.dgvDispositivos.Size = new System.Drawing.Size(443, 229);
            this.dgvDispositivos.TabIndex = 0;
            // 
            // idDispositivo
            // 
            this.idDispositivo.HeaderText = "ID DIspositivo";
            this.idDispositivo.Name = "idDispositivo";
            this.idDispositivo.ReadOnly = true;
            this.idDispositivo.Width = 200;
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
            this.dgvTipoLlamada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTipoLlamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoLlamada.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tipoLlamada,
            this.horas,
            this.Minutos,
            this.ganancias});
            this.dgvTipoLlamada.Location = new System.Drawing.Point(300, 12);
            this.dgvTipoLlamada.Name = "dgvTipoLlamada";
            this.dgvTipoLlamada.RowTemplate.Height = 25;
            this.dgvTipoLlamada.Size = new System.Drawing.Size(443, 229);
            this.dgvTipoLlamada.TabIndex = 1;
            // 
            // tipoLlamada
            // 
            this.tipoLlamada.HeaderText = "Tipo de Llamada";
            this.tipoLlamada.Name = "tipoLlamada";
            this.tipoLlamada.ReadOnly = true;
            // 
            // horas
            // 
            this.horas.HeaderText = "Horas";
            this.horas.Name = "horas";
            this.horas.ReadOnly = true;
            // 
            // Minutos
            // 
            this.Minutos.HeaderText = "Minutos";
            this.Minutos.Name = "Minutos";
            this.Minutos.ReadOnly = true;
            // 
            // ganancias
            // 
            this.ganancias.HeaderText = "Ganancias";
            this.ganancias.Name = "ganancias";
            this.ganancias.ReadOnly = true;
            // 
            // btnListarComputadora
            // 
            this.btnListarComputadora.Location = new System.Drawing.Point(17, 97);
            this.btnListarComputadora.Name = "btnListarComputadora";
            this.btnListarComputadora.Size = new System.Drawing.Size(180, 40);
            this.btnListarComputadora.TabIndex = 2;
            this.btnListarComputadora.Text = "Listar computadoras por tiempo de uso";
            this.btnListarComputadora.UseVisualStyleBackColor = true;
            this.btnListarComputadora.Click += new System.EventHandler(this.btnListarComputadora_Click);
            // 
            // btnListarTelefono
            // 
            this.btnListarTelefono.Location = new System.Drawing.Point(17, 155);
            this.btnListarTelefono.Name = "btnListarTelefono";
            this.btnListarTelefono.Size = new System.Drawing.Size(180, 40);
            this.btnListarTelefono.TabIndex = 3;
            this.btnListarTelefono.Text = "Listar telefonos por tiempo de uso";
            this.btnListarTelefono.UseVisualStyleBackColor = true;
            this.btnListarTelefono.Click += new System.EventHandler(this.btnListarTelefono_Click);
            // 
            // btnLlamadas
            // 
            this.btnLlamadas.Location = new System.Drawing.Point(17, 212);
            this.btnLlamadas.Name = "btnLlamadas";
            this.btnLlamadas.Size = new System.Drawing.Size(180, 40);
            this.btnLlamadas.TabIndex = 4;
            this.btnLlamadas.Text = "Mostrar detalles de llamadas";
            this.btnLlamadas.UseVisualStyleBackColor = true;
            this.btnLlamadas.Click += new System.EventHandler(this.btnLlamadas_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnVolver.Location = new System.Drawing.Point(17, 360);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(180, 40);
            this.btnVolver.TabIndex = 5;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(17, 40);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(180, 40);
            this.btnMostrar.TabIndex = 6;
            this.btnMostrar.Text = "Mostrar todas las operaciones";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // gpbCajaDatos
            // 
            this.gpbCajaDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCajaDatos.Controls.Add(this.lblTelefonos);
            this.gpbCajaDatos.Controls.Add(this.lblComputadoras);
            this.gpbCajaDatos.Controls.Add(this.lblGanancias);
            this.gpbCajaDatos.Location = new System.Drawing.Point(301, 269);
            this.gpbCajaDatos.Name = "gpbCajaDatos";
            this.gpbCajaDatos.Size = new System.Drawing.Size(384, 107);
            this.gpbCajaDatos.TabIndex = 7;
            this.gpbCajaDatos.TabStop = false;
            this.gpbCajaDatos.Text = "Otros datos:";
            // 
            // lblTelefonos
            // 
            this.lblTelefonos.AutoSize = true;
            this.lblTelefonos.Location = new System.Drawing.Point(6, 82);
            this.lblTelefonos.Name = "lblTelefonos";
            this.lblTelefonos.Size = new System.Drawing.Size(127, 15);
            this.lblTelefonos.TabIndex = 2;
            this.lblTelefonos.Text = "Ingresos por telefonos:";
            // 
            // lblComputadoras
            // 
            this.lblComputadoras.AutoSize = true;
            this.lblComputadoras.Location = new System.Drawing.Point(6, 56);
            this.lblComputadoras.Name = "lblComputadoras";
            this.lblComputadoras.Size = new System.Drawing.Size(155, 15);
            this.lblComputadoras.TabIndex = 1;
            this.lblComputadoras.Text = "Ingresos por computadoras:";
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Location = new System.Drawing.Point(6, 30);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(102, 15);
            this.lblGanancias.TabIndex = 0;
            this.lblGanancias.Text = "Ganancias totales:";
            // 
            // FormHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 412);
            this.Controls.Add(this.gpbCajaDatos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dgvTipoLlamada);
            this.Controls.Add(this.btnLlamadas);
            this.Controls.Add(this.btnListarTelefono);
            this.Controls.Add(this.btnListarComputadora);
            this.Controls.Add(this.dgvDispositivos);
            this.MinimumSize = new System.Drawing.Size(771, 451);
            this.Name = "FormHistorial";
            this.Text = "Historial";
            this.Load += new System.EventHandler(this.FormHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispositivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoLlamada)).EndInit();
            this.gpbCajaDatos.ResumeLayout(false);
            this.gpbCajaDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDispositivos;
        private System.Windows.Forms.DataGridView dgvTipoLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoLlamada;
        private System.Windows.Forms.DataGridViewTextBoxColumn horas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Minutos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ganancias;
        private System.Windows.Forms.Button btnListarComputadora;
        private System.Windows.Forms.Button btnListarTelefono;
        private System.Windows.Forms.Button btnLlamadas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.GroupBox gpbCajaDatos;
        private System.Windows.Forms.Label lblTelefonos;
        private System.Windows.Forms.Label lblComputadoras;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDispositivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoUso;
    }
}