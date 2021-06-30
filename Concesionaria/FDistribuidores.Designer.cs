
namespace Concesionaria
{
    partial class FDistribuidores
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tRazonSocial = new System.Windows.Forms.TextBox();
            this.mtCuit = new System.Windows.Forms.MaskedTextBox();
            this.checkInternacional = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.bCancelar = new System.Windows.Forms.Button();
            this.epCuit = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCuit)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.tRazonSocial);
            this.panel1.Controls.Add(this.mtCuit);
            this.panel1.Controls.Add(this.checkInternacional);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 121);
            this.panel1.TabIndex = 0;
            // 
            // tRazonSocial
            // 
            this.tRazonSocial.Location = new System.Drawing.Point(95, 46);
            this.tRazonSocial.Name = "tRazonSocial";
            this.tRazonSocial.Size = new System.Drawing.Size(176, 20);
            this.tRazonSocial.TabIndex = 2;
            // 
            // mtCuit
            // 
            this.mtCuit.Location = new System.Drawing.Point(95, 18);
            this.mtCuit.Mask = "00-00000000-0";
            this.mtCuit.Name = "mtCuit";
            this.mtCuit.Size = new System.Drawing.Size(78, 20);
            this.mtCuit.TabIndex = 1;
            this.mtCuit.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtCuit.Validating += new System.ComponentModel.CancelEventHandler(this.mtCuit_Validating);
            // 
            // checkInternacional
            // 
            this.checkInternacional.AutoSize = true;
            this.checkInternacional.Location = new System.Drawing.Point(86, 87);
            this.checkInternacional.Name = "checkInternacional";
            this.checkInternacional.Size = new System.Drawing.Size(87, 17);
            this.checkInternacional.TabIndex = 3;
            this.checkInternacional.Text = "Internacional";
            this.checkInternacional.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Razon Social:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CUIT:";
            // 
            // bAceptar
            // 
            this.bAceptar.Location = new System.Drawing.Point(58, 155);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 23);
            this.bAceptar.TabIndex = 4;
            this.bAceptar.Text = "button1";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bCancelar
            // 
            this.bCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancelar.Location = new System.Drawing.Point(172, 155);
            this.bCancelar.Name = "bCancelar";
            this.bCancelar.Size = new System.Drawing.Size(75, 23);
            this.bCancelar.TabIndex = 5;
            this.bCancelar.Text = "Cancelar";
            this.bCancelar.UseVisualStyleBackColor = true;
            this.bCancelar.Click += new System.EventHandler(this.bCancelar_Click);
            // 
            // epCuit
            // 
            this.epCuit.ContainerControl = this;
            // 
            // FDistribuidores
            // 
            this.AcceptButton = this.bAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancelar;
            this.ClientSize = new System.Drawing.Size(315, 197);
            this.Controls.Add(this.bCancelar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.panel1);
            this.Name = "FDistribuidores";
            this.Text = "Distribuidores";
            this.Load += new System.EventHandler(this.FDistribuidores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epCuit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtCuit;
        private System.Windows.Forms.CheckBox checkInternacional;
        private System.Windows.Forms.TextBox tRazonSocial;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bCancelar;
        private System.Windows.Forms.ErrorProvider epCuit;
    }
}