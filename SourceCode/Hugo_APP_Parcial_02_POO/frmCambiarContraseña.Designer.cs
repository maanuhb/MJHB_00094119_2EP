using System.ComponentModel;

namespace Hugo_APP_Parcial_02_POO
{
    partial class frmCambiarContraseña
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
                new System.ComponentModel.ComponentResourceManager(typeof(frmCambiarContraseña));
            this.rtbNCCC = new System.Windows.Forms.RichTextBox();
            this.btnCambiarContraCC = new System.Windows.Forms.Button();
            this.picHugoCC = new System.Windows.Forms.PictureBox();
            this.lblHugoCC = new System.Windows.Forms.Label();
            this.lblNContraCC = new System.Windows.Forms.Label();
            this.lblNUCC = new System.Windows.Forms.Label();
            this.rtbRepetirContra = new System.Windows.Forms.RichTextBox();
            this.lblRepetircCC = new System.Windows.Forms.Label();
            this.cmbUserCC = new System.Windows.Forms.ComboBox();
            this.btnVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.picHugoCC)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbNCCC
            // 
            this.rtbNCCC.Location = new System.Drawing.Point(228, 291);
            this.rtbNCCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbNCCC.Name = "rtbNCCC";
            this.rtbNCCC.Size = new System.Drawing.Size(448, 46);
            this.rtbNCCC.TabIndex = 34;
            this.rtbNCCC.Text = "";
            // 
            // btnCambiarContraCC
            // 
            this.btnCambiarContraCC.BackColor = System.Drawing.Color.Indigo;
            this.btnCambiarContraCC.ForeColor = System.Drawing.Color.White;
            this.btnCambiarContraCC.Location = new System.Drawing.Point(301, 448);
            this.btnCambiarContraCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCambiarContraCC.Name = "btnCambiarContraCC";
            this.btnCambiarContraCC.Size = new System.Drawing.Size(213, 86);
            this.btnCambiarContraCC.TabIndex = 35;
            this.btnCambiarContraCC.Text = "Cambiar contraseña";
            this.btnCambiarContraCC.UseVisualStyleBackColor = false;
            this.btnCambiarContraCC.Click += new System.EventHandler(this.btnCambiarContraCC_Click);
            this.btnCambiarContraCC.MouseLeave += new System.EventHandler(this.btnCambiarContraCC_MouseLeave);
            this.btnCambiarContraCC.MouseHover += new System.EventHandler(this.btnCambiarContraCC_MouseHover);
            // 
            // picHugoCC
            // 
            this.picHugoCC.Image = ((System.Drawing.Image) (resources.GetObject("picHugoCC.Image")));
            this.picHugoCC.Location = new System.Drawing.Point(809, 12);
            this.picHugoCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHugoCC.Name = "picHugoCC";
            this.picHugoCC.Size = new System.Drawing.Size(156, 148);
            this.picHugoCC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHugoCC.TabIndex = 36;
            this.picHugoCC.TabStop = false;
            // 
            // lblHugoCC
            // 
            this.lblHugoCC.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHugoCC.ForeColor = System.Drawing.Color.Navy;
            this.lblHugoCC.Location = new System.Drawing.Point(301, 29);
            this.lblHugoCC.Name = "lblHugoCC";
            this.lblHugoCC.Size = new System.Drawing.Size(140, 52);
            this.lblHugoCC.TabIndex = 30;
            this.lblHugoCC.Text = "Hugo";
            // 
            // lblNContraCC
            // 
            this.lblNContraCC.Location = new System.Drawing.Point(9, 289);
            this.lblNContraCC.Name = "lblNContraCC";
            this.lblNContraCC.Size = new System.Drawing.Size(164, 46);
            this.lblNContraCC.TabIndex = 32;
            this.lblNContraCC.Text = "Nueva Contraseña:";
            // 
            // lblNUCC
            // 
            this.lblNUCC.Location = new System.Drawing.Point(9, 185);
            this.lblNUCC.Name = "lblNUCC";
            this.lblNUCC.Size = new System.Drawing.Size(174, 46);
            this.lblNUCC.TabIndex = 31;
            this.lblNUCC.Text = "Nombre de usuario:";
            // 
            // rtbRepetirContra
            // 
            this.rtbRepetirContra.Location = new System.Drawing.Point(228, 376);
            this.rtbRepetirContra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbRepetirContra.Name = "rtbRepetirContra";
            this.rtbRepetirContra.Size = new System.Drawing.Size(448, 46);
            this.rtbRepetirContra.TabIndex = 38;
            this.rtbRepetirContra.Text = "";
            // 
            // lblRepetircCC
            // 
            this.lblRepetircCC.Location = new System.Drawing.Point(9, 356);
            this.lblRepetircCC.Name = "lblRepetircCC";
            this.lblRepetircCC.Size = new System.Drawing.Size(186, 66);
            this.lblRepetircCC.TabIndex = 37;
            this.lblRepetircCC.Text = "Ingrese de nuevo la\r\n contraseña nueva:";
            // 
            // cmbUserCC
            // 
            this.cmbUserCC.FormattingEnabled = true;
            this.cmbUserCC.Location = new System.Drawing.Point(238, 178);
            this.cmbUserCC.Name = "cmbUserCC";
            this.cmbUserCC.Size = new System.Drawing.Size(437, 33);
            this.cmbUserCC.TabIndex = 39;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.Indigo;
            this.btnVolver.ForeColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(688, 453);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(214, 80);
            this.btnVolver.TabIndex = 40;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            this.btnVolver.MouseLeave += new System.EventHandler(this.btnVolver_MouseLeave);
            this.btnVolver.MouseHover += new System.EventHandler(this.btnVolver_MouseHover);
            // 
            // frmCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1002, 684);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.cmbUserCC);
            this.Controls.Add(this.rtbRepetirContra);
            this.Controls.Add(this.lblRepetircCC);
            this.Controls.Add(this.rtbNCCC);
            this.Controls.Add(this.btnCambiarContraCC);
            this.Controls.Add(this.picHugoCC);
            this.Controls.Add(this.lblHugoCC);
            this.Controls.Add(this.lblNContraCC);
            this.Controls.Add(this.lblNUCC);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmCambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CambiarContraseña";
            this.Load += new System.EventHandler(this.frmCambiarContraseña_Load);
            ((System.ComponentModel.ISupportInitialize) (this.picHugoCC)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblNUCC;
        private System.Windows.Forms.Label lblNContraCC;
        private System.Windows.Forms.Label lblHugoCC;
        private System.Windows.Forms.PictureBox picHugoCC;
        private System.Windows.Forms.RichTextBox rtbNCCC;
        private System.Windows.Forms.Label lblRepetircCC;
        private System.Windows.Forms.RichTextBox rtbRepetirContra;
        private System.Windows.Forms.Button btnCambiarContraCC;
        private System.Windows.Forms.ComboBox cmbUserCC;
        private System.Windows.Forms.Button btnVolver;
    }
}