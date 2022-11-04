namespace ProyectoRamaYMauri
{
    partial class MainForm
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
            this.btnAuto = new System.Windows.Forms.Button();
            this.btnViajeRealizado = new System.Windows.Forms.Button();
            this.lbViajes = new System.Windows.Forms.ListBox();
            this.pViajes = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCambiarDispo = new System.Windows.Forms.Button();
            this.pViajes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAuto
            // 
            this.btnAuto.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAuto.Location = new System.Drawing.Point(162, 74);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(194, 63);
            this.btnAuto.TabIndex = 0;
            this.btnAuto.Text = "Autos disponibles";
            this.btnAuto.UseVisualStyleBackColor = false;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            // 
            // btnViajeRealizado
            // 
            this.btnViajeRealizado.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnViajeRealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnViajeRealizado.Location = new System.Drawing.Point(162, 158);
            this.btnViajeRealizado.Name = "btnViajeRealizado";
            this.btnViajeRealizado.Size = new System.Drawing.Size(194, 63);
            this.btnViajeRealizado.TabIndex = 1;
            this.btnViajeRealizado.Text = "Viajes realizados";
            this.btnViajeRealizado.UseVisualStyleBackColor = false;
            this.btnViajeRealizado.Click += new System.EventHandler(this.btnViajeRealizado_Click);
            // 
            // lbViajes
            // 
            this.lbViajes.Font = new System.Drawing.Font("Cooper Black", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbViajes.FormattingEnabled = true;
            this.lbViajes.HorizontalScrollbar = true;
            this.lbViajes.ItemHeight = 17;
            this.lbViajes.Location = new System.Drawing.Point(3, 3);
            this.lbViajes.Name = "lbViajes";
            this.lbViajes.Size = new System.Drawing.Size(443, 310);
            this.lbViajes.TabIndex = 2;
            this.lbViajes.SelectedIndexChanged += new System.EventHandler(this.lbViajes_SelectedIndexChanged);
            // 
            // pViajes
            // 
            this.pViajes.BackColor = System.Drawing.Color.Sienna;
            this.pViajes.Controls.Add(this.btnCancel);
            this.pViajes.Controls.Add(this.lbViajes);
            this.pViajes.Enabled = false;
            this.pViajes.Location = new System.Drawing.Point(34, 12);
            this.pViajes.Name = "pViajes";
            this.pViajes.Size = new System.Drawing.Size(452, 370);
            this.pViajes.TabIndex = 3;
            this.pViajes.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(365, 319);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 38);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCambiarDispo
            // 
            this.btnCambiarDispo.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCambiarDispo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnCambiarDispo.Location = new System.Drawing.Point(162, 245);
            this.btnCambiarDispo.Name = "btnCambiarDispo";
            this.btnCambiarDispo.Size = new System.Drawing.Size(194, 63);
            this.btnCambiarDispo.TabIndex = 4;
            this.btnCambiarDispo.Text = "Cambiar Disponibilidad";
            this.btnCambiarDispo.UseVisualStyleBackColor = false;
            this.btnCambiarDispo.Click += new System.EventHandler(this.btnCambiarDispo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoRamaYMauri.Properties.Resources.fondoMadera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(511, 406);
            this.Controls.Add(this.pViajes);
            this.Controls.Add(this.btnViajeRealizado);
            this.Controls.Add(this.btnAuto);
            this.Controls.Add(this.btnCambiarDispo);
            this.ForeColor = System.Drawing.Color.Gold;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pViajes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.Button btnViajeRealizado;
        private System.Windows.Forms.ListBox lbViajes;
        private System.Windows.Forms.Panel pViajes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCambiarDispo;
    }
}

