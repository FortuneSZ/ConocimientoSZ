namespace GuiaHoteles
{
    partial class FormPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hotelesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listHoteles = new System.Windows.Forms.ListBox();
            this.lblGuia = new System.Windows.Forms.Label();
            this.cmbProv = new System.Windows.Forms.ComboBox();
            this.lvlProvincia = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblEur = new System.Windows.Forms.Label();
            this.lblEstrellas = new System.Windows.Forms.Label();
            this.cmbEstrellas = new System.Windows.Forms.ComboBox();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnAplicar = new System.Windows.Forms.Button();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hotelesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hotelesToolStripMenuItem
            // 
            this.hotelesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.toolStripSeparator2,
            this.salirToolStripMenuItem});
            this.hotelesToolStripMenuItem.Name = "hotelesToolStripMenuItem";
            this.hotelesToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.hotelesToolStripMenuItem.Text = "Hoteles";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // listHoteles
            // 
            this.listHoteles.FormattingEnabled = true;
            this.listHoteles.ItemHeight = 15;
            this.listHoteles.Location = new System.Drawing.Point(14, 108);
            this.listHoteles.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listHoteles.Name = "listHoteles";
            this.listHoteles.Size = new System.Drawing.Size(566, 169);
            this.listHoteles.TabIndex = 1;
            // 
            // lblGuia
            // 
            this.lblGuia.AutoSize = true;
            this.lblGuia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblGuia.ForeColor = System.Drawing.Color.White;
            this.lblGuia.Location = new System.Drawing.Point(14, 47);
            this.lblGuia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuia.Name = "lblGuia";
            this.lblGuia.Size = new System.Drawing.Size(164, 29);
            this.lblGuia.TabIndex = 2;
            this.lblGuia.Text = "Guía Hoteles";
            // 
            // cmbProv
            // 
            this.cmbProv.FormattingEnabled = true;
            this.cmbProv.Items.AddRange(new object[] {
            "Alicante",
            "Madrid",
            "Barcelona",
            "Valencia",
            "Granada",
            "Malaga"});
            this.cmbProv.Location = new System.Drawing.Point(224, 336);
            this.cmbProv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbProv.Name = "cmbProv";
            this.cmbProv.Size = new System.Drawing.Size(237, 23);
            this.cmbProv.TabIndex = 3;
            // 
            // lvlProvincia
            // 
            this.lvlProvincia.AutoSize = true;
            this.lvlProvincia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lvlProvincia.ForeColor = System.Drawing.Color.White;
            this.lvlProvincia.Location = new System.Drawing.Point(97, 337);
            this.lvlProvincia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lvlProvincia.Name = "lvlProvincia";
            this.lvlProvincia.Size = new System.Drawing.Size(66, 16);
            this.lvlProvincia.TabIndex = 4;
            this.lvlProvincia.Text = "Provincia:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPrecio.ForeColor = System.Drawing.Color.White;
            this.lblPrecio.Location = new System.Drawing.Point(97, 405);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(93, 16);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio/Noche:";
            // 
            // lblEur
            // 
            this.lblEur.AutoSize = true;
            this.lblEur.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEur.ForeColor = System.Drawing.Color.White;
            this.lblEur.Location = new System.Drawing.Point(420, 405);
            this.lblEur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEur.Name = "lblEur";
            this.lblEur.Size = new System.Drawing.Size(36, 16);
            this.lblEur.TabIndex = 6;
            this.lblEur.Text = "EUR";
            // 
            // lblEstrellas
            // 
            this.lblEstrellas.AutoSize = true;
            this.lblEstrellas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEstrellas.ForeColor = System.Drawing.Color.White;
            this.lblEstrellas.Location = new System.Drawing.Point(97, 472);
            this.lblEstrellas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstrellas.Name = "lblEstrellas";
            this.lblEstrellas.Size = new System.Drawing.Size(62, 16);
            this.lblEstrellas.TabIndex = 7;
            this.lblEstrellas.Text = "Estrellas:";
            // 
            // cmbEstrellas
            // 
            this.cmbEstrellas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstrellas.FormattingEnabled = true;
            this.cmbEstrellas.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbEstrellas.Location = new System.Drawing.Point(225, 466);
            this.cmbEstrellas.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmbEstrellas.Name = "cmbEstrellas";
            this.cmbEstrellas.Size = new System.Drawing.Size(237, 23);
            this.cmbEstrellas.TabIndex = 8;
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(225, 400);
            this.textPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(187, 23);
            this.textPrecio.TabIndex = 9;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(326, 548);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(88, 27);
            this.btnBorrar.TabIndex = 10;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnAplicar
            // 
            this.btnAplicar.Location = new System.Drawing.Point(192, 548);
            this.btnAplicar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAplicar.Name = "btnAplicar";
            this.btnAplicar.Size = new System.Drawing.Size(88, 27);
            this.btnAplicar.TabIndex = 11;
            this.btnAplicar.Text = "Aplicar";
            this.btnAplicar.UseVisualStyleBackColor = true;
            this.btnAplicar.Click += new System.EventHandler(this.btnAplicar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(600, 601);
            this.Controls.Add(this.btnAplicar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.cmbEstrellas);
            this.Controls.Add(this.lblEstrellas);
            this.Controls.Add(this.lblEur);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lvlProvincia);
            this.Controls.Add(this.cmbProv);
            this.Controls.Add(this.lblGuia);
            this.Controls.Add(this.listHoteles);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormPrincipal";
            this.Text = "Guía Hoteles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPrincipal_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hotelesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ListBox listHoteles;
        private System.Windows.Forms.Label lblGuia;
        private System.Windows.Forms.ComboBox cmbProv;
        private System.Windows.Forms.Label lvlProvincia;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblEur;
        private System.Windows.Forms.Label lblEstrellas;
        private System.Windows.Forms.ComboBox cmbEstrellas;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnAplicar;
        private ToolStripSeparator toolStripSeparator2;
    }
}

