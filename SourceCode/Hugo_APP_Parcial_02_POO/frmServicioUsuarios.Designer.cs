using System.ComponentModel;

namespace Hugo_APP_Parcial_02_POO
{
    partial class frmServicioUsuarios
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
                new System.ComponentModel.ComponentResourceManager(typeof(frmServicioUsuarios));
            this.tabEliminarOrden = new System.Windows.Forms.TabControl();
            this.tabPedidos = new System.Windows.Forms.TabPage();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.lblHistorialPedidos = new System.Windows.Forms.Label();
            this.dgvVerPedidos = new System.Windows.Forms.DataGridView();
            this.tabOrdenar = new System.Windows.Forms.TabPage();
            this.lblOrdenar = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.cmbMenu = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblCancelarOrden = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.cmbFactura = new System.Windows.Forms.ComboBox();
            this.tabDirecciones = new System.Windows.Forms.TabPage();
            this.btnActualizarDireccion = new System.Windows.Forms.Button();
            this.dgvDirecciones = new System.Windows.Forms.DataGridView();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEliminarOrden.SuspendLayout();
            this.tabPedidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvVerPedidos)).BeginInit();
            this.tabOrdenar.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabDirecciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDirecciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tabEliminarOrden
            // 
            this.tabEliminarOrden.Controls.Add(this.tabPedidos);
            this.tabEliminarOrden.Controls.Add(this.tabOrdenar);
            this.tabEliminarOrden.Controls.Add(this.tabPage3);
            this.tabEliminarOrden.Controls.Add(this.tabDirecciones);
            this.tabEliminarOrden.Location = new System.Drawing.Point(12, 12);
            this.tabEliminarOrden.Name = "tabEliminarOrden";
            this.tabEliminarOrden.SelectedIndex = 0;
            this.tabEliminarOrden.Size = new System.Drawing.Size(880, 554);
            this.tabEliminarOrden.TabIndex = 0;
            // 
            // tabPedidos
            // 
            this.tabPedidos.Controls.Add(this.btnActualizar);
            this.tabPedidos.Controls.Add(this.lblHistorialPedidos);
            this.tabPedidos.Controls.Add(this.dgvVerPedidos);
            this.tabPedidos.Location = new System.Drawing.Point(4, 34);
            this.tabPedidos.Name = "tabPedidos";
            this.tabPedidos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPedidos.Size = new System.Drawing.Size(872, 516);
            this.tabPedidos.TabIndex = 0;
            this.tabPedidos.Text = "Ver Pedidos";
            this.tabPedidos.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.Indigo;
            this.btnActualizar.ForeColor = System.Drawing.Color.White;
            this.btnActualizar.Location = new System.Drawing.Point(496, 22);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(245, 46);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
           
            // 
            // lblHistorialPedidos
            // 
            this.lblHistorialPedidos.Location = new System.Drawing.Point(144, 16);
            this.lblHistorialPedidos.Name = "lblHistorialPedidos";
            this.lblHistorialPedidos.Size = new System.Drawing.Size(403, 53);
            this.lblHistorialPedidos.TabIndex = 1;
            this.lblHistorialPedidos.Text = "Historial de Pedidos:";
            // 
            // dgvVerPedidos
            // 
            this.dgvVerPedidos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerPedidos.Location = new System.Drawing.Point(46, 82);
            this.dgvVerPedidos.Name = "dgvVerPedidos";
            this.dgvVerPedidos.RowTemplate.Height = 28;
            this.dgvVerPedidos.Size = new System.Drawing.Size(721, 363);
            this.dgvVerPedidos.TabIndex = 0;
            // 
            // tabOrdenar
            // 
            this.tabOrdenar.Controls.Add(this.lblOrdenar);
            this.tabOrdenar.Controls.Add(this.btnOrdenar);
            this.tabOrdenar.Controls.Add(this.cmbMenu);
            this.tabOrdenar.Controls.Add(this.label2);
            this.tabOrdenar.Location = new System.Drawing.Point(4, 29);
            this.tabOrdenar.Name = "tabOrdenar";
            this.tabOrdenar.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrdenar.Size = new System.Drawing.Size(872, 521);
            this.tabOrdenar.TabIndex = 1;
            this.tabOrdenar.Text = "Ordenar";
            this.tabOrdenar.UseVisualStyleBackColor = true;
            // 
            // lblOrdenar
            // 
            this.lblOrdenar.Location = new System.Drawing.Point(161, 13);
            this.lblOrdenar.Name = "lblOrdenar";
            this.lblOrdenar.Size = new System.Drawing.Size(430, 104);
            this.lblOrdenar.TabIndex = 3;
            this.lblOrdenar.Text = "¿Listo para ordenar? Selecciona lo que deseas y presiona el boton para efectuar l" +
                                   "a orden";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.BackColor = System.Drawing.Color.Indigo;
            this.btnOrdenar.ForeColor = System.Drawing.Color.White;
            this.btnOrdenar.Location = new System.Drawing.Point(232, 258);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(277, 74);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = false;
            
            // 
            // cmbMenu
            // 
            this.cmbMenu.FormattingEnabled = true;
            this.cmbMenu.Location = new System.Drawing.Point(193, 170);
            this.cmbMenu.Name = "cmbMenu";
            this.cmbMenu.Size = new System.Drawing.Size(382, 33);
            this.cmbMenu.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(206, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 93);
            this.label2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblCancelarOrden);
            this.tabPage3.Controls.Add(this.btnCancelar);
            this.tabPage3.Controls.Add(this.cmbFactura);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(872, 516);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Eliminar Orden";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblCancelarOrden
            // 
            this.lblCancelarOrden.Location = new System.Drawing.Point(190, 20);
            this.lblCancelarOrden.Name = "lblCancelarOrden";
            this.lblCancelarOrden.Size = new System.Drawing.Size(389, 92);
            this.lblCancelarOrden.TabIndex = 2;
            this.lblCancelarOrden.Text =
                "Quieres Cancelar la Orden? Selecciona el numero de orden y presiona el boton para" + " cancelarla";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Indigo;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(240, 227);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(310, 129);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            
            // 
            // cmbFactura
            // 
            this.cmbFactura.FormattingEnabled = true;
            this.cmbFactura.Location = new System.Drawing.Point(152, 144);
            this.cmbFactura.Name = "cmbFactura";
            this.cmbFactura.Size = new System.Drawing.Size(491, 33);
            this.cmbFactura.TabIndex = 0;
            // 
            // tabDirecciones
            // 
            this.tabDirecciones.Controls.Add(this.label1);
            this.tabDirecciones.Controls.Add(this.button1);
            this.tabDirecciones.Controls.Add(this.txtDireccion);
            this.tabDirecciones.Controls.Add(this.btnActualizarDireccion);
            this.tabDirecciones.Controls.Add(this.dgvDirecciones);
            this.tabDirecciones.Controls.Add(this.lblBienvenida);
            this.tabDirecciones.Location = new System.Drawing.Point(4, 34);
            this.tabDirecciones.Name = "tabDirecciones";
            this.tabDirecciones.Padding = new System.Windows.Forms.Padding(3);
            this.tabDirecciones.Size = new System.Drawing.Size(872, 516);
            this.tabDirecciones.TabIndex = 3;
            this.tabDirecciones.Text = "Mis Direcciones";
            this.tabDirecciones.UseVisualStyleBackColor = true;
            // 
            // btnActualizarDireccion
            // 
            this.btnActualizarDireccion.BackColor = System.Drawing.Color.Indigo;
            this.btnActualizarDireccion.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDireccion.Location = new System.Drawing.Point(613, 201);
            this.btnActualizarDireccion.Name = "btnActualizarDireccion";
            this.btnActualizarDireccion.Size = new System.Drawing.Size(134, 55);
            this.btnActualizarDireccion.TabIndex = 2;
            this.btnActualizarDireccion.Text = "Actualizar";
            this.btnActualizarDireccion.UseVisualStyleBackColor = false;
            // 
            // dgvDirecciones
            // 
            this.dgvDirecciones.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDirecciones.Location = new System.Drawing.Point(24, 276);
            this.dgvDirecciones.Name = "dgvDirecciones";
            this.dgvDirecciones.RowTemplate.Height = 28;
            this.dgvDirecciones.Size = new System.Drawing.Size(821, 218);
            this.dgvDirecciones.TabIndex = 1;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Location = new System.Drawing.Point(176, 200);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(375, 57);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Aqui Puedes consultar tus direcciones\r\n\r\n\r\n";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(307, 47);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(339, 31);
            this.txtDireccion.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Indigo;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(730, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 65);
            this.button1.TabIndex = 4;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(76, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 68);
            this.label1.TabIndex = 5;
            this.label1.Text = "agregar cuenta";
            // 
            // frmServicioUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(889, 562);
            this.Controls.Add(this.tabEliminarOrden);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmServicioUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tabEliminarOrden.ResumeLayout(false);
            this.tabPedidos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dgvVerPedidos)).EndInit();
            this.tabOrdenar.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabDirecciones.ResumeLayout(false);
            this.tabDirecciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvDirecciones)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabOrdenar;
        private System.Windows.Forms.TabPage tabPedidos;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.TabPage tabDirecciones;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabEliminarOrden;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnActualizarDireccion;
        private System.Windows.Forms.Label lblOrdenar;
        private System.Windows.Forms.ComboBox cmbFactura;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblCancelarOrden;
        private System.Windows.Forms.DataGridView dgvDirecciones;
        private System.Windows.Forms.ComboBox cmbMenu;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblHistorialPedidos;
        private System.Windows.Forms.DataGridView dgvVerPedidos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}