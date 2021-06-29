
namespace Concesionaria
{
    partial class FCamionetas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDistribuidores = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rbCuatroXCuatro = new System.Windows.Forms.RadioButton();
            this.rbTraccionSimple = new System.Windows.Forms.RadioButton();
            this.mtPrecioCosto = new System.Windows.Forms.MaskedTextBox();
            this.dtFechaFabricacion = new System.Windows.Forms.DateTimePicker();
            this.cbGama = new System.Windows.Forms.ComboBox();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkUsado = new System.Windows.Forms.CheckBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbModelo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbDistribuidores);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.rbCuatroXCuatro);
            this.panel1.Controls.Add(this.rbTraccionSimple);
            this.panel1.Controls.Add(this.mtPrecioCosto);
            this.panel1.Controls.Add(this.dtFechaFabricacion);
            this.panel1.Controls.Add(this.cbGama);
            this.panel1.Controls.Add(this.cbMarca);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(18, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 256);
            this.panel1.TabIndex = 0;
            // 
            // cbDistribuidores
            // 
            this.cbDistribuidores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDistribuidores.FormattingEnabled = true;
            this.cbDistribuidores.Items.AddRange(new object[] {
            "Gama Base",
            "Gama Media",
            "Gama Full"});
            this.cbDistribuidores.Location = new System.Drawing.Point(147, 126);
            this.cbDistribuidores.Name = "cbDistribuidores";
            this.cbDistribuidores.Size = new System.Drawing.Size(200, 21);
            this.cbDistribuidores.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Distribuidor:";
            // 
            // rbCuatroXCuatro
            // 
            this.rbCuatroXCuatro.AutoSize = true;
            this.rbCuatroXCuatro.Location = new System.Drawing.Point(209, 225);
            this.rbCuatroXCuatro.Name = "rbCuatroXCuatro";
            this.rbCuatroXCuatro.Size = new System.Drawing.Size(42, 17);
            this.rbCuatroXCuatro.TabIndex = 5;
            this.rbCuatroXCuatro.TabStop = true;
            this.rbCuatroXCuatro.Text = "4x4";
            this.rbCuatroXCuatro.UseVisualStyleBackColor = true;
            // 
            // rbTraccionSimple
            // 
            this.rbTraccionSimple.AutoSize = true;
            this.rbTraccionSimple.Checked = true;
            this.rbTraccionSimple.Location = new System.Drawing.Point(99, 225);
            this.rbTraccionSimple.Name = "rbTraccionSimple";
            this.rbTraccionSimple.Size = new System.Drawing.Size(101, 17);
            this.rbTraccionSimple.TabIndex = 5;
            this.rbTraccionSimple.TabStop = true;
            this.rbTraccionSimple.Text = "Traccion Simple";
            this.rbTraccionSimple.UseVisualStyleBackColor = true;
            // 
            // mtPrecioCosto
            // 
            this.mtPrecioCosto.Location = new System.Drawing.Point(147, 189);
            this.mtPrecioCosto.Mask = "9999990.99";
            this.mtPrecioCosto.Name = "mtPrecioCosto";
            this.mtPrecioCosto.Size = new System.Drawing.Size(64, 20);
            this.mtPrecioCosto.TabIndex = 4;
            // 
            // dtFechaFabricacion
            // 
            this.dtFechaFabricacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFabricacion.Location = new System.Drawing.Point(147, 157);
            this.dtFechaFabricacion.Name = "dtFechaFabricacion";
            this.dtFechaFabricacion.Size = new System.Drawing.Size(104, 20);
            this.dtFechaFabricacion.TabIndex = 3;
            // 
            // cbGama
            // 
            this.cbGama.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGama.FormattingEnabled = true;
            this.cbGama.Items.AddRange(new object[] {
            "Gama Base",
            "Gama Media",
            "Gama Full"});
            this.cbGama.Location = new System.Drawing.Point(147, 99);
            this.cbGama.Name = "cbGama";
            this.cbGama.Size = new System.Drawing.Size(200, 21);
            this.cbGama.TabIndex = 2;
            // 
            // cbMarca
            // 
            this.cbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarca.FormattingEnabled = true;
            this.cbMarca.Items.AddRange(new object[] {
            "Chevrolet",
            "Ford",
            "Renault",
            "Volskwagen"});
            this.cbMarca.Location = new System.Drawing.Point(147, 42);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(200, 21);
            this.cbMarca.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio de costo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha de Fabricacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gama:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // checkUsado
            // 
            this.checkUsado.AutoSize = true;
            this.checkUsado.Location = new System.Drawing.Point(324, 274);
            this.checkUsado.Name = "checkUsado";
            this.checkUsado.Size = new System.Drawing.Size(57, 17);
            this.checkUsado.TabIndex = 1;
            this.checkUsado.Text = "Usado";
            this.checkUsado.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(194, 297);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 2;
            this.bAceptar.Text = "button1";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(306, 297);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Modelo:";
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "Chevrolet",
            "Ford",
            "Renault",
            "Volskwagen"});
            this.cbModelo.Location = new System.Drawing.Point(147, 72);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(200, 21);
            this.cbModelo.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Patente:";
            // 
            // FCamionetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 343);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.checkUsado);
            this.Controls.Add(this.panel1);
            this.Name = "FCamionetas";
            this.Text = "Camionetas";
            this.Load += new System.EventHandler(this.FCamionetas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGama;
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.DateTimePicker dtFechaFabricacion;
        private System.Windows.Forms.CheckBox checkUsado;
        private System.Windows.Forms.MaskedTextBox mtPrecioCosto;
        private System.Windows.Forms.RadioButton rbCuatroXCuatro;
        private System.Windows.Forms.RadioButton rbTraccionSimple;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ComboBox cbDistribuidores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}