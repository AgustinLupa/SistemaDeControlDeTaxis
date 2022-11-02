namespace ProyectoRamaYMauri.Vistas
{
    partial class CambiarDisponibilidad
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
            this.lbAutoNoDispo = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.pDestino = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLugarDeDestino = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelarPan = new System.Windows.Forms.Button();
            this.pDestino.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbAutoNoDispo
            // 
            this.lbAutoNoDispo.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAutoNoDispo.FormattingEnabled = true;
            this.lbAutoNoDispo.HorizontalScrollbar = true;
            this.lbAutoNoDispo.ItemHeight = 17;
            this.lbAutoNoDispo.Location = new System.Drawing.Point(65, 56);
            this.lbAutoNoDispo.Name = "lbAutoNoDispo";
            this.lbAutoNoDispo.Size = new System.Drawing.Size(636, 242);
            this.lbAutoNoDispo.TabIndex = 0;
            this.lbAutoNoDispo.SelectedIndexChanged += new System.EventHandler(this.lbAutoNoDispo_SelectedIndexChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gold;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnCancelar.Location = new System.Drawing.Point(586, 316);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(115, 46);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // pDestino
            // 
            this.pDestino.BackgroundImage = global::ProyectoRamaYMauri.Properties.Resources.fondoMadera;
            this.pDestino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pDestino.Controls.Add(this.btnCancelarPan);
            this.pDestino.Controls.Add(this.btnGuardar);
            this.pDestino.Controls.Add(this.txtLugarDeDestino);
            this.pDestino.Controls.Add(this.label1);
            this.pDestino.Enabled = false;
            this.pDestino.Location = new System.Drawing.Point(55, 36);
            this.pDestino.Name = "pDestino";
            this.pDestino.Size = new System.Drawing.Size(646, 391);
            this.pDestino.TabIndex = 17;
            this.pDestino.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(93, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lugar de destino";
            // 
            // txtLugarDeDestino
            // 
            this.txtLugarDeDestino.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLugarDeDestino.Location = new System.Drawing.Point(336, 132);
            this.txtLugarDeDestino.Name = "txtLugarDeDestino";
            this.txtLugarDeDestino.Size = new System.Drawing.Size(161, 29);
            this.txtLugarDeDestino.TabIndex = 1;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkRed;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Gold;
            this.btnGuardar.Location = new System.Drawing.Point(336, 280);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 58);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelarPan
            // 
            this.btnCancelarPan.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancelarPan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPan.ForeColor = System.Drawing.Color.Gold;
            this.btnCancelarPan.Location = new System.Drawing.Point(488, 280);
            this.btnCancelarPan.Name = "btnCancelarPan";
            this.btnCancelarPan.Size = new System.Drawing.Size(111, 58);
            this.btnCancelarPan.TabIndex = 3;
            this.btnCancelarPan.Text = "Cancelar";
            this.btnCancelarPan.UseVisualStyleBackColor = false;
            this.btnCancelarPan.Click += new System.EventHandler(this.btnCancelarPan_Click);
            // 
            // CambiarDisponibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoRamaYMauri.Properties.Resources.fondoMadera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(754, 481);
            this.ControlBox = false;
            this.Controls.Add(this.pDestino);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lbAutoNoDispo);
            this.Name = "CambiarDisponibilidad";
            this.Text = "Cambiar Disponibilidad";
            this.Load += new System.EventHandler(this.CambiarDisponibilidad_Load);
            this.pDestino.ResumeLayout(false);
            this.pDestino.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAutoNoDispo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Panel pDestino;
        private System.Windows.Forms.Button btnCancelarPan;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtLugarDeDestino;
        private System.Windows.Forms.Label label1;
    }
}