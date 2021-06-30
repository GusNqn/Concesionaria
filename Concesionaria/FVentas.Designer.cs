
namespace Concesionaria
{
    partial class FVentas
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
            this.lVehiculo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFechaVenta = new System.Windows.Forms.DateTimePicker();
            this.dtFechaCompra = new System.Windows.Forms.DateTimePicker();
            this.bVender = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lVehiculo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtFechaVenta);
            this.panel1.Controls.Add(this.dtFechaCompra);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 122);
            this.panel1.TabIndex = 0;
            // 
            // lVehiculo
            // 
            this.lVehiculo.AutoSize = true;
            this.lVehiculo.Location = new System.Drawing.Point(9, 18);
            this.lVehiculo.Name = "lVehiculo";
            this.lVehiculo.Size = new System.Drawing.Size(35, 13);
            this.lVehiculo.TabIndex = 6;
            this.lVehiculo.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Venta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Fecha Compra:";
            // 
            // dtFechaVenta
            // 
            this.dtFechaVenta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaVenta.Location = new System.Drawing.Point(144, 70);
            this.dtFechaVenta.Name = "dtFechaVenta";
            this.dtFechaVenta.Size = new System.Drawing.Size(114, 20);
            this.dtFechaVenta.TabIndex = 1;
            // 
            // dtFechaCompra
            // 
            this.dtFechaCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFechaCompra.Location = new System.Drawing.Point(144, 40);
            this.dtFechaCompra.Name = "dtFechaCompra";
            this.dtFechaCompra.Size = new System.Drawing.Size(114, 20);
            this.dtFechaCompra.TabIndex = 1;
            this.dtFechaCompra.ValueChanged += new System.EventHandler(this.dtFechaCompra_ValueChanged);
            // 
            // bVender
            // 
            this.bVender.Location = new System.Drawing.Point(105, 145);
            this.bVender.Name = "bVender";
            this.bVender.Size = new System.Drawing.Size(75, 23);
            this.bVender.TabIndex = 2;
            this.bVender.Text = "&Vender";
            this.bVender.UseVisualStyleBackColor = true;
            this.bVender.Click += new System.EventHandler(this.bVender_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Location = new System.Drawing.Point(203, 145);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 3;
            this.bCancelar.Text = "&Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // FVentas
            // 
            this.AcceptButton = this.bVender;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(383, 178);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bVender);
            this.Controls.Add(this.panel1);
            this.Name = "FVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.FVentas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtFechaCompra;
        private System.Windows.Forms.DateTimePicker dtFechaVenta;
        private System.Windows.Forms.Label lVehiculo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bVender;
        private System.Windows.Forms.Button bCancelar;
    }
}