
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
            this.components = new System.ComponentModel.Container();
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
            this.msDistribuidor = new System.Windows.Forms.ToolStripMenuItem();
            this.miAgregarDistribuidor = new System.Windows.Forms.ToolStripMenuItem();
            this.miModificarDistribuidor = new System.Windows.Forms.ToolStripMenuItem();
            this.miEliminarDistribuidor = new System.Windows.Forms.ToolStripMenuItem();
            this.msVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.msSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.msAcercaDe = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.cbFiltroModelo = new System.Windows.Forms.ComboBox();
            this.gbTraccionCamioneta = new System.Windows.Forms.GroupBox();
            this.checkFiltroTraccionSimple = new System.Windows.Forms.CheckBox();
            this.checkFiltro4x4 = new System.Windows.Forms.CheckBox();
            this.gbCondicion = new System.Windows.Forms.GroupBox();
            this.checkFiltroNuevo = new System.Windows.Forms.CheckBox();
            this.checkFiltroUsado = new System.Windows.Forms.CheckBox();
            this.lCantTotalVehiculos = new System.Windows.Forms.Label();
            this.lCantListadaVehiculos = new System.Windows.Forms.Label();
            this.cbFiltroDistribuidor = new System.Windows.Forms.ComboBox();
            this.gbGama = new System.Windows.Forms.GroupBox();
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
            this.mcEliminarVehiculo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mciEliminarAuto = new System.Windows.Forms.ToolStripMenuItem();
            this.mciEliminarCamioneta = new System.Windows.Forms.ToolStripMenuItem();
            this.mciVenderVehiculo = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lCantidadTotalDistribuidores = new System.Windows.Forms.Label();
            this.gbDistribuidores = new System.Windows.Forms.GroupBox();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.rbInternacional = new System.Windows.Forms.RadioButton();
            this.rbNacional = new System.Windows.Forms.RadioButton();
            this.lCantListadoDistribuidores = new System.Windows.Forms.Label();
            this.lbFiltroDistribuidores = new System.Windows.Forms.ListBox();
            this.mcEliminarDitribuidor = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ttipTraccionCamioneta = new System.Windows.Forms.ToolTip(this.components);
            this.msPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbTraccionCamioneta.SuspendLayout();
            this.gbCondicion.SuspendLayout();
            this.gbGama.SuspendLayout();
            this.mcEliminarVehiculo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbDistribuidores.SuspendLayout();
            this.mcEliminarDitribuidor.SuspendLayout();
            this.SuspendLayout();
            // 
            // msPrincipal
            // 
            this.msPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msAutos,
            this.msCamioneta,
            this.msDistribuidor,
            this.msVentas,
            this.msSalir,
            this.msAcercaDe});
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
            this.miAgregarAutos.Enabled = false;
            this.miAgregarAutos.Image = ((System.Drawing.Image)(resources.GetObject("miAgregarAutos.Image")));
            this.miAgregarAutos.Name = "miAgregarAutos";
            this.miAgregarAutos.Size = new System.Drawing.Size(180, 22);
            this.miAgregarAutos.Text = "Agregar";
            this.miAgregarAutos.Click += new System.EventHandler(this.miAgregarAutos_Click);
            // 
            // miModificarAutos
            // 
            this.miModificarAutos.Enabled = false;
            this.miModificarAutos.Image = ((System.Drawing.Image)(resources.GetObject("miModificarAutos.Image")));
            this.miModificarAutos.Name = "miModificarAutos";
            this.miModificarAutos.Size = new System.Drawing.Size(180, 22);
            this.miModificarAutos.Text = "Modificar";
            this.miModificarAutos.Click += new System.EventHandler(this.miModificarAutos_Click);
            // 
            // miEliminarAutos
            // 
            this.miEliminarAutos.Enabled = false;
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
            this.miAgregarCamioneta.Enabled = false;
            this.miAgregarCamioneta.Image = ((System.Drawing.Image)(resources.GetObject("miAgregarCamioneta.Image")));
            this.miAgregarCamioneta.Name = "miAgregarCamioneta";
            this.miAgregarCamioneta.Size = new System.Drawing.Size(180, 22);
            this.miAgregarCamioneta.Text = "Agregar";
            this.miAgregarCamioneta.Click += new System.EventHandler(this.miAgregarCamioneta_Click);
            // 
            // miModificarCamioneta
            // 
            this.miModificarCamioneta.Enabled = false;
            this.miModificarCamioneta.Image = ((System.Drawing.Image)(resources.GetObject("miModificarCamioneta.Image")));
            this.miModificarCamioneta.Name = "miModificarCamioneta";
            this.miModificarCamioneta.Size = new System.Drawing.Size(180, 22);
            this.miModificarCamioneta.Text = "Modificar";
            this.miModificarCamioneta.Click += new System.EventHandler(this.miModificarCamioneta_Click);
            // 
            // miEliminarCamioneta
            // 
            this.miEliminarCamioneta.Enabled = false;
            this.miEliminarCamioneta.Image = ((System.Drawing.Image)(resources.GetObject("miEliminarCamioneta.Image")));
            this.miEliminarCamioneta.Name = "miEliminarCamioneta";
            this.miEliminarCamioneta.Size = new System.Drawing.Size(180, 22);
            this.miEliminarCamioneta.Text = "Eliminar";
            this.miEliminarCamioneta.Click += new System.EventHandler(this.miEliminarCamioneta_Click);
            // 
            // msDistribuidor
            // 
            this.msDistribuidor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miAgregarDistribuidor,
            this.miModificarDistribuidor,
            this.miEliminarDistribuidor});
            this.msDistribuidor.Name = "msDistribuidor";
            this.msDistribuidor.Size = new System.Drawing.Size(81, 20);
            this.msDistribuidor.Text = "&Distribuidor";
            // 
            // miAgregarDistribuidor
            // 
            this.miAgregarDistribuidor.Image = ((System.Drawing.Image)(resources.GetObject("miAgregarDistribuidor.Image")));
            this.miAgregarDistribuidor.Name = "miAgregarDistribuidor";
            this.miAgregarDistribuidor.Size = new System.Drawing.Size(180, 22);
            this.miAgregarDistribuidor.Text = "Agregar";
            this.miAgregarDistribuidor.Click += new System.EventHandler(this.miAgregarDistribuidor_Click);
            // 
            // miModificarDistribuidor
            // 
            this.miModificarDistribuidor.Enabled = false;
            this.miModificarDistribuidor.Image = ((System.Drawing.Image)(resources.GetObject("miModificarDistribuidor.Image")));
            this.miModificarDistribuidor.Name = "miModificarDistribuidor";
            this.miModificarDistribuidor.Size = new System.Drawing.Size(180, 22);
            this.miModificarDistribuidor.Text = "Modificar";
            this.miModificarDistribuidor.Click += new System.EventHandler(this.miModificarDistribuidor_Click);
            // 
            // miEliminarDistribuidor
            // 
            this.miEliminarDistribuidor.Enabled = false;
            this.miEliminarDistribuidor.Image = ((System.Drawing.Image)(resources.GetObject("miEliminarDistribuidor.Image")));
            this.miEliminarDistribuidor.Name = "miEliminarDistribuidor";
            this.miEliminarDistribuidor.Size = new System.Drawing.Size(180, 22);
            this.miEliminarDistribuidor.Text = "Eliminar";
            this.miEliminarDistribuidor.Click += new System.EventHandler(this.miEliminarDistribuidor_Click);
            // 
            // msVentas
            // 
            this.msVentas.Enabled = false;
            this.msVentas.Name = "msVentas";
            this.msVentas.Size = new System.Drawing.Size(53, 20);
            this.msVentas.Text = "Ventas";
            this.msVentas.Click += new System.EventHandler(this.msVentas_Click);
            // 
            // msSalir
            // 
            this.msSalir.Name = "msSalir";
            this.msSalir.Size = new System.Drawing.Size(41, 20);
            this.msSalir.Text = "Salir";
            this.msSalir.Click += new System.EventHandler(this.msSalir_Click);
            // 
            // msAcercaDe
            // 
            this.msAcercaDe.Name = "msAcercaDe";
            this.msAcercaDe.Size = new System.Drawing.Size(71, 20);
            this.msAcercaDe.Text = "Acerca de";
            this.msAcercaDe.Click += new System.EventHandler(this.msAcercaDe_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbFiltroModelo);
            this.panel1.Controls.Add(this.gbTraccionCamioneta);
            this.panel1.Controls.Add(this.gbCondicion);
            this.panel1.Controls.Add(this.lCantTotalVehiculos);
            this.panel1.Controls.Add(this.lCantListadaVehiculos);
            this.panel1.Controls.Add(this.cbFiltroDistribuidor);
            this.panel1.Controls.Add(this.gbGama);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbFiltroMarca);
            this.panel1.Controls.Add(this.cbFiltroTipo);
            this.panel1.Controls.Add(this.lbFiltroVehiculos);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 287);
            this.panel1.TabIndex = 1;
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
            // cbFiltroModelo
            // 
            this.cbFiltroModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFiltroModelo.Enabled = false;
            this.cbFiltroModelo.FormattingEnabled = true;
            this.cbFiltroModelo.Location = new System.Drawing.Point(160, 81);
            this.cbFiltroModelo.Name = "cbFiltroModelo";
            this.cbFiltroModelo.Size = new System.Drawing.Size(175, 21);
            this.cbFiltroModelo.TabIndex = 9;
            this.cbFiltroModelo.SelectedIndexChanged += new System.EventHandler(this.cbFiltroModelo_SelectedIndexChanged);
            // 
            // gbTraccionCamioneta
            // 
            this.gbTraccionCamioneta.Controls.Add(this.checkFiltroTraccionSimple);
            this.gbTraccionCamioneta.Controls.Add(this.checkFiltro4x4);
            this.gbTraccionCamioneta.Location = new System.Drawing.Point(456, 73);
            this.gbTraccionCamioneta.Name = "gbTraccionCamioneta";
            this.gbTraccionCamioneta.Size = new System.Drawing.Size(125, 83);
            this.gbTraccionCamioneta.TabIndex = 8;
            this.gbTraccionCamioneta.TabStop = false;
            this.gbTraccionCamioneta.Text = "Traccion Camioneta";
            this.gbTraccionCamioneta.MouseHover += new System.EventHandler(this.gbTraccionCamioneta_MouseHover);
            // 
            // checkFiltroTraccionSimple
            // 
            this.checkFiltroTraccionSimple.AutoSize = true;
            this.checkFiltroTraccionSimple.Location = new System.Drawing.Point(11, 28);
            this.checkFiltroTraccionSimple.Name = "checkFiltroTraccionSimple";
            this.checkFiltroTraccionSimple.Size = new System.Drawing.Size(102, 17);
            this.checkFiltroTraccionSimple.TabIndex = 2;
            this.checkFiltroTraccionSimple.Text = "Traccion Simple";
            this.checkFiltroTraccionSimple.UseVisualStyleBackColor = true;
            this.checkFiltroTraccionSimple.CheckedChanged += new System.EventHandler(this.checkFiltroTraccionSimple_CheckedChanged);
            // 
            // checkFiltro4x4
            // 
            this.checkFiltro4x4.AutoSize = true;
            this.checkFiltro4x4.Enabled = false;
            this.checkFiltro4x4.Location = new System.Drawing.Point(11, 51);
            this.checkFiltro4x4.Name = "checkFiltro4x4";
            this.checkFiltro4x4.Size = new System.Drawing.Size(43, 17);
            this.checkFiltro4x4.TabIndex = 1;
            this.checkFiltro4x4.Text = "4x4";
            this.checkFiltro4x4.UseVisualStyleBackColor = true;
            this.checkFiltro4x4.CheckedChanged += new System.EventHandler(this.checkFiltro4x4_CheckedChanged);
            // 
            // gbCondicion
            // 
            this.gbCondicion.Controls.Add(this.checkFiltroNuevo);
            this.gbCondicion.Controls.Add(this.checkFiltroUsado);
            this.gbCondicion.Location = new System.Drawing.Point(456, 16);
            this.gbCondicion.Name = "gbCondicion";
            this.gbCondicion.Size = new System.Drawing.Size(125, 50);
            this.gbCondicion.TabIndex = 8;
            this.gbCondicion.TabStop = false;
            this.gbCondicion.Text = "Condicion";
            // 
            // checkFiltroNuevo
            // 
            this.checkFiltroNuevo.AutoSize = true;
            this.checkFiltroNuevo.Checked = true;
            this.checkFiltroNuevo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFiltroNuevo.Location = new System.Drawing.Point(63, 21);
            this.checkFiltroNuevo.Name = "checkFiltroNuevo";
            this.checkFiltroNuevo.Size = new System.Drawing.Size(58, 17);
            this.checkFiltroNuevo.TabIndex = 2;
            this.checkFiltroNuevo.Text = "Nuevo";
            this.checkFiltroNuevo.UseVisualStyleBackColor = true;
            this.checkFiltroNuevo.CheckedChanged += new System.EventHandler(this.checkFiltroNuevo_CheckedChanged);
            // 
            // checkFiltroUsado
            // 
            this.checkFiltroUsado.AutoSize = true;
            this.checkFiltroUsado.Checked = true;
            this.checkFiltroUsado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkFiltroUsado.Location = new System.Drawing.Point(8, 21);
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
            // gbGama
            // 
            this.gbGama.Controls.Add(this.rbGamaTodos);
            this.gbGama.Controls.Add(this.rbFull);
            this.gbGama.Controls.Add(this.rbMedia);
            this.gbGama.Controls.Add(this.rbBase);
            this.gbGama.Location = new System.Drawing.Point(357, 16);
            this.gbGama.Name = "gbGama";
            this.gbGama.Size = new System.Drawing.Size(83, 108);
            this.gbGama.TabIndex = 4;
            this.gbGama.TabStop = false;
            this.gbGama.Text = "Gama";
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
            this.lbFiltroVehiculos.ContextMenuStrip = this.mcEliminarVehiculo;
            this.lbFiltroVehiculos.FormattingEnabled = true;
            this.lbFiltroVehiculos.Location = new System.Drawing.Point(18, 143);
            this.lbFiltroVehiculos.Name = "lbFiltroVehiculos";
            this.lbFiltroVehiculos.Size = new System.Drawing.Size(432, 108);
            this.lbFiltroVehiculos.TabIndex = 0;
            // 
            // mcEliminarVehiculo
            // 
            this.mcEliminarVehiculo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mciEliminarAuto,
            this.mciEliminarCamioneta,
            this.mciVenderVehiculo});
            this.mcEliminarVehiculo.Name = "mcEliminarVehiculo";
            this.mcEliminarVehiculo.Size = new System.Drawing.Size(179, 70);
            // 
            // mciEliminarAuto
            // 
            this.mciEliminarAuto.Name = "mciEliminarAuto";
            this.mciEliminarAuto.Size = new System.Drawing.Size(178, 22);
            this.mciEliminarAuto.Text = "Eliminar Auto";
            this.mciEliminarAuto.Click += new System.EventHandler(this.mciEliminarAuto_Click);
            // 
            // mciEliminarCamioneta
            // 
            this.mciEliminarCamioneta.Name = "mciEliminarCamioneta";
            this.mciEliminarCamioneta.Size = new System.Drawing.Size(178, 22);
            this.mciEliminarCamioneta.Text = "Eliminar Camioneta";
            this.mciEliminarCamioneta.Click += new System.EventHandler(this.mciEliminarCamioneta_Click);
            // 
            // mciVenderVehiculo
            // 
            this.mciVenderVehiculo.Name = "mciVenderVehiculo";
            this.mciVenderVehiculo.Size = new System.Drawing.Size(178, 22);
            this.mciVenderVehiculo.Text = "Vender Vehiculo";
            this.mciVenderVehiculo.Click += new System.EventHandler(this.mciVenderVehiculo_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lCantidadTotalDistribuidores);
            this.panel2.Controls.Add(this.gbDistribuidores);
            this.panel2.Controls.Add(this.lCantListadoDistribuidores);
            this.panel2.Controls.Add(this.lbFiltroDistribuidores);
            this.panel2.Location = new System.Drawing.Point(614, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 287);
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
            // gbDistribuidores
            // 
            this.gbDistribuidores.Controls.Add(this.rbTodos);
            this.gbDistribuidores.Controls.Add(this.rbInternacional);
            this.gbDistribuidores.Controls.Add(this.rbNacional);
            this.gbDistribuidores.Location = new System.Drawing.Point(296, 15);
            this.gbDistribuidores.Name = "gbDistribuidores";
            this.gbDistribuidores.Size = new System.Drawing.Size(112, 95);
            this.gbDistribuidores.TabIndex = 1;
            this.gbDistribuidores.TabStop = false;
            this.gbDistribuidores.Text = "Distribuidores";
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
            this.lbFiltroDistribuidores.ContextMenuStrip = this.mcEliminarDitribuidor;
            this.lbFiltroDistribuidores.FormattingEnabled = true;
            this.lbFiltroDistribuidores.Location = new System.Drawing.Point(18, 14);
            this.lbFiltroDistribuidores.Name = "lbFiltroDistribuidores";
            this.lbFiltroDistribuidores.Size = new System.Drawing.Size(268, 238);
            this.lbFiltroDistribuidores.TabIndex = 0;
            // 
            // mcEliminarDitribuidor
            // 
            this.mcEliminarDitribuidor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem1});
            this.mcEliminarDitribuidor.Name = "mcEliminarDitribuidor";
            this.mcEliminarDitribuidor.Size = new System.Drawing.Size(118, 26);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // FConcesionaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 335);
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
            this.gbTraccionCamioneta.ResumeLayout(false);
            this.gbTraccionCamioneta.PerformLayout();
            this.gbCondicion.ResumeLayout(false);
            this.gbCondicion.PerformLayout();
            this.gbGama.ResumeLayout(false);
            this.gbGama.PerformLayout();
            this.mcEliminarVehiculo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.gbDistribuidores.ResumeLayout(false);
            this.gbDistribuidores.PerformLayout();
            this.mcEliminarDitribuidor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msPrincipal;
        private System.Windows.Forms.ToolStripMenuItem msAutos;
        private System.Windows.Forms.ToolStripMenuItem msCamioneta;
        private System.Windows.Forms.ToolStripMenuItem msDistribuidor;
        private System.Windows.Forms.ToolStripMenuItem miAgregarDistribuidor;
        private System.Windows.Forms.ToolStripMenuItem miModificarDistribuidor;
        private System.Windows.Forms.ToolStripMenuItem miEliminarDistribuidor;
        private System.Windows.Forms.ToolStripMenuItem msSalir;
        private System.Windows.Forms.ToolStripMenuItem msAcercaDe;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gbGama;
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
        private System.Windows.Forms.GroupBox gbDistribuidores;
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
        private System.Windows.Forms.GroupBox gbTraccionCamioneta;
        private System.Windows.Forms.GroupBox gbCondicion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbFiltroModelo;
        private System.Windows.Forms.CheckBox checkFiltroTraccionSimple;
        private System.Windows.Forms.CheckBox checkFiltroNuevo;
        private System.Windows.Forms.ToolTip ttipTraccionCamioneta;
        private System.Windows.Forms.ContextMenuStrip mcEliminarVehiculo;
        private System.Windows.Forms.ToolStripMenuItem mciEliminarAuto;
        private System.Windows.Forms.ContextMenuStrip mcEliminarDitribuidor;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mciEliminarCamioneta;
        private System.Windows.Forms.ToolStripMenuItem msVentas;
        private System.Windows.Forms.ToolStripMenuItem mciVenderVehiculo;
    }
}

