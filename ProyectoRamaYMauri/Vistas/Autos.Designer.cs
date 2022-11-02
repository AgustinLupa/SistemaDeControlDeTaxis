namespace ProyectoRamaYMauri.Vistas
{
    partial class Autos
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
            this.lbAuto = new System.Windows.Forms.ListBox();
            this.PAltaPasajero = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numDNI = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.brnVolverMenu = new System.Windows.Forms.Button();
            this.PAltaPasajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).BeginInit();
            this.SuspendLayout();
            // 
            // lbAuto
            // 
            this.lbAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbAuto.FormattingEnabled = true;
            this.lbAuto.HorizontalScrollbar = true;
            this.lbAuto.ItemHeight = 25;
            this.lbAuto.Location = new System.Drawing.Point(87, 41);
            this.lbAuto.Name = "lbAuto";
            this.lbAuto.Size = new System.Drawing.Size(546, 129);
            this.lbAuto.TabIndex = 0;
            this.lbAuto.SelectedIndexChanged += new System.EventHandler(this.lbAuto_SelectedIndexChanged);
            // 
            // PAltaPasajero
            // 
            this.PAltaPasajero.BackColor = System.Drawing.Color.SaddleBrown;
            this.PAltaPasajero.Controls.Add(this.btnCancelar);
            this.PAltaPasajero.Controls.Add(this.btnGuardar);
            this.PAltaPasajero.Controls.Add(this.txtSalida);
            this.PAltaPasajero.Controls.Add(this.label7);
            this.PAltaPasajero.Controls.Add(this.txtTel);
            this.PAltaPasajero.Controls.Add(this.label6);
            this.PAltaPasajero.Controls.Add(this.numDNI);
            this.PAltaPasajero.Controls.Add(this.label5);
            this.PAltaPasajero.Controls.Add(this.txtApellido);
            this.PAltaPasajero.Controls.Add(this.label4);
            this.PAltaPasajero.Controls.Add(this.txtNombre);
            this.PAltaPasajero.Controls.Add(this.label3);
            this.PAltaPasajero.Controls.Add(this.label2);
            this.PAltaPasajero.Controls.Add(this.btnBuscar);
            this.PAltaPasajero.Enabled = false;
            this.PAltaPasajero.Location = new System.Drawing.Point(87, 41);
            this.PAltaPasajero.Name = "PAltaPasajero";
            this.PAltaPasajero.Size = new System.Drawing.Size(546, 364);
            this.PAltaPasajero.TabIndex = 1;
            this.PAltaPasajero.Visible = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gold;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnCancelar.Location = new System.Drawing.Point(318, 307);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 32);
            this.btnCancelar.TabIndex = 15;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Gold;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.btnGuardar.Location = new System.Drawing.Point(62, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(104, 32);
            this.btnGuardar.TabIndex = 14;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtSalida
            // 
            this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtSalida.Location = new System.Drawing.Point(214, 225);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(100, 26);
            this.txtSalida.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(84, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Lugar de salida";
            // 
            // txtTel
            // 
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTel.Location = new System.Drawing.Point(214, 183);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 26);
            this.txtTel.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(135, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefono";
            // 
            // numDNI
            // 
            this.numDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.numDNI.Location = new System.Drawing.Point(214, 62);
            this.numDNI.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numDNI.Minimum = new decimal(new int[] {
            7000000,
            0,
            0,
            0});
            this.numDNI.Name = "numDNI";
            this.numDNI.Size = new System.Drawing.Size(100, 26);
            this.numDNI.TabIndex = 9;
            this.numDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDNI.Value = new decimal(new int[] {
            7000000,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(158, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtApellido.Location = new System.Drawing.Point(214, 144);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 26);
            this.txtApellido.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(140, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtNombre.Location = new System.Drawing.Point(214, 103);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(140, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label2.Location = new System.Drawing.Point(187, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Alta de Pasajeros";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Gold;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnBuscar.Location = new System.Drawing.Point(324, 59);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 29);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // brnVolverMenu
            // 
            this.brnVolverMenu.BackColor = System.Drawing.Color.Gold;
            this.brnVolverMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.brnVolverMenu.Location = new System.Drawing.Point(464, 215);
            this.brnVolverMenu.Name = "brnVolverMenu";
            this.brnVolverMenu.Size = new System.Drawing.Size(105, 32);
            this.brnVolverMenu.TabIndex = 16;
            this.brnVolverMenu.Text = "Cancelar";
            this.brnVolverMenu.UseVisualStyleBackColor = false;
            this.brnVolverMenu.Click += new System.EventHandler(this.brnVolverMenu_Click);
            // 
            // Autos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ProyectoRamaYMauri.Properties.Resources.fondoMadera;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(710, 503);
            this.ControlBox = false;
            this.Controls.Add(this.PAltaPasajero);
            this.Controls.Add(this.lbAuto);
            this.Controls.Add(this.brnVolverMenu);
            this.Name = "Autos";
            this.Text = "Autos";
            this.Load += new System.EventHandler(this.Autos_Load);
            this.PAltaPasajero.ResumeLayout(false);
            this.PAltaPasajero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDNI)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbAuto;
        private System.Windows.Forms.Panel PAltaPasajero;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button brnVolverMenu;
    }
}