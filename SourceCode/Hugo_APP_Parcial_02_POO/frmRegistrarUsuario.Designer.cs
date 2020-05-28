using System.ComponentModel;

namespace Hugo_APP_Parcial_02_POO
{
    partial class frmRegistrarUsuario
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
                new System.ComponentModel.ComponentResourceManager(typeof(frmRegistrarUsuario));
            this.btnRegistrarseNuevo = new System.Windows.Forms.Button();
            this.lblCR = new System.Windows.Forms.Label();
            this.rtbCr = new System.Windows.Forms.RichTextBox();
            this.lblNUR = new System.Windows.Forms.Label();
            this.lblHugoR = new System.Windows.Forms.Label();
            this.picHugoR = new System.Windows.Forms.PictureBox();
            this.btnVolverRU = new System.Windows.Forms.Button();
            this.rtbUsuarioN = new System.Windows.Forms.RichTextBox();
            this.lblNombreC = new System.Windows.Forms.Label();
            this.rtbNCRU = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize) (this.picHugoR)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrarseNuevo
            // 
            this.btnRegistrarseNuevo.BackColor = System.Drawing.Color.Indigo;
            this.btnRegistrarseNuevo.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarseNuevo.Location = new System.Drawing.Point(264, 420);
            this.btnRegistrarseNuevo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarseNuevo.Name = "btnRegistrarseNuevo";
            this.btnRegistrarseNuevo.Size = new System.Drawing.Size(244, 86);
            this.btnRegistrarseNuevo.TabIndex = 30;
            this.btnRegistrarseNuevo.Text = "Regístrate";
            this.btnRegistrarseNuevo.UseVisualStyleBackColor = false;
            this.btnRegistrarseNuevo.Click += new System.EventHandler(this.btnRegistrarseNuevo_Click);
            this.btnRegistrarseNuevo.MouseLeave += new System.EventHandler(this.btnRegistrarseNuevo_MouseLeave);
            this.btnRegistrarseNuevo.MouseHover += new System.EventHandler(this.btnRegistrarseNuevo_MouseHover);
            // 
            // lblCR
            // 
            this.lblCR.Location = new System.Drawing.Point(47, 336);
            this.lblCR.Name = "lblCR";
            this.lblCR.Size = new System.Drawing.Size(140, 46);
            this.lblCR.TabIndex = 28;
            this.lblCR.Text = "Contraseña:";
            // 
            // rtbCr
            // 
            this.rtbCr.Location = new System.Drawing.Point(265, 338);
            this.rtbCr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rtbCr.Name = "rtbCr";
            this.rtbCr.Size = new System.Drawing.Size(346, 46);
            this.rtbCr.TabIndex = 29;
            this.rtbCr.Text = "";
            // 
            // lblNUR
            // 
            this.lblNUR.Location = new System.Drawing.Point(47, 248);
            this.lblNUR.Name = "lblNUR";
            this.lblNUR.Size = new System.Drawing.Size(213, 46);
            this.lblNUR.TabIndex = 26;
            this.lblNUR.Text = "Nombre de usuario:";
            // 
            // lblHugoR
            // 
            this.lblHugoR.Font = new System.Drawing.Font("Berlin Sans FB", 16F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblHugoR.ForeColor = System.Drawing.Color.Navy;
            this.lblHugoR.Location = new System.Drawing.Point(264, 106);
            this.lblHugoR.Name = "lblHugoR";
            this.lblHugoR.Size = new System.Drawing.Size(140, 52);
            this.lblHugoR.TabIndex = 25;
            this.lblHugoR.Text = "Hugo";
            // 
            // picHugoR
            // 
            this.picHugoR.Image = ((System.Drawing.Image) (resources.GetObject("picHugoR.Image")));
            this.picHugoR.Location = new System.Drawing.Point(703, 58);
            this.picHugoR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picHugoR.Name = "picHugoR";
            this.picHugoR.Size = new System.Drawing.Size(140, 98);
            this.picHugoR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHugoR.TabIndex = 31;
            this.picHugoR.TabStop = false;
            // 
            // btnVolverRU
            // 
            this.btnVolverRU.BackColor = System.Drawing.Color.Indigo;
            this.btnVolverRU.ForeColor = System.Drawing.Color.White;
            this.btnVolverRU.Location = new System.Drawing.Point(599, 417);
            this.btnVolverRU.Name = "btnVolverRU";
            this.btnVolverRU.Size = new System.Drawing.Size(219, 88);
            this.btnVolverRU.TabIndex = 33;
            this.btnVolverRU.Text = "Volver";
            this.btnVolverRU.UseVisualStyleBackColor = false;
            this.btnVolverRU.Click += new System.EventHandler(this.btnVolverRU_Click);
            this.btnVolverRU.MouseLeave += new System.EventHandler(this.btnVolverRU_MouseLeave);
            this.btnVolverRU.MouseHover += new System.EventHandler(this.btnVolverRU_MouseHover);
            // 
            // rtbUsuarioN
            // 
            this.rtbUsuarioN.Location = new System.Drawing.Point(264, 245);
            this.rtbUsuarioN.Name = "rtbUsuarioN";
            this.rtbUsuarioN.Size = new System.Drawing.Size(346, 48);
            this.rtbUsuarioN.TabIndex = 34;
            this.rtbUsuarioN.Text = "";
            // 
            // lblNombreC
            // 
            this.lblNombreC.Location = new System.Drawing.Point(47, 167);
            this.lblNombreC.Name = "lblNombreC";
            this.lblNombreC.Size = new System.Drawing.Size(213, 46);
            this.lblNombreC.TabIndex = 35;
            this.lblNombreC.Text = "Nombre completo:";
            // 
            // rtbNCRU
            // 
            this.rtbNCRU.Location = new System.Drawing.Point(265, 169);
            this.rtbNCRU.Name = "rtbNCRU";
            this.rtbNCRU.Size = new System.Drawing.Size(357, 43);
            this.rtbNCRU.TabIndex = 36;
            this.rtbNCRU.Text = "";
            // 
            // frmRegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(889, 562);
            this.Controls.Add(this.rtbNCRU);
            this.Controls.Add(this.lblNombreC);
            this.Controls.Add(this.rtbUsuarioN);
            this.Controls.Add(this.btnVolverRU);
            this.Controls.Add(this.btnRegistrarseNuevo);
            this.Controls.Add(this.lblCR);
            this.Controls.Add(this.rtbCr);
            this.Controls.Add(this.lblNUR);
            this.Controls.Add(this.lblHugoR);
            this.Controls.Add(this.picHugoR);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRegistrarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrarUsuario";
            ((System.ComponentModel.ISupportInitialize) (this.picHugoR)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picHugoR;
        private System.Windows.Forms.Label lblHugoR;
        private System.Windows.Forms.Label lblNUR;
        private System.Windows.Forms.RichTextBox rtbCr;
        private System.Windows.Forms.Label lblCR;
        private System.Windows.Forms.Button btnRegistrarseNuevo;
        private System.Windows.Forms.Button btnVolverRU;
        private System.Windows.Forms.RichTextBox rtbUsuarioN;
        private System.Windows.Forms.Label lblNombreC;
        private System.Windows.Forms.RichTextBox rtbNombrC;
        private System.Windows.Forms.RichTextBox rtbNCRU;
    }
}