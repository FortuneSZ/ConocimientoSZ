namespace PiedraPapelTijera
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pie = new System.Windows.Forms.PictureBox();
            this.tij = new System.Windows.Forms.PictureBox();
            this.pap = new System.Windows.Forms.PictureBox();
            this.M = new System.Windows.Forms.Label();
            this.H = new System.Windows.Forms.Label();
            this.puntosM = new System.Windows.Forms.Label();
            this.puntosH = new System.Windows.Forms.Label();
            this.imgH = new System.Windows.Forms.PictureBox();
            this.imgM = new System.Windows.Forms.PictureBox();
            this.infor = new System.Windows.Forms.Label();
            this.init = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tij)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgM)).BeginInit();
            this.SuspendLayout();
            // 
            // pie
            // 
            this.pie.Image = ((System.Drawing.Image)(resources.GetObject("pie.Image")));
            this.pie.Location = new System.Drawing.Point(373, 352);
            this.pie.Name = "pie";
            this.pie.Size = new System.Drawing.Size(84, 86);
            this.pie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pie.TabIndex = 0;
            this.pie.TabStop = false;
            this.pie.Click += new System.EventHandler(this.pie_Click);
            // 
            // tij
            // 
            this.tij.Image = ((System.Drawing.Image)(resources.GetObject("tij.Image")));
            this.tij.Location = new System.Drawing.Point(274, 352);
            this.tij.Name = "tij";
            this.tij.Size = new System.Drawing.Size(84, 86);
            this.tij.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tij.TabIndex = 1;
            this.tij.TabStop = false;
            this.tij.Click += new System.EventHandler(this.tij_Click);
            // 
            // pap
            // 
            this.pap.Image = ((System.Drawing.Image)(resources.GetObject("pap.Image")));
            this.pap.Location = new System.Drawing.Point(475, 352);
            this.pap.Name = "pap";
            this.pap.Size = new System.Drawing.Size(84, 86);
            this.pap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pap.TabIndex = 2;
            this.pap.TabStop = false;
            this.pap.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // M
            // 
            this.M.AutoSize = true;
            this.M.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.M.Location = new System.Drawing.Point(618, 81);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(117, 38);
            this.M.TabIndex = 3;
            this.M.Text = "Máquina";
            this.M.Click += new System.EventHandler(this.label1_Click);
            // 
            // H
            // 
            this.H.AutoSize = true;
            this.H.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.H.Location = new System.Drawing.Point(99, 81);
            this.H.Name = "H";
            this.H.Size = new System.Drawing.Size(115, 38);
            this.H.TabIndex = 4;
            this.H.Text = "Humano";
            this.H.Click += new System.EventHandler(this.label2_Click);
            // 
            // puntosM
            // 
            this.puntosM.AutoSize = true;
            this.puntosM.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntosM.Location = new System.Drawing.Point(665, 142);
            this.puntosM.Name = "puntosM";
            this.puntosM.Size = new System.Drawing.Size(29, 31);
            this.puntosM.TabIndex = 5;
            this.puntosM.Text = "0";
            // 
            // puntosH
            // 
            this.puntosH.AutoSize = true;
            this.puntosH.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntosH.Location = new System.Drawing.Point(137, 142);
            this.puntosH.Name = "puntosH";
            this.puntosH.Size = new System.Drawing.Size(29, 31);
            this.puntosH.TabIndex = 6;
            this.puntosH.Text = "0";
            // 
            // imgH
            // 
            this.imgH.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imgH.Location = new System.Drawing.Point(105, 214);
            this.imgH.Name = "imgH";
            this.imgH.Size = new System.Drawing.Size(100, 83);
            this.imgH.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgH.TabIndex = 7;
            this.imgH.TabStop = false;
            // 
            // imgM
            // 
            this.imgM.BackColor = System.Drawing.Color.WhiteSmoke;
            this.imgM.Location = new System.Drawing.Point(621, 214);
            this.imgM.Name = "imgM";
            this.imgM.Size = new System.Drawing.Size(100, 83);
            this.imgM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgM.TabIndex = 8;
            this.imgM.TabStop = false;
            // 
            // infor
            // 
            this.infor.AutoSize = true;
            this.infor.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infor.Location = new System.Drawing.Point(353, 214);
            this.infor.Name = "infor";
            this.infor.Size = new System.Drawing.Size(156, 31);
            this.infor.TabIndex = 9;
            this.infor.Text = "Información";
            // 
            // init
            // 
            this.init.AutoSize = true;
            this.init.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.init.Location = new System.Drawing.Point(343, 266);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(177, 31);
            this.init.TabIndex = 10;
            this.init.Text = "Iniciar partida";
            this.init.Click += new System.EventHandler(this.initPartida);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.init);
            this.Controls.Add(this.infor);
            this.Controls.Add(this.imgM);
            this.Controls.Add(this.imgH);
            this.Controls.Add(this.puntosH);
            this.Controls.Add(this.puntosM);
            this.Controls.Add(this.H);
            this.Controls.Add(this.M);
            this.Controls.Add(this.pap);
            this.Controls.Add(this.tij);
            this.Controls.Add(this.pie);
            this.Name = "Form1";
            this.Text = "Piedra papel tijera";
            ((System.ComponentModel.ISupportInitialize)(this.pie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tij)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pap;
        private System.Windows.Forms.PictureBox tij;
        private System.Windows.Forms.PictureBox pie;
        private System.Windows.Forms.Label M;
        private System.Windows.Forms.Label H;
        private System.Windows.Forms.Label puntosM;
        private System.Windows.Forms.Label puntosH;
        private System.Windows.Forms.PictureBox imgH;
        private System.Windows.Forms.PictureBox imgM;
        private System.Windows.Forms.Label infor;
        private System.Windows.Forms.Label init;
    }
}

