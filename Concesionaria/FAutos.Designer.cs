
namespace Concesionaria
{
    partial class FAutos
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbMarca = new System.Windows.Forms.ComboBox();
            this.cbModelo = new System.Windows.Forms.ComboBox();
            this.dtFechaFabricacion = new System.Windows.Forms.DateTimePicker();
            this.mtPrecioCosto = new System.Windows.Forms.MaskedTextBox();
            this.checkUsado = new System.Windows.Forms.CheckBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.mtPrecioCosto);
            this.panel1.Controls.Add(this.dtFechaFabricacion);
            this.panel1.Controls.Add(this.cbModelo);
            this.panel1.Controls.Add(this.cbMarca);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 148);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Fecha de Fabricacion:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Precio de costo:";
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
            this.cbMarca.Location = new System.Drawing.Point(133, 22);
            this.cbMarca.Name = "cbMarca";
            this.cbMarca.Size = new System.Drawing.Size(228, 21);
            this.cbMarca.TabIndex = 1;
            // 
            // cbModelo
            // 
            this.cbModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbModelo.FormattingEnabled = true;
            this.cbModelo.Items.AddRange(new object[] {
            "Gama Base",
            "Gama Media",
            "Gama Full"});
            this.cbModelo.Location = new System.Drawing.Point(133, 48);
            this.cbModelo.Name = "cbModelo";
            this.cbModelo.Size = new System.Drawing.Size(228, 21);
            this.cbModelo.TabIndex = 2;
            // 
            // dtFechaFabricacion
            // 
            this.dtFechaFabricacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaFabricacion.Location = new System.Drawing.Point(133, 79);
            this.dtFechaFabricacion.Name = "dtFechaFabricacion";
            this.dtFechaFabricacion.Size = new System.Drawing.Size(97, 20);
            this.dtFechaFabricacion.TabIndex = 3;
            // 
            // mtPrecioCosto
            // 
            this.mtPrecioCosto.Location = new System.Drawing.Point(133, 105);
            this.mtPrecioCosto.Mask = "9999990.99";
            this.mtPrecioCosto.Name = "mtPrecioCosto";
            this.mtPrecioCosto.Size = new System.Drawing.Size(66, 20);
            this.mtPrecioCosto.TabIndex = 4;
            // 
            // checkUsado
            // 
            this.checkUsado.AutoSize = true;
            this.checkUsado.Location = new System.Drawing.Point(316, 179);
            this.checkUsado.Name = "checkUsado";
            this.checkUsado.Size = new System.Drawing.Size(57, 17);
            this.checkUsado.TabIndex = 1;
            this.checkUsado.Text = "Usado";
            this.checkUsado.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(180, 224);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 2;
            this.bAceptar.Text = "button1";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // bCancelar
            // 
            this.bCancelar.Location = new System.Drawing.Point(298, 224);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 2;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            // 
            // FAutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 267);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.checkUsado);
            this.Controls.Add(this.panel1);
            this.Name = "FAutos";
            this.Text = "Autos";
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
        private System.Windows.Forms.ComboBox cbMarca;
        private System.Windows.Forms.ComboBox cbModelo;
        private System.Windows.Forms.DateTimePicker dtFechaFabricacion;
        private System.Windows.Forms.MaskedTextBox mtPrecioCosto;
        private System.Windows.Forms.CheckBox checkUsado;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
    }
}