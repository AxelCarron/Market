namespace Guia_N_5._2
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lstProductos = new System.Windows.Forms.ListBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkManzana = new System.Windows.Forms.CheckBox();
            this.chkDulcedeleche = new System.Windows.Forms.CheckBox();
            this.chkOreo = new System.Windows.Forms.CheckBox();
            this.chkShampoo = new System.Windows.Forms.CheckBox();
            this.chkHarina = new System.Windows.Forms.CheckBox();
            this.chkFideos = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCalcular.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(21, 79);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(240, 37);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Comprar";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lstProductos
            // 
            this.lstProductos.FormattingEnabled = true;
            this.lstProductos.Location = new System.Drawing.Point(21, 136);
            this.lstProductos.Name = "lstProductos";
            this.lstProductos.Size = new System.Drawing.Size(240, 95);
            this.lstProductos.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(21, 39);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(240, 20);
            this.txtCantidad.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad";
            // 
            // chkManzana
            // 
            this.chkManzana.AutoSize = true;
            this.chkManzana.Location = new System.Drawing.Point(318, 85);
            this.chkManzana.Name = "chkManzana";
            this.chkManzana.Size = new System.Drawing.Size(106, 17);
            this.chkManzana.TabIndex = 4;
            this.chkManzana.Text = "Manzana ($30,5)";
            this.chkManzana.UseVisualStyleBackColor = true;
            // 
            // chkDulcedeleche
            // 
            this.chkDulcedeleche.AutoSize = true;
            this.chkDulcedeleche.Location = new System.Drawing.Point(479, 85);
            this.chkDulcedeleche.Name = "chkDulcedeleche";
            this.chkDulcedeleche.Size = new System.Drawing.Size(134, 17);
            this.chkDulcedeleche.TabIndex = 7;
            this.chkDulcedeleche.Text = "Dulce de leche ($55,8)";
            this.chkDulcedeleche.UseVisualStyleBackColor = true;
            // 
            // chkOreo
            // 
            this.chkOreo.AutoSize = true;
            this.chkOreo.Location = new System.Drawing.Point(636, 85);
            this.chkOreo.Name = "chkOreo";
            this.chkOreo.Size = new System.Drawing.Size(85, 17);
            this.chkOreo.TabIndex = 9;
            this.chkOreo.Text = "Oreo ($35,6)";
            this.chkOreo.UseVisualStyleBackColor = true;
            // 
            // chkShampoo
            // 
            this.chkShampoo.AutoSize = true;
            this.chkShampoo.Location = new System.Drawing.Point(318, 214);
            this.chkShampoo.Name = "chkShampoo";
            this.chkShampoo.Size = new System.Drawing.Size(107, 17);
            this.chkShampoo.TabIndex = 4;
            this.chkShampoo.Text = "Shampoo ($40,6)";
            this.chkShampoo.UseVisualStyleBackColor = true;
            // 
            // chkHarina
            // 
            this.chkHarina.AutoSize = true;
            this.chkHarina.Location = new System.Drawing.Point(479, 214);
            this.chkHarina.Name = "chkHarina";
            this.chkHarina.Size = new System.Drawing.Size(93, 17);
            this.chkHarina.TabIndex = 7;
            this.chkHarina.Text = "Harina ($20,6)";
            this.chkHarina.UseVisualStyleBackColor = true;
            // 
            // chkFideos
            // 
            this.chkFideos.AutoSize = true;
            this.chkFideos.Location = new System.Drawing.Point(636, 214);
            this.chkFideos.Name = "chkFideos";
            this.chkFideos.Size = new System.Drawing.Size(93, 17);
            this.chkFideos.TabIndex = 9;
            this.chkFideos.Text = "Fideos ($25,2)";
            this.chkFideos.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Guia_N_5._2.Properties.Resources.pngwing_com_5_;
            this.pictureBox3.Location = new System.Drawing.Point(636, 14);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 65);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::Guia_N_5._2.Properties.Resources.pngwing_com_4_;
            this.pictureBox6.Location = new System.Drawing.Point(636, 136);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 65);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Guia_N_5._2.Properties.Resources.pngwing_com_1_;
            this.pictureBox2.Location = new System.Drawing.Point(479, 14);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 65);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Guia_N_5._2.Properties.Resources.pngwing_com_2_;
            this.pictureBox5.Location = new System.Drawing.Point(479, 136);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 65);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Guia_N_5._2.Properties.Resources.pngwing_com_3_;
            this.pictureBox1.Location = new System.Drawing.Point(318, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Guia_N_5._2.Properties.Resources.pngwing_com;
            this.pictureBox4.Location = new System.Drawing.Point(318, 136);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 65);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(21, 237);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(762, 259);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.chkFideos);
            this.Controls.Add(this.chkOreo);
            this.Controls.Add(this.chkHarina);
            this.Controls.Add(this.chkDulcedeleche);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.chkShampoo);
            this.Controls.Add(this.chkManzana);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lstProductos);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.ListBox lstProductos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkManzana;
        private System.Windows.Forms.CheckBox chkDulcedeleche;
        private System.Windows.Forms.CheckBox chkOreo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox chkShampoo;
        private System.Windows.Forms.CheckBox chkHarina;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.CheckBox chkFideos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblTotal;
    }
}

