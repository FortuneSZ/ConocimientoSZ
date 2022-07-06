namespace GuiaHoteles
{
    partial class NuevoHotel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAnadir = new System.Windows.Forms.Button();
            this.NuevoNom = new System.Windows.Forms.TextBox();
            this.NuevoPrecio = new System.Windows.Forms.TextBox();
            this.NuevoProv = new System.Windows.Forms.ComboBox();
            this.NuevoEst = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 249);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio/Noche:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 134);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Provincia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 360);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estrellas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(271, 303);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "EUR";
            // 
            // btnAnadir
            // 
            this.btnAnadir.Location = new System.Drawing.Point(140, 479);
            this.btnAnadir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAnadir.Name = "btnAnadir";
            this.btnAnadir.Size = new System.Drawing.Size(88, 27);
            this.btnAnadir.TabIndex = 5;
            this.btnAnadir.Text = "Añadir";
            this.btnAnadir.UseVisualStyleBackColor = true;
            this.btnAnadir.Click += new System.EventHandler(this.btnAnadir_Click);
            // 
            // NuevoNom
            // 
            this.NuevoNom.Location = new System.Drawing.Point(42, 87);
            this.NuevoNom.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NuevoNom.Name = "NuevoNom";
            this.NuevoNom.Size = new System.Drawing.Size(221, 23);
            this.NuevoNom.TabIndex = 6;
            // 
            // NuevoPrecio
            // 
            this.NuevoPrecio.Location = new System.Drawing.Point(42, 301);
            this.NuevoPrecio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NuevoPrecio.Name = "NuevoPrecio";
            this.NuevoPrecio.Size = new System.Drawing.Size(221, 23);
            this.NuevoPrecio.TabIndex = 7;
            this.NuevoPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NuevoPrecio_KeyPress);
            // 
            // NuevoProv
            // 
            this.NuevoProv.FormattingEnabled = true;
            this.NuevoProv.Items.AddRange(new object[] {
            "Alicante",
            "Madrid",
            "Barcelona",
            "Valencia",
            "Granada",
            "Malaga"});
            this.NuevoProv.Location = new System.Drawing.Point(42, 188);
            this.NuevoProv.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NuevoProv.Name = "NuevoProv";
            this.NuevoProv.Size = new System.Drawing.Size(221, 23);
            this.NuevoProv.TabIndex = 8;
            // 
            // NuevoEst
            // 
            this.NuevoEst.DisplayMember = "1";
            this.NuevoEst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NuevoEst.FormattingEnabled = true;
            this.NuevoEst.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.NuevoEst.Location = new System.Drawing.Point(42, 407);
            this.NuevoEst.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.NuevoEst.Name = "NuevoEst";
            this.NuevoEst.Size = new System.Drawing.Size(221, 23);
            this.NuevoEst.TabIndex = 9;
            // 
            // NuevoHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(377, 519);
            this.Controls.Add(this.NuevoEst);
            this.Controls.Add(this.NuevoProv);
            this.Controls.Add(this.NuevoPrecio);
            this.Controls.Add(this.NuevoNom);
            this.Controls.Add(this.btnAnadir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "NuevoHotel";
            this.Text = "Nuevo Hotel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAnadir;
        private System.Windows.Forms.TextBox NuevoNom;
        private System.Windows.Forms.TextBox NuevoPrecio;
        private System.Windows.Forms.ComboBox NuevoProv;
        private System.Windows.Forms.ComboBox NuevoEst;
    }
}