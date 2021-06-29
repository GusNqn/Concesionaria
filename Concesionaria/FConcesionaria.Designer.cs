
namespace Concesionaria
{
    partial class FConcesionaria
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FConcesionaria));
            this.msPrincipal = new System.Windows.Forms.MenuStrip();
            this.msAutos = new System.Windows.Forms.ToolStripMenuItem();
            this.miAgregarAutos = new System.Windows.Forms.ToolStripMenuItem();
            this.miModificarAutos = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminarAutos = new System.Windows.Forms.ToolStripMenuItem();
            this.msCamioneta = new System.Windows.Forms.ToolStripMenuItem();
            this.miAgregarCamioneta = new System.Windows.Forms.ToolStripMenuItem();
            this.miModificarCamioneta = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminarCamioneta = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miAgregarDistribuidor = new System.Windows.Forms.ToolStripMenuItem();
            this.miModificarDistribuidor = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminarDistribuidor = new System.Windows.Forms.ToolStripMenuItem();
            this.miSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.miAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkFiltro4x4 = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkFiltroUsado = new System.Windows.Forms.CheckBox();
            this.lCantTotalVehiculos = new System.Windows.Forms.Label();
            this.lCantListadaVehiculos = new System.Windows.Forms.Label();
            this.cbFiltroDistribuidor = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbGamaTodos = new System.Windows.Forms.RadioButton();
            this.rbFull = new System.Windows.Forms.RadioButton();
            this.rbMedia = new System.Windows.Forms.RadioButton();
            this.rbBase = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFiltroMarca = new System.Windows.Forms.ComboBox();
            this.cbFiltroTipo = new System.Windows.Forms.ComboBox();
            this.lbFiltroVehiculos = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lCantidadTotalDistribuidores = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbInternacional = new System.Windows.Forms.RadioButton();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.lCantListadoDistribuidores = new System.Windows.Forms.Label();
            this.lbFiltroDistribuidores = new System.Windows.Forms.ListBox();
            this.cbFiltroModelo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkFiltroNuevo = new System.Windows.Forms.CheckBox();
            this.checkFiltroTraccionSimple = new System.Windows.Forms.CheckBox();
            this.msPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAutos,
            this.msCamioneta,
            this.proveedorToolStripMenuItem,
            this.miSalir,
            this.miAcercaDe});
            this.msPrincipal.Location = new System.Drawing.Point(0, 0);
            this.msPrincipal.Name = "msPrincipal";
            this.msPrincipal.Size = new System.Drawing.Size(1049, 24);
            this.msPrincipal.TabIndex = 0;
            this.msPrincipal.Text = "menuStrip1";
            // 
            // msAutos
            // 
            this.msAutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAgregarAutos,
            this.miModificarAutos,
            this.miEliminarAutos});
            this.msAutos.Enabled = false;
            this.msAutos.Name = "msAutos";
            this.msAutos.Size = new System.Drawing.Size(50, 20);
            this.msAutos.Text = "&Autos";
            // 
            // miAgregarAutos
            // 
            this.miAgregarAutos.Image = ((System.Drawing.Image)(resources.GetObject("miAgregarAutos.Image")));
            this.miAgregarAutos.Name = "miAgregarAutos";
            this.miAgregarAutos.Size = new System.Drawing.Size(180, 22);
            this.miAgregarAutos.Text = "Agregar";
            this.miAgregarAutos.Click += new System.EventHandler(this.miAgregarAutos_Click);
            // 
            // miModificarAutos
            // 
            this.miModificarAutos.Image = ((System.Drawing.Image)(resources.GetObject("miModificarAutos.Image")));
            this.miModificarAutos.Name = "miModificarAutos";
            this.miModificarAutos.Size = new System.Drawing.Size(180, 22);
            this.miModificarAutos.Text = "Modificar";
            this.miModificarAutos.Click += new System.EventHandler(this.miModificarAutos_Click);
            // 
            // miEliminarAutos
            // 
            this.miEliminarAutos.Image = ((System.Drawing.Image)(resources.GetObject("miEliminarAutos.Image")));
            this.miEliminarAutos.Name = "miEliminarAutos";
            this.miEliminarAutos.Size = new System.Drawing.Size(180, 22);
            this.miEliminarAutos.Text = "Eliminar";
            this.miEliminarAutos.Click += new System.EventHandler(this.miEliminarAutos_Click);
            // 
            // msCamioneta
            // 
            this.msCamioneta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAgregarCamioneta,
            this.miModificarCamioneta,
            this.miEliminarCamioneta});
            this.msCamioneta.Enabled = false;
            this.msCamioneta.Name = "msCamioneta";
            this.msCamioneta.Size = new System.Drawing.Size(82, 20);
            this.msCamioneta.Text = "&Camionetas";
            // 
            // miAgregarCamioneta
            // 
            this.miAgregarCamioneta.Image = ((System.Drawing.Image)(resources.GetObject("miAgregarCamioneta.Image")));
            this.miAgregarCamioneta.Name = "miAgregarCamioneta";
            this.miAgregarCamioneta.Size = new System.Drawing.Size(125, 22);
            this.miAgregarCamioneta.Text = "Agregar";
            this.miAgregarCamioneta.Click += new System.EventHandler(this.miAgregarCamioneta_Click);
            // 
            // miModificarCamioneta
            // 
            this.miModificarCamioneta.Image = ((System.Drawing.Image)(resources.GetObject("miModificarCamioneta.Image")));
            this.miModificarCamioneta.Name = "miModificarCamioneta";
            this.miModificarCamioneta.Size = new System.Drawing.Size(125, 22);
            this.miModificarCamioneta.Text = "Modificar";
            this.miModificarCamioneta.Click += new System.EventHandler(this.miModificarCamioneta_Click);
            // 
            // miEliminarCamioneta
            // 
            this.miEliminarCamioneta.Image = ((System.Drawing.Image)(resources.GetObject("miEliminarCamioneta.Image")));
            this.miEliminarCamioneta.Name = "miEliminarCamioneta";
            this.miEliminarCamioneta.Size = new System.Drawing.Size(125, 22);
            this.miEliminarCamioneta.Text = "Eliminar";
            this.miEliminarCamioneta.Click += new System.EventHandler(this.miEliminarCamioneta_Click);
            // 
            // proveedorToolStripMenuItem
            // 
            this.proveedorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAgregarDistribuidor,
            this.miModificarDistribuidor,
            this.miEliminarDistribuidor});
            this.proveedorToolStripMenuItem.Name = "proveedorToolStripMenuItem";
            this.proveedorToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.proveedorToolStripMenuItem.Text = "&Distribuidor";
            // 
            // miAgregarDistribuidor
            // 
            this.miAgregarDistribuidor.Image = ((System.Drawing.Image)(resources.GetObject("miAgregarDistribuidor.Image")));
            this.miAgregarDistribuidor.Name = "miAgregarDistribuidor";
            this.miAgregarDistribuidor.Size = new System.Drawing.Size(125, 22);
            this.miAgregarDistribuidor.Text = "Agregar";
            this.miAgregarDistribuidor.Click += new System.EventHandler(this.miAgregarDistribuidor_Click);
            // 
            // miModificarDistribuidor
            // 
            this.miModificarDistribuidor.Image = ((System.Drawing.Image)(resources.GetObject("miModificarDistribuidor.Image")));
            this.miModificarDistribuidor.Name = "miModificarDistribuidor";
            this.miModificarDistribuidor.Size = new System.Drawing.Size(125, 22);
            this.miModificarDistribuidor.Text = "Modificar";
            this.miModificarDistribuidor.Click += new System.EventHandler(this.miModificarDistribuidor_Click);
            // 
            // miEliminarDistribuidor
            // 
            this.miEliminarDistribuidor.Image = ((System.Drawing.Image)(resources.GetObject("miEliminarDistribuidor.Image")));
            this.miEliminarDistribuidor.Name = "miEliminarDistribuidor";
            this.miEliminarDistribuidor.Size = new System.Drawing.Size(125, 22);
            this.miEliminarDistribuidor.Text = "Eliminar";
            this.miEliminarDistribuidor.Click += new System.EventHandler(this.miEliminarDistribuidor_Click);
            // 
            // miSalir
            // 
            this.miSalir.Name = "miSalir";
            this.miSalir.Size = new System.Drawing.Size(41, 20);
            this.miSalir.Text = "Salir";
            this.miSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // miAcercaDe
            // 
            this.miAcercaDe.Name = "miAcercaDe";
            this.miAcercaDe.Size = new System.Drawing.Size(71, 20);
            this.miAcercaDe.Text = "Acerca de";
            this.miAcercaDe.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbFiltroModelo);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.lCantTotalVehiculos);
            this.panel1.Controls.Add(this.lCantListadaVehiculos);
            this.panel1.Controls.Add(this.cbFiltroDistribuidor);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbFiltroMarca);
            this.panel1.Controls.Add(this.cbFiltroTipo);
            this.panel1.Controls.Add(this.lbFiltroVehiculos);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 273);
            this.panel1.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkFiltroTraccionSimple);
            this.groupBox4.Controls.Add(this.checkFiltro4x4);
            this.groupBox4.Location = new System.Drawing.Point(456, 73);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(118, 83);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Traccion Camioneta";
            // 
            // checkFiltro4x4
            // 
            this.checkFiltro4x4.AutoSize = true;
            this.checkFiltro4x4.Enabled = false;
            this.checkFiltro4x4.Location = new System.Drawing.Point(6, 51);
            this.checkFiltro4x4.Name = "checkFiltro4x4";
            this.checkFiltro4x4.Size = new System.Drawing.Size(43, 17);
            this.checkFiltro4x4.TabIndex = 1;
            this.checkFiltro4x4.Text = "4x4";
            this.checkFiltro4x4.UseVisualStyleBackColor = true;
            this.checkFiltro4x4.CheckedChanged += new System.EventHandler(this.checkFiltro4x4_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.checkFiltroNuevo);
            this.groupBox3.Controls.Add(this.checkFiltroUsado);
            this.groupBox3.Location = new System.Drawing.Point(456, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 50);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Condicion";
            // 
            // checkFiltroUsado
            // 
            this.checkFiltroUsado.AutoSize = true;
            this.checkFiltroUsado.Checked = true;
            this.checkFiltroUsado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFiltroUsado.Location = new System.Drawing.Point(6, 21);
            this.checkFiltroUsado.Name = "checkFiltroUsado";
            this.checkFiltroUsado.Size = new System.Drawing.Size(57, 17);
            this.checkFiltroUsado.TabIndex = 1;
            this.checkFiltroUsado.Text = "Usado";
            this.checkFiltroUsado.UseVisualStyleBackColor = true;
            this.checkFiltroUsado.CheckedChanged += new System.EventHandler(this.checkFiltroUsado_CheckedChanged);
            // 
            // lCantTotalVehiculos
            // 
            this.lCantTotalVehiculos.AutoSize = true;
            this.lCantTotalVehiculos.Location = new System.Drawing.Point(476, 219);
            this.lCantTotalVehiculos.Name = "lCantTotalVehiculos";
            this.lCantTotalVehiculos.Size = new System.Drawing.Size(88, 13);
            this.lCantTotalVehiculos.TabIndex = 6;
            this.lCantTotalVehiculos.Text = "Cantidad Total: 0";
            // 
            // lCantListadaVehiculos
            // 
            this.lCantListadaVehiculos.AutoSize = true;
            this.lCantListadaVehiculos.Location = new System.Drawing.Point(476, 175);
            this.lCantListadaVehiculos.Name = "lCantListadaVehiculos";
            this.lCantListadaVehiculos.Size = new System.Drawing.Size(98, 13);
            this.lCantListadaVehiculos.TabIndex = 6;
            this.lCantListadaVehiculos.Text = "Cantidad Listado: 0";
            // 
            // cbFiltroDistribuidor
            // 
            this.cbFiltroDistribuidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroDistribuidor.FormattingEnabled = true;
            this.cbFiltroDistribuidor.Items.AddRange(new object[] {
            "Todos"});
            this.cbFiltroDistribuidor.Location = new System.Drawing.Point(160, 105);
            this.cbFiltroDistribuidor.Name = "cbFiltroDistribuidor";
            this.cbFiltroDistribuidor.Size = new System.Drawing.Size(175, 21);
            this.cbFiltroDistribuidor.TabIndex = 5;
            this.cbFiltroDistribuidor.SelectedIndexChanged += new System.EventHandler(this.cbFiltroDistribuidor_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbGamaTodos);
            this.groupBox1.Controls.Add(this.rbFull);
            this.groupBox1.Controls.Add(this.rbMedia);
            this.groupBox1.Controls.Add(this.rbBase);
            this.groupBox1.Location = new System.Drawing.Point(367, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(83, 108);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gama";
            // 
            // rbGamaTodos
            // 
            this.rbGamaTodos.AutoSize = true;
            this.rbGamaTodos.Checked = true;
            this.rbGamaTodos.Location = new System.Drawing.Point(6, 19);
            this.rbGamaTodos.Name = "rbGamaTodos";
            this.rbGamaTodos.Size = new System.Drawing.Size(55, 17);
            this.rbGamaTodos.TabIndex = 1;
            this.rbGamaTodos.TabStop = true;
            this.rbGamaTodos.Text = "Todos";
            this.rbGamaTodos.UseVisualStyleBackColor = true;
            this.rbGamaTodos.CheckedChanged += new System.EventHandler(this.rbGamaTodos_CheckedChanged);
            // 
            // rbFull
            // 
            this.rbFull.AutoSize = true;
            this.rbFull.Location = new System.Drawing.Point(6, 87);
            this.rbFull.Name = "rbFull";
            this.rbFull.Size = new System.Drawing.Size(41, 17);
            this.rbFull.TabIndex = 0;
            this.rbFull.Text = "Full";
            this.rbFull.UseVisualStyleBackColor = true;
            this.rbFull.CheckedChanged += new System.EventHandler(this.rbFull_CheckedChanged);
            // 
            // rbMedia
            // 
            this.rbMedia.AutoSize = true;
            this.rbMedia.Location = new System.Drawing.Point(6, 64);
            this.rbMedia.Name = "rbMedia";
            this.rbMedia.Size = new System.Drawing.Size(54, 17);
            this.rbMedia.TabIndex = 0;
            this.rbMedia.Text = "Media";
            this.rbMedia.UseVisualStyleBackColor = true;
            this.rbMedia.CheckedChanged += new System.EventHandler(this.rbMedia_CheckedChanged);
            // 
            // rbBase
            // 
            this.rbBase.AutoSize = true;
            this.rbBase.Location = new System.Drawing.Point(6, 41);
            this.rbBase.Name = "rbBase";
            this.rbBase.Size = new System.Drawing.Size(49, 17);
            this.rbBase.TabIndex = 0;
            this.rbBase.Text = "Base";
            this.rbBase.UseVisualStyleBackColor = true;
            this.rbBase.CheckedChanged += new System.EventHandler(this.rbBase_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Distribuidor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de Vehiculo:";
            // 
            // cbFiltroMarca
            // 
            this.cbFiltroMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroMarca.FormattingEnabled = true;
            this.cbFiltroMarca.Items.AddRange(new object[] {
            "Todos",
            "Chevrolet",
            "Ford",
            "Renault",
            "Volskwagen"});
            this.cbFiltroMarca.Location = new System.Drawing.Point(160, 57);
            this.cbFiltroMarca.Name = "cbFiltroMarca";
            this.cbFiltroMarca.Size = new System.Drawing.Size(175, 21);
            this.cbFiltroMarca.TabIndex = 2;
            this.cbFiltroMarca.SelectedIndexChanged += new System.EventHandler(this.cbFiltroMarca_SelectedIndexChanged);
            // 
            // cbFiltroTipo
            // 
            this.cbFiltroTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroTipo.FormattingEnabled = true;
            this.cbFiltroTipo.Items.AddRange(new object[] {
            "Todos",
            "Auto",
            "Camioneta"});
            this.cbFiltroTipo.Location = new System.Drawing.Point(160, 31);
            this.cbFiltroTipo.Name = "cbFiltroTipo";
            this.cbFiltroTipo.Size = new System.Drawing.Size(175, 21);
            this.cbFiltroTipo.TabIndex = 2;
            this.cbFiltroTipo.SelectedIndexChanged += new System.EventHandler(this.cbFiltroTipo_SelectedIndexChanged);
            // 
            // lbFiltroVehiculos
            // 
            this.lbFiltroVehiculos.FormattingEnabled = true;
            this.lbFiltroVehiculos.Location = new System.Drawing.Point(18, 143);
            this.lbFiltroVehiculos.Name = "lbFiltroVehiculos";
            this.lbFiltroVehiculos.Size = new System.Drawing.Size(432, 108);
            this.lbFiltroVehiculos.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lCantidadTotalDistribuidores);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.lCantListadoDistribuidores);
            this.panel2.Controls.Add(this.lbFiltroDistribuidores);
            this.panel2.Location = new System.Drawing.Point(614, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 273);
            this.panel2.TabIndex = 1;
            // 
            // lCantidadTotalDistribuidores
            // 
            this.lCantidadTotalDistribuidores.AutoSize = true;
            this.lCantidadTotalDistribuidores.Location = new System.Drawing.Point(309, 185);
            this.lCantidadTotalDistribuidores.Name = "lCantidadTotalDistribuidores";
            this.lCantidadTotalDistribuidores.Size = new System.Drawing.Size(88, 13);
            this.lCantidadTotalDistribuidores.TabIndex = 6;
            this.lCantidadTotalDistribuidores.Text = "Cantidad Total: 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbTodos);
            this.groupBox2.Controls.Add(this.rbInternacional);
            this.groupBox2.Controls.Add(this.rbNacional);
            this.groupBox2.Location = new System.Drawing.Point(296, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(112, 95);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Distribuidores";
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(16, 20);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(55, 17);
            this.rbTodos.TabIndex = 0;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // rbInternacional
            // 
            this.rbInternacional.AutoSize = true;
            this.rbInternacional.Location = new System.Drawing.Point(16, 66);
            this.rbInternacional.Name = "rbInternacional";
            this.rbInternacional.Size = new System.Drawing.Size(86, 17);
            this.rbInternacional.TabIndex = 0;
            this.rbInternacional.Text = "Internacional";
            this.rbInternacional.UseVisualStyleBackColor = true;
            this.rbInternacional.CheckedChanged += new System.EventHandler(this.rbInternacional_CheckedChanged);
            // 
            // rbNacional
            // 
            this.rbNacional.AutoSize = true;
            this.rbNacional.Location = new System.Drawing.Point(16, 43);
            this.rbNacional.Name = "rbNacional";
            this.rbNacional.Size = new System.Drawing.Size(67, 17);
            this.rbNacional.TabIndex = 0;
            this.rbNacional.Text = "Nacional";
            this.rbNacional.UseVisualStyleBackColor = true;
            this.rbNacional.CheckedChanged += new System.EventHandler(this.rbNacional_CheckedChanged);
            // 
            // lCantListadoDistribuidores
            // 
            this.lCantListadoDistribuidores.AutoSize = true;
            this.lCantListadoDistribuidores.Location = new System.Drawing.Point(309, 143);
            this.lCantListadoDistribuidores.Name = "lCantListadoDistribuidores";
            this.lCantListadoDistribuidores.Size = new System.Drawing.Size(98, 13);
            this.lCantListadoDistribuidores.TabIndex = 6;
            this.lCantListadoDistribuidores.Text = "Cantidad Listado: 0";
            // 
            // lbFiltroDistribuidores
            // 
            this.lbFiltroDistribuidores.FormattingEnabled = true;
            this.lbFiltroDistribuidores.Location = new System.Drawing.Point(18, 14);
            this.lbFiltroDistribuidores.Name = "lbFiltroDistribuidores";
            this.lbFiltroDistribuidores.Size = new System.Drawing.Size(268, 238);
            this.lbFiltroDistribuidores.TabIndex = 0;
            // 
            // cbFiltroModelo
            // 
            this.cbFiltroModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroModelo.Enabled = false;
            this.cbFiltroModelo.FormattingEnabled = true;
            this.cbFiltroModelo.Items.AddRange(new object[] {
            "Todos",
            "Chevrolet",
            "Ford",
            "Renault",
            "Volskwagen"});
            this.cbFiltroModelo.Location = new System.Drawing.Point(160, 81);
            this.cbFiltroModelo.Name = "cbFiltroModelo";
            this.cbFiltroModelo.Size = new System.Drawing.Size(175, 21);
            this.cbFiltroModelo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Modelo:";
            // 
            // checkFiltroNuevo
            // 
            this.checkFiltroNuevo.AutoSize = true;
            this.checkFiltroNuevo.Checked = true;
            this.checkFiltroNuevo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFiltroNuevo.Location = new System.Drawing.Point(61, 21);
            this.checkFiltroNuevo.Name = "checkFiltroNuevo";
            this.checkFiltroNuevo.Size = new System.Drawing.Size(58, 17);
            this.checkFiltroNuevo.TabIndex = 2;
            this.checkFiltroNuevo.Text = "Nuevo";
            this.checkFiltroNuevo.UseVisualStyleBackColor = true;
            this.checkFiltroNuevo.CheckedChanged += new System.EventHandler(this.checkFiltroNuevo_CheckedChanged);
            // 
            // checkFiltroTraccionSimple
            // 
            this.checkFiltroTraccionSimple.AutoSize = true;
            this.checkFiltroTraccionSimple.Enabled = false;
            this.checkFiltroTraccionSimple.Location = new System.Drawing.Point(6, 28);
            this.checkFiltroTraccionSimple.Name = "checkFiltroTraccionSimple";
            this.checkFiltroTraccionSimple.Size = new System.Drawing.Size(102, 17);
            this.checkFiltroTraccionSimple.TabIndex = 2;
            this.checkFiltroTraccionSimple.Text = "Traccion Simple";
            this.checkFiltroTraccionSimple.UseVisualStyleBackColor = true;
            this.checkFiltroTraccionSimple.CheckedChanged += new System.EventHandler(this.checkFiltroTraccionSimple_CheckedChanged);
            // 
            // FConcesionaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 330);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.msPrincipal);
            this.MainMenuStrip = this.msPrincipal;
            this.Name = "FConcesionaria";
            this.Text = "Concesionaria";
            this.Load += new System.EventHandler(this.FConcesionaria_Load);
            this.msPrincipal.ResumeLayout(false);
            this.msPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem msAutos;
        private System.Windows.Forms.ToolStripMenuItem msCamioneta;
        private System.Windows.Forms.ToolStripMenuItem proveedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miAgregarDistribuidor;
        private System.Windows.Forms.ToolStripMenuItem miModificarDistribuidor;
        private System.Windows.Forms.ToolStripMenuItem miEliminarDistribuidor;
        private System.Windows.Forms.ToolStripMenuItem miSalir;
        private System.Windows.Forms.ToolStripMenuItem miAcercaDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFull;
        private System.Windows.Forms.RadioButton rbMedia;
        private System.Windows.Forms.RadioButton rbBase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFiltroMarca;
        private System.Windows.Forms.ComboBox cbFiltroTipo;
        private System.Windows.Forms.CheckBox checkFiltro4x4;
        private System.Windows.Forms.CheckBox checkFiltroUsado;
        private System.Windows.Forms.ListBox lbFiltroVehiculos;
        private System.Windows.Forms.ListBox lbFiltroDistribuidores;
        private System.Windows.Forms.ComboBox cbFiltroDistribuidor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lCantTotalVehiculos;
        private System.Windows.Forms.Label lCantListadaVehiculos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.RadioButton rbInternacional;
        private System.Windows.Forms.RadioButton rbNacional;
        private System.Windows.Forms.Label lCantidadTotalDistribuidores;
        private System.Windows.Forms.Label lCantListadoDistribuidores;
        private System.Windows.Forms.ToolStripMenuItem miAgregarAutos;
        private System.Windows.Forms.ToolStripMenuItem miModificarAutos;
        private System.Windows.Forms.ToolStripMenuItem miEliminarAutos;
        private System.Windows.Forms.ToolStripMenuItem miAgregarCamioneta;
        private System.Windows.Forms.ToolStripMenuItem miModificarCamioneta;
        private System.Windows.Forms.ToolStripMenuItem miEliminarCamioneta;
        private System.Windows.Forms.RadioButton rbGamaTodos;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFiltroModelo;
        private System.Windows.Forms.CheckBox checkFiltroTraccionSimple;
        private System.Windows.Forms.CheckBox checkFiltroNuevo;
    }
}

