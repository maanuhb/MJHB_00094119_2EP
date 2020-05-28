using System.ComponentModel;

namespace Hugo_APP_Parcial_02_POO
{
    partial class frmAdministradorUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(frmAdministradorUsuarios));
            this.tabMenu = new System.Windows.Forms.TabControl();
            this.tabVerUsuarios = new System.Windows.Forms.TabPage();
            this.btnActualizarD = new System.Windows.Forms.Button();
            this.dtgUsuarios = new System.Windows.Forms.DataGridView();
            this.btnCrearU = new System.Windows.Forms.Button();
            this.txtNuevoUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuarioVU = new System.Windows.Forms.Label();
            this.tabAdminUsuarios = new System.Windows.Forms.TabPage();
            this.lblUsuarioAU = new System.Windows.Forms.Label();
            this.grpEliminarC = new System.Windows.Forms.GroupBox();
            this.btnEliminarAU = new System.Windows.Forms.Button();
            this.btnGuardarAu = new System.Windows.Forms.Button();
            this.cmbUsuarioAU = new System.Windows.Forms.ComboBox();
            this.grpPermisosAdmin = new System.Windows.Forms.GroupBox();
            this.radAdministrador = new System.Windows.Forms.RadioButton();
            this.radUsuario = new System.Windows.Forms.RadioButton();
            this.tabVTPedidos = new System.Windows.Forms.TabPage();
            this.btnActualizarPedidos = new System.Windows.Forms.Button();
            this.dtgPedidos = new System.Windows.Forms.DataGridView();
            this.tabNegocios = new System.Windows.Forms.TabPage();
            this.grpAgregarN = new System.Windows.Forms.GroupBox();
            this.txtDNegocio = new System.Windows.Forms.TextBox();
            this.txtNNegocio = new System.Windows.Forms.TextBox();
            this.lblDescripcionN = new System.Windows.Forms.Label();
            this.btnAgregarN = new System.Windows.Forms.Button();
            this.lblIngresaN = new System.Windows.Forms.Label();
            this.grpEliminarN = new System.Windows.Forms.GroupBox();
            this.btnEliminarN = new System.Windows.Forms.Button();
            this.cmbNE = new System.Windows.Forms.ComboBox();
            this.lblElegirNE = new System.Windows.Forms.Label();
            this.tabProductos = new System.Windows.Forms.TabPage();
            this.grpEliminarProducto = new System.Windows.Forms.GroupBox();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.cmbNegocioPElim = new System.Windows.Forms.ComboBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.lblProductoEP = new System.Windows.Forms.Label();
            this.lblNegocioPElim = new System.Windows.Forms.Label();
            this.grpAgregarProducto = new System.Windows.Forms.GroupBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.txtProductoN = new System.Windows.Forms.TextBox();
            this.cmbNegociosP = new System.Windows.Forms.ComboBox();
            this.lblProductoP = new System.Windows.Forms.Label();
            this.lblAgregarNP = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.txtNuevoEmpleado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabMenu.SuspendLayout();
            this.tabVerUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtgUsuarios)).BeginInit();
            this.tabAdminUsuarios.SuspendLayout();
            this.grpEliminarC.SuspendLayout();
            this.grpPermisosAdmin.SuspendLayout();
            this.tabVTPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtgPedidos)).BeginInit();
            this.tabNegocios.SuspendLayout();
            this.grpAgregarN.SuspendLayout();
            this.grpEliminarN.SuspendLayout();
            this.tabProductos.SuspendLayout();
            this.grpEliminarProducto.SuspendLayout();
            this.grpAgregarProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMenu
            // 
            this.tabMenu.Controls.Add(this.tabVerUsuarios);
            this.tabMenu.Controls.Add(this.tabAdminUsuarios);
            this.tabMenu.Controls.Add(this.tabVTPedidos);
            this.tabMenu.Controls.Add(this.tabNegocios);
            this.tabMenu.Controls.Add(this.tabProductos);
            this.tabMenu.Location = new System.Drawing.Point(12, 11);
            this.tabMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabMenu.Name = "tabMenu";
            this.tabMenu.SelectedIndex = 0;
            this.tabMenu.Size = new System.Drawing.Size(978, 675);
            this.tabMenu.TabIndex = 0;
            // 
            // tabVerUsuarios
            // 
            this.tabVerUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.tabVerUsuarios.Controls.Add(this.btnActualizarD);
            this.tabVerUsuarios.Controls.Add(this.dtgUsuarios);
            this.tabVerUsuarios.Controls.Add(this.btnCrearU);
            this.tabVerUsuarios.Controls.Add(this.txtNuevoUsuario);
            this.tabVerUsuarios.Controls.Add(this.lblUsuarioVU);
            this.tabVerUsuarios.Location = new System.Drawing.Point(4, 34);
            this.tabVerUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVerUsuarios.Name = "tabVerUsuarios";
            this.tabVerUsuarios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVerUsuarios.Size = new System.Drawing.Size(970, 637);
            this.tabVerUsuarios.TabIndex = 3;
            this.tabVerUsuarios.Text = "Ver todos los Usuarios";
            // 
            // btnActualizarD
            // 
            this.btnActualizarD.BackColor = System.Drawing.Color.Indigo;
            this.btnActualizarD.ForeColor = System.Drawing.Color.White;
            this.btnActualizarD.Location = new System.Drawing.Point(589, 454);
            this.btnActualizarD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizarD.Name = "btnActualizarD";
            this.btnActualizarD.Size = new System.Drawing.Size(184, 45);
            this.btnActualizarD.TabIndex = 20;
            this.btnActualizarD.Text = "Actualizar datos";
            this.btnActualizarD.UseVisualStyleBackColor = false;
            this.btnActualizarD.Click += new System.EventHandler(this.btnActualizarD_Click);
            this.btnActualizarD.MouseLeave += new System.EventHandler(this.btnActualizarD_MouseLeave);
            this.btnActualizarD.MouseHover += new System.EventHandler(this.btnActualizarD_MouseHover);
            // 
            // dtgUsuarios
            // 
            this.dtgUsuarios.AllowUserToAddRows = false;
            this.dtgUsuarios.AllowUserToDeleteRows = false;
            this.dtgUsuarios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgUsuarios.Location = new System.Drawing.Point(134, 110);
            this.dtgUsuarios.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgUsuarios.Name = "dtgUsuarios";
            this.dtgUsuarios.ReadOnly = true;
            this.dtgUsuarios.Size = new System.Drawing.Size(641, 334);
            this.dtgUsuarios.TabIndex = 19;
            // 
            // btnCrearU
            // 
            this.btnCrearU.BackColor = System.Drawing.Color.Indigo;
            this.btnCrearU.ForeColor = System.Drawing.Color.White;
            this.btnCrearU.Location = new System.Drawing.Point(536, 54);
            this.btnCrearU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrearU.Name = "btnCrearU";
            this.btnCrearU.Size = new System.Drawing.Size(184, 45);
            this.btnCrearU.TabIndex = 18;
            this.btnCrearU.Text = "Crear usuario";
            this.btnCrearU.UseVisualStyleBackColor = false;
            this.btnCrearU.Click += new System.EventHandler(this.btnCrearU_Click);
            this.btnCrearU.MouseLeave += new System.EventHandler(this.btnCrearU_MouseLeave);
            this.btnCrearU.MouseHover += new System.EventHandler(this.btnCrearU_MouseHover);
            // 
            // txtNuevoUsuario
            // 
            this.txtNuevoUsuario.Location = new System.Drawing.Point(278, 59);
            this.txtNuevoUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevoUsuario.MaxLength = 25;
            this.txtNuevoUsuario.Name = "txtNuevoUsuario";
            this.txtNuevoUsuario.Size = new System.Drawing.Size(248, 31);
            this.txtNuevoUsuario.TabIndex = 17;
            // 
            // lblUsuarioVU
            // 
            this.lblUsuarioVU.Location = new System.Drawing.Point(134, 64);
            this.lblUsuarioVU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioVU.Name = "lblUsuarioVU";
            this.lblUsuarioVU.Size = new System.Drawing.Size(134, 41);
            this.lblUsuarioVU.TabIndex = 16;
            this.lblUsuarioVU.Text = "Usuario:";
            this.lblUsuarioVU.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabAdminUsuarios
            // 
            this.tabAdminUsuarios.Controls.Add(this.lblUsuarioAU);
            this.tabAdminUsuarios.Controls.Add(this.grpEliminarC);
            this.tabAdminUsuarios.Controls.Add(this.btnGuardarAu);
            this.tabAdminUsuarios.Controls.Add(this.cmbUsuarioAU);
            this.tabAdminUsuarios.Controls.Add(this.grpPermisosAdmin);
            this.tabAdminUsuarios.Location = new System.Drawing.Point(4, 34);
            this.tabAdminUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminUsuarios.Name = "tabAdminUsuarios";
            this.tabAdminUsuarios.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabAdminUsuarios.Size = new System.Drawing.Size(970, 637);
            this.tabAdminUsuarios.TabIndex = 4;
            this.tabAdminUsuarios.Text = "Administrar Usuarios";
            this.tabAdminUsuarios.UseVisualStyleBackColor = true;
            // 
            // lblUsuarioAU
            // 
            this.lblUsuarioAU.Location = new System.Drawing.Point(129, 72);
            this.lblUsuarioAU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuarioAU.Name = "lblUsuarioAU";
            this.lblUsuarioAU.Size = new System.Drawing.Size(149, 45);
            this.lblUsuarioAU.TabIndex = 18;
            this.lblUsuarioAU.Text = "Usuarios:";
            this.lblUsuarioAU.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // grpEliminarC
            // 
            this.grpEliminarC.BackColor = System.Drawing.Color.White;
            this.grpEliminarC.Controls.Add(this.btnEliminarAU);
            this.grpEliminarC.Location = new System.Drawing.Point(481, 257);
            this.grpEliminarC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEliminarC.Name = "grpEliminarC";
            this.grpEliminarC.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEliminarC.Size = new System.Drawing.Size(330, 158);
            this.grpEliminarC.TabIndex = 19;
            this.grpEliminarC.TabStop = false;
            this.grpEliminarC.Text = "Eliminar cuenta:";
            // 
            // btnEliminarAU
            // 
            this.btnEliminarAU.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarAU.ForeColor = System.Drawing.Color.White;
            this.btnEliminarAU.Location = new System.Drawing.Point(95, 73);
            this.btnEliminarAU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarAU.Name = "btnEliminarAU";
            this.btnEliminarAU.Size = new System.Drawing.Size(184, 53);
            this.btnEliminarAU.TabIndex = 10;
            this.btnEliminarAU.Text = "Eliminar";
            this.btnEliminarAU.UseVisualStyleBackColor = false;
            this.btnEliminarAU.Click += new System.EventHandler(this.btnEliminarAU_Click);
            this.btnEliminarAU.MouseLeave += new System.EventHandler(this.btnEliminarAU_MouseLeave);
            this.btnEliminarAU.MouseHover += new System.EventHandler(this.btnEliminarAU_MouseHover);
            // 
            // btnGuardarAu
            // 
            this.btnGuardarAu.BackColor = System.Drawing.Color.Indigo;
            this.btnGuardarAu.ForeColor = System.Drawing.Color.White;
            this.btnGuardarAu.Location = new System.Drawing.Point(359, 132);
            this.btnGuardarAu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarAu.Name = "btnGuardarAu";
            this.btnGuardarAu.Size = new System.Drawing.Size(184, 45);
            this.btnGuardarAu.TabIndex = 21;
            this.btnGuardarAu.Text = "Guardar cambios";
            this.btnGuardarAu.UseVisualStyleBackColor = false;
            this.btnGuardarAu.Click += new System.EventHandler(this.btnGuardarAu_Click);
            this.btnGuardarAu.MouseLeave += new System.EventHandler(this.btnGuardarAu_MouseLeave);
            this.btnGuardarAu.MouseHover += new System.EventHandler(this.btnGuardarAu_MouseHover);
            // 
            // cmbUsuarioAU
            // 
            this.cmbUsuarioAU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarioAU.FormattingEnabled = true;
            this.cmbUsuarioAU.Location = new System.Drawing.Point(284, 69);
            this.cmbUsuarioAU.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbUsuarioAU.Name = "cmbUsuarioAU";
            this.cmbUsuarioAU.Size = new System.Drawing.Size(364, 33);
            this.cmbUsuarioAU.TabIndex = 20;
            this.cmbUsuarioAU.SelectedIndexChanged += new System.EventHandler(this.cmbUsuarioAU_SelectedIndexChanged);
            // 
            // grpPermisosAdmin
            // 
            this.grpPermisosAdmin.BackColor = System.Drawing.Color.White;
            this.grpPermisosAdmin.Controls.Add(this.radAdministrador);
            this.grpPermisosAdmin.Controls.Add(this.radUsuario);
            this.grpPermisosAdmin.Location = new System.Drawing.Point(129, 265);
            this.grpPermisosAdmin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPermisosAdmin.Name = "grpPermisosAdmin";
            this.grpPermisosAdmin.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpPermisosAdmin.Size = new System.Drawing.Size(311, 150);
            this.grpPermisosAdmin.TabIndex = 16;
            this.grpPermisosAdmin.TabStop = false;
            this.grpPermisosAdmin.Text = "Permisos de administrador:";
            // 
            // radAdministrador
            // 
            this.radAdministrador.Location = new System.Drawing.Point(41, 86);
            this.radAdministrador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radAdministrador.Name = "radAdministrador";
            this.radAdministrador.Size = new System.Drawing.Size(201, 40);
            this.radAdministrador.TabIndex = 1;
            this.radAdministrador.Text = "Administrador";
            this.radAdministrador.UseVisualStyleBackColor = true;
            // 
            // radUsuario
            // 
            this.radUsuario.Checked = true;
            this.radUsuario.Location = new System.Drawing.Point(41, 36);
            this.radUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radUsuario.Name = "radUsuario";
            this.radUsuario.Size = new System.Drawing.Size(201, 40);
            this.radUsuario.TabIndex = 0;
            this.radUsuario.TabStop = true;
            this.radUsuario.Text = "Usuario";
            this.radUsuario.UseVisualStyleBackColor = true;
            // 
            // tabVTPedidos
            // 
            this.tabVTPedidos.Controls.Add(this.btnActualizarPedidos);
            this.tabVTPedidos.Controls.Add(this.dtgPedidos);
            this.tabVTPedidos.Location = new System.Drawing.Point(4, 34);
            this.tabVTPedidos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVTPedidos.Name = "tabVTPedidos";
            this.tabVTPedidos.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabVTPedidos.Size = new System.Drawing.Size(970, 637);
            this.tabVTPedidos.TabIndex = 5;
            this.tabVTPedidos.Text = "Ver Todos Los pedidos";
            this.tabVTPedidos.UseVisualStyleBackColor = true;
            // 
            // btnActualizarPedidos
            // 
            this.btnActualizarPedidos.BackColor = System.Drawing.Color.Indigo;
            this.btnActualizarPedidos.ForeColor = System.Drawing.Color.White;
            this.btnActualizarPedidos.Location = new System.Drawing.Point(615, 42);
            this.btnActualizarPedidos.Name = "btnActualizarPedidos";
            this.btnActualizarPedidos.Size = new System.Drawing.Size(190, 50);
            this.btnActualizarPedidos.TabIndex = 16;
            this.btnActualizarPedidos.Text = "Actualizar Pedidos";
            this.btnActualizarPedidos.UseVisualStyleBackColor = false;
            this.btnActualizarPedidos.Click += new System.EventHandler(this.btnActualizarPedidos_Click);
            this.btnActualizarPedidos.MouseLeave += new System.EventHandler(this.btnActualizarPedidos_MouseLeave);
            this.btnActualizarPedidos.MouseHover += new System.EventHandler(this.btnActualizarPedidos_MouseHover);
            // 
            // dtgPedidos
            // 
            this.dtgPedidos.AllowUserToAddRows = false;
            this.dtgPedidos.AllowUserToDeleteRows = false;
            this.dtgPedidos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPedidos.Location = new System.Drawing.Point(165, 131);
            this.dtgPedidos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgPedidos.Name = "dtgPedidos";
            this.dtgPedidos.ReadOnly = true;
            this.dtgPedidos.Size = new System.Drawing.Size(641, 334);
            this.dtgPedidos.TabIndex = 15;
            // 
            // tabNegocios
            // 
            this.tabNegocios.Controls.Add(this.grpAgregarN);
            this.tabNegocios.Controls.Add(this.grpEliminarN);
            this.tabNegocios.Location = new System.Drawing.Point(4, 34);
            this.tabNegocios.Name = "tabNegocios";
            this.tabNegocios.Padding = new System.Windows.Forms.Padding(3);
            this.tabNegocios.Size = new System.Drawing.Size(970, 637);
            this.tabNegocios.TabIndex = 6;
            this.tabNegocios.Text = "Negocios";
            this.tabNegocios.UseVisualStyleBackColor = true;
            // 
            // grpAgregarN
            // 
            this.grpAgregarN.Controls.Add(this.txtDNegocio);
            this.grpAgregarN.Controls.Add(this.txtNNegocio);
            this.grpAgregarN.Controls.Add(this.lblDescripcionN);
            this.grpAgregarN.Controls.Add(this.btnAgregarN);
            this.grpAgregarN.Controls.Add(this.lblIngresaN);
            this.grpAgregarN.Location = new System.Drawing.Point(14, 18);
            this.grpAgregarN.Name = "grpAgregarN";
            this.grpAgregarN.Size = new System.Drawing.Size(925, 286);
            this.grpAgregarN.TabIndex = 21;
            this.grpAgregarN.TabStop = false;
            this.grpAgregarN.Text = "Agregar Un Negocio";
            // 
            // txtDNegocio
            // 
            this.txtDNegocio.Location = new System.Drawing.Point(513, 115);
            this.txtDNegocio.Name = "txtDNegocio";
            this.txtDNegocio.Size = new System.Drawing.Size(297, 31);
            this.txtDNegocio.TabIndex = 21;
            // 
            // txtNNegocio
            // 
            this.txtNNegocio.Location = new System.Drawing.Point(94, 115);
            this.txtNNegocio.Name = "txtNNegocio";
            this.txtNNegocio.Size = new System.Drawing.Size(297, 31);
            this.txtNNegocio.TabIndex = 20;
            // 
            // lblDescripcionN
            // 
            this.lblDescripcionN.Location = new System.Drawing.Point(513, 27);
            this.lblDescripcionN.Name = "lblDescripcionN";
            this.lblDescripcionN.Size = new System.Drawing.Size(297, 70);
            this.lblDescripcionN.TabIndex = 19;
            this.lblDescripcionN.Text = "Descripcion Del Negocio:\r\n";
            this.lblDescripcionN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregarN
            // 
            this.btnAgregarN.BackColor = System.Drawing.Color.Indigo;
            this.btnAgregarN.ForeColor = System.Drawing.Color.White;
            this.btnAgregarN.Location = new System.Drawing.Point(336, 201);
            this.btnAgregarN.Name = "btnAgregarN";
            this.btnAgregarN.Size = new System.Drawing.Size(240, 61);
            this.btnAgregarN.TabIndex = 17;
            this.btnAgregarN.Text = "Agregar Negocios";
            this.btnAgregarN.UseVisualStyleBackColor = false;
            this.btnAgregarN.Click += new System.EventHandler(this.btnAgregarN_Click);
            this.btnAgregarN.MouseLeave += new System.EventHandler(this.btnAgregarN_MouseLeave);
            this.btnAgregarN.MouseHover += new System.EventHandler(this.btnAgregarN_MouseHover);
            // 
            // lblIngresaN
            // 
            this.lblIngresaN.Location = new System.Drawing.Point(83, 27);
            this.lblIngresaN.Name = "lblIngresaN";
            this.lblIngresaN.Size = new System.Drawing.Size(297, 70);
            this.lblIngresaN.TabIndex = 18;
            this.lblIngresaN.Text = "Ingresa el nombre del Negocio:";
            this.lblIngresaN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpEliminarN
            // 
            this.grpEliminarN.Controls.Add(this.btnEliminarN);
            this.grpEliminarN.Controls.Add(this.cmbNE);
            this.grpEliminarN.Controls.Add(this.lblElegirNE);
            this.grpEliminarN.Location = new System.Drawing.Point(14, 310);
            this.grpEliminarN.Name = "grpEliminarN";
            this.grpEliminarN.Size = new System.Drawing.Size(925, 317);
            this.grpEliminarN.TabIndex = 20;
            this.grpEliminarN.TabStop = false;
            this.grpEliminarN.Text = "Eliminar un Negocio";
            // 
            // btnEliminarN
            // 
            this.btnEliminarN.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarN.ForeColor = System.Drawing.Color.White;
            this.btnEliminarN.Location = new System.Drawing.Point(336, 203);
            this.btnEliminarN.Name = "btnEliminarN";
            this.btnEliminarN.Size = new System.Drawing.Size(240, 71);
            this.btnEliminarN.TabIndex = 21;
            this.btnEliminarN.Text = "Eliminar Negocio";
            this.btnEliminarN.UseVisualStyleBackColor = false;
            this.btnEliminarN.Click += new System.EventHandler(this.btnEliminarN_Click);
            this.btnEliminarN.MouseLeave += new System.EventHandler(this.btnEliminarN_MouseLeave);
            this.btnEliminarN.MouseHover += new System.EventHandler(this.btnEliminarN_MouseHover);
            // 
            // cmbNE
            // 
            this.cmbNE.FormattingEnabled = true;
            this.cmbNE.Location = new System.Drawing.Point(440, 65);
            this.cmbNE.Name = "cmbNE";
            this.cmbNE.Size = new System.Drawing.Size(370, 33);
            this.cmbNE.TabIndex = 20;
            // 
            // lblElegirNE
            // 
            this.lblElegirNE.Location = new System.Drawing.Point(66, 45);
            this.lblElegirNE.Name = "lblElegirNE";
            this.lblElegirNE.Size = new System.Drawing.Size(314, 70);
            this.lblElegirNE.TabIndex = 19;
            this.lblElegirNE.Text = "Elige el negocio que deseas eliminar:";
            this.lblElegirNE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabProductos
            // 
            this.tabProductos.Controls.Add(this.grpEliminarProducto);
            this.tabProductos.Controls.Add(this.grpAgregarProducto);
            this.tabProductos.Location = new System.Drawing.Point(4, 34);
            this.tabProductos.Name = "tabProductos";
            this.tabProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabProductos.Size = new System.Drawing.Size(970, 637);
            this.tabProductos.TabIndex = 7;
            this.tabProductos.Text = "Productos";
            this.tabProductos.UseVisualStyleBackColor = true;
            // 
            // grpEliminarProducto
            // 
            this.grpEliminarProducto.Controls.Add(this.btnEliminarProducto);
            this.grpEliminarProducto.Controls.Add(this.cmbNegocioPElim);
            this.grpEliminarProducto.Controls.Add(this.cmbProductos);
            this.grpEliminarProducto.Controls.Add(this.lblProductoEP);
            this.grpEliminarProducto.Controls.Add(this.lblNegocioPElim);
            this.grpEliminarProducto.Location = new System.Drawing.Point(458, 14);
            this.grpEliminarProducto.Name = "grpEliminarProducto";
            this.grpEliminarProducto.Size = new System.Drawing.Size(506, 613);
            this.grpEliminarProducto.TabIndex = 1;
            this.grpEliminarProducto.TabStop = false;
            this.grpEliminarProducto.Text = "Eliminar un Producto";
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.Color.Crimson;
            this.btnEliminarProducto.ForeColor = System.Drawing.Color.White;
            this.btnEliminarProducto.Location = new System.Drawing.Point(104, 425);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(282, 74);
            this.btnEliminarProducto.TabIndex = 5;
            this.btnEliminarProducto.Text = "Eliminar Producto";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            this.btnEliminarProducto.MouseLeave += new System.EventHandler(this.btnEliminarProducto_MouseLeave);
            this.btnEliminarProducto.MouseHover += new System.EventHandler(this.btnEliminarProducto_MouseHover);
            // 
            // cmbNegocioPElim
            // 
            this.cmbNegocioPElim.FormattingEnabled = true;
            this.cmbNegocioPElim.Location = new System.Drawing.Point(132, 144);
            this.cmbNegocioPElim.Name = "cmbNegocioPElim";
            this.cmbNegocioPElim.Size = new System.Drawing.Size(237, 33);
            this.cmbNegocioPElim.TabIndex = 4;
            // 
            // cmbProductos
            // 
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(132, 327);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(237, 33);
            this.cmbProductos.TabIndex = 3;
            // 
            // lblProductoEP
            // 
            this.lblProductoEP.Location = new System.Drawing.Point(72, 238);
            this.lblProductoEP.Name = "lblProductoEP";
            this.lblProductoEP.Size = new System.Drawing.Size(353, 61);
            this.lblProductoEP.TabIndex = 2;
            this.lblProductoEP.Text = "Introduce el Producto que Deseas Eliminar:";
            this.lblProductoEP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNegocioPElim
            // 
            this.lblNegocioPElim.Location = new System.Drawing.Point(132, 56);
            this.lblNegocioPElim.Name = "lblNegocioPElim";
            this.lblNegocioPElim.Size = new System.Drawing.Size(254, 61);
            this.lblNegocioPElim.TabIndex = 1;
            this.lblNegocioPElim.Text = "Introduce el Negocio:";
            this.lblNegocioPElim.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpAgregarProducto
            // 
            this.grpAgregarProducto.Controls.Add(this.btnAgregarProducto);
            this.grpAgregarProducto.Controls.Add(this.txtProductoN);
            this.grpAgregarProducto.Controls.Add(this.cmbNegociosP);
            this.grpAgregarProducto.Controls.Add(this.lblProductoP);
            this.grpAgregarProducto.Controls.Add(this.lblAgregarNP);
            this.grpAgregarProducto.Location = new System.Drawing.Point(14, 14);
            this.grpAgregarProducto.Name = "grpAgregarProducto";
            this.grpAgregarProducto.Size = new System.Drawing.Size(438, 613);
            this.grpAgregarProducto.TabIndex = 0;
            this.grpAgregarProducto.TabStop = false;
            this.grpAgregarProducto.Text = "Agregar un Nuevo Producto:";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.BackColor = System.Drawing.Color.Indigo;
            this.btnAgregarProducto.ForeColor = System.Drawing.Color.White;
            this.btnAgregarProducto.Location = new System.Drawing.Point(95, 425);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(282, 74);
            this.btnAgregarProducto.TabIndex = 4;
            this.btnAgregarProducto.Text = "Agregar Producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = false;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            this.btnAgregarProducto.MouseLeave += new System.EventHandler(this.btnAgregarProducto_MouseLeave);
            this.btnAgregarProducto.MouseHover += new System.EventHandler(this.btnAgregarProducto_MouseHover);
            // 
            // txtProductoN
            // 
            this.txtProductoN.Location = new System.Drawing.Point(96, 329);
            this.txtProductoN.Name = "txtProductoN";
            this.txtProductoN.Size = new System.Drawing.Size(230, 31);
            this.txtProductoN.TabIndex = 3;
            // 
            // cmbNegociosP
            // 
            this.cmbNegociosP.FormattingEnabled = true;
            this.cmbNegociosP.Location = new System.Drawing.Point(95, 144);
            this.cmbNegociosP.Name = "cmbNegociosP";
            this.cmbNegociosP.Size = new System.Drawing.Size(231, 33);
            this.cmbNegociosP.TabIndex = 2;
            // 
            // lblProductoP
            // 
            this.lblProductoP.Location = new System.Drawing.Point(50, 238);
            this.lblProductoP.Name = "lblProductoP";
            this.lblProductoP.Size = new System.Drawing.Size(337, 61);
            this.lblProductoP.TabIndex = 1;
            this.lblProductoP.Text = "Ingresa el Nombre del nuevo Producto:";
            this.lblProductoP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAgregarNP
            // 
            this.lblAgregarNP.Location = new System.Drawing.Point(72, 56);
            this.lblAgregarNP.Name = "lblAgregarNP";
            this.lblAgregarNP.Size = new System.Drawing.Size(254, 61);
            this.lblAgregarNP.TabIndex = 0;
            this.lblAgregarNP.Text = "Introduce un Negocio:";
            this.lblAgregarNP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(589, 454);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(184, 45);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar datos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.AllowUserToAddRows = false;
            this.dgvEmpleados.AllowUserToDeleteRows = false;
            this.dgvEmpleados.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(134, 110);
            this.dgvEmpleados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.ReadOnly = true;
            this.dgvEmpleados.Size = new System.Drawing.Size(641, 334);
            this.dgvEmpleados.TabIndex = 24;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(536, 54);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(184, 45);
            this.btnCrearUsuario.TabIndex = 23;
            this.btnCrearUsuario.Text = "Crear usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            // 
            // txtNuevoEmpleado
            // 
            this.txtNuevoEmpleado.Location = new System.Drawing.Point(278, 59);
            this.txtNuevoEmpleado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNuevoEmpleado.MaxLength = 25;
            this.txtNuevoEmpleado.Name = "txtNuevoEmpleado";
            this.txtNuevoEmpleado.Size = new System.Drawing.Size(248, 26);
            this.txtNuevoEmpleado.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(134, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 41);
            this.label1.TabIndex = 21;
            this.label1.Text = "Empleado:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmAdministradorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1002, 684);
            this.Controls.Add(this.tabMenu);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdministradorUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tabMenu.ResumeLayout(false);
            this.tabVerUsuarios.ResumeLayout(false);
            this.tabVerUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dtgUsuarios)).EndInit();
            this.tabAdminUsuarios.ResumeLayout(false);
            this.grpEliminarC.ResumeLayout(false);
            this.grpPermisosAdmin.ResumeLayout(false);
            this.tabVTPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dtgPedidos)).EndInit();
            this.tabNegocios.ResumeLayout(false);
            this.grpAgregarN.ResumeLayout(false);
            this.grpAgregarN.PerformLayout();
            this.grpEliminarN.ResumeLayout(false);
            this.tabProductos.ResumeLayout(false);
            this.grpEliminarProducto.ResumeLayout(false);
            this.grpAgregarProducto.ResumeLayout(false);
            this.grpAgregarProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleados)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNuevoEmpleado;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.RadioButton radUsuario;
        private System.Windows.Forms.TabControl tabMenu;
        private System.Windows.Forms.TabPage tabNegocios;
        private System.Windows.Forms.TabPage tabVerUsuarios;
        private System.Windows.Forms.TabPage tabAdminUsuarios;
        private System.Windows.Forms.TabPage tabVTPedidos;
        private System.Windows.Forms.Label lblUsuarioAU;
        private System.Windows.Forms.Button btnEliminarAU;
        private System.Windows.Forms.Button btnGuardarAu;
        private System.Windows.Forms.ComboBox cmbUsuarioAU;
        private System.Windows.Forms.Button btnActualizarD;
        private System.Windows.Forms.Button btnCrearU;
        private System.Windows.Forms.Label lblIngresaN;
        private System.Windows.Forms.Button btnAgregarN;
        private System.Windows.Forms.Label lblElegirNE;
        private System.Windows.Forms.ComboBox cmbNE;
        private System.Windows.Forms.Button btnEliminarN;
        private System.Windows.Forms.TextBox txtNNegocio;
        private System.Windows.Forms.TextBox txtDNegocio;
        private System.Windows.Forms.Label lblDescripcionN;
        private System.Windows.Forms.Label lblUsuarioVU;
        private System.Windows.Forms.GroupBox grpEliminarC;
        private System.Windows.Forms.GroupBox grpPermisosAdmin;
        private System.Windows.Forms.GroupBox grpEliminarN;
        private System.Windows.Forms.GroupBox grpAgregarN;
        private System.Windows.Forms.Button btnActualizarPedidos;
        private System.Windows.Forms.TabPage tabProductos;
        private System.Windows.Forms.DataGridView dtgPedidos;
        private System.Windows.Forms.DataGridView dtgUsuarios;
        private System.Windows.Forms.GroupBox grpAgregarProducto;
        private System.Windows.Forms.GroupBox grpEliminarProducto;
        private System.Windows.Forms.Label lblAgregarNP;
        private System.Windows.Forms.Label lblProductoP;
        private System.Windows.Forms.ComboBox cmbNegociosP;
        private System.Windows.Forms.TextBox txtProductoN;
        private System.Windows.Forms.Label lblNegocioPElim;
        private System.Windows.Forms.Label lblProductoEP;
        private System.Windows.Forms.ComboBox cmbNegocioPElim;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.TextBox txtNuevoUsuario;
        private System.Windows.Forms.RadioButton radAdministrador;
    }
}