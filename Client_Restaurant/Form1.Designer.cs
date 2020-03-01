namespace Client_Restaurant
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.PictureBox();
            this.save = new System.Windows.Forms.PictureBox();
            this.update = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtpersonae = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtventas = new System.Windows.Forms.TextBox();
            this.txttipocomida = new System.Windows.Forms.TextBox();
            this.dtgv = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.MaskedTextBox();
            this.txtfecham = new System.Windows.Forms.MaskedTextBox();
            this.txtfechac = new System.Windows.Forms.MaskedTextBox();
            this.txtrnc = new System.Windows.Forms.MaskedTextBox();
            this.tbguid = new System.Windows.Forms.TextBox();
            this.Clean = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.delete);
            this.panel1.Controls.Add(this.save);
            this.panel1.Controls.Add(this.update);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(150, 553);
            this.panel1.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(42, 490);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(67, 19);
            this.label17.TabIndex = 37;
            this.label17.Text = "DELETE";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(42, 336);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(68, 19);
            this.label16.TabIndex = 36;
            this.label16.Text = "UPDATE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(42, 177);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(67, 19);
            this.label15.TabIndex = 32;
            this.label15.Text = "CREATE";
            // 
            // delete
            // 
            this.delete.Image = global::Client_Restaurant.Properties.Resources._61848;
            this.delete.Location = new System.Drawing.Point(34, 408);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(82, 79);
            this.delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delete.TabIndex = 35;
            this.delete.TabStop = false;
            this.delete.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // save
            // 
            this.save.Image = global::Client_Restaurant.Properties.Resources.Download_Save_Png_Image_71902_For_Designing_Projects;
            this.save.Location = new System.Drawing.Point(42, 101);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(68, 73);
            this.save.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.save.TabIndex = 34;
            this.save.TabStop = false;
            this.save.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // update
            // 
            this.update.Image = global::Client_Restaurant.Properties.Resources.icons_update_512;
            this.update.Location = new System.Drawing.Point(34, 254);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(82, 79);
            this.update.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.update.TabIndex = 33;
            this.update.TabStop = false;
            this.update.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(27, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Actions";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(415, -11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 58);
            this.label1.TabIndex = 1;
            this.label1.Text = "RestaurantApp";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtnombre
            // 
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Location = new System.Drawing.Point(201, 141);
            this.txtnombre.Multiline = true;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(213, 26);
            this.txtnombre.TabIndex = 2;
            // 
            // txtpersonae
            // 
            this.txtpersonae.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtpersonae.Location = new System.Drawing.Point(203, 209);
            this.txtpersonae.Multiline = true;
            this.txtpersonae.Name = "txtpersonae";
            this.txtpersonae.Size = new System.Drawing.Size(213, 27);
            this.txtpersonae.TabIndex = 3;
            // 
            // txtcantidad
            // 
            this.txtcantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcantidad.Location = new System.Drawing.Point(457, 209);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(213, 27);
            this.txtcantidad.TabIndex = 4;
            // 
            // txtdireccion
            // 
            this.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdireccion.Location = new System.Drawing.Point(203, 334);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(467, 27);
            this.txtdireccion.TabIndex = 6;
            // 
            // txtid
            // 
            this.txtid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtid.Location = new System.Drawing.Point(203, 79);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(44, 26);
            this.txtid.TabIndex = 7;
            // 
            // txtventas
            // 
            this.txtventas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtventas.Location = new System.Drawing.Point(714, 268);
            this.txtventas.Multiline = true;
            this.txtventas.Name = "txtventas";
            this.txtventas.Size = new System.Drawing.Size(205, 23);
            this.txtventas.TabIndex = 12;
            // 
            // txttipocomida
            // 
            this.txttipocomida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttipocomida.Location = new System.Drawing.Point(457, 268);
            this.txttipocomida.Multiline = true;
            this.txttipocomida.Name = "txttipocomida";
            this.txttipocomida.Size = new System.Drawing.Size(213, 23);
            this.txttipocomida.TabIndex = 13;
            // 
            // dtgv
            // 
            this.dtgv.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv.Location = new System.Drawing.Point(203, 374);
            this.dtgv.Name = "dtgv";
            this.dtgv.Size = new System.Drawing.Size(724, 122);
            this.dtgv.TabIndex = 14;
            this.dtgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(199, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(197, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Persona Encargada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(200, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Fecha de Modificacion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(200, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Dirección";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(454, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Tipo de Comida";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(454, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 19);
            this.label9.TabIndex = 21;
            this.label9.Text = "Cantidad de Empleados";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(454, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "RNC";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(708, 119);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "Telefono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(711, 187);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 19);
            this.label12.TabIndex = 24;
            this.label12.Text = "Fecha de Creacion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(707, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(212, 19);
            this.label13.TabIndex = 25;
            this.label13.Text = "Ventas Mensuales Promedio";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(709, 313);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 19);
            this.label14.TabIndex = 26;
            this.label14.Text = "GuidReg";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(712, 147);
            this.txttelefono.Mask = "(999) 000-0000";
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(154, 20);
            this.txttelefono.TabIndex = 27;
            // 
            // txtfecham
            // 
            this.txtfecham.Location = new System.Drawing.Point(204, 271);
            this.txtfecham.Mask = "0000-00-00";
            this.txtfecham.Name = "txtfecham";
            this.txtfecham.Size = new System.Drawing.Size(100, 20);
            this.txtfecham.TabIndex = 28;
            // 
            // txtfechac
            // 
            this.txtfechac.Location = new System.Drawing.Point(715, 216);
            this.txtfechac.Mask = "0000-00-00";
            this.txtfechac.Name = "txtfechac";
            this.txtfechac.Size = new System.Drawing.Size(100, 20);
            this.txtfechac.TabIndex = 29;
            // 
            // txtrnc
            // 
            this.txtrnc.Location = new System.Drawing.Point(457, 147);
            this.txtrnc.Mask = "999- 000-0000";
            this.txtrnc.Name = "txtrnc";
            this.txtrnc.Size = new System.Drawing.Size(100, 20);
            this.txtrnc.TabIndex = 30;
            // 
            // tbguid
            // 
            this.tbguid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbguid.Location = new System.Drawing.Point(692, 335);
            this.tbguid.Multiline = true;
            this.tbguid.Name = "tbguid";
            this.tbguid.Size = new System.Drawing.Size(213, 26);
            this.tbguid.TabIndex = 32;
            // 
            // Clean
            // 
            this.Clean.Location = new System.Drawing.Point(204, 506);
            this.Clean.Name = "Clean";
            this.Clean.Size = new System.Drawing.Size(131, 34);
            this.Clean.TabIndex = 33;
            this.Clean.Text = "Clean";
            this.Clean.UseVisualStyleBackColor = true;
            this.Clean.Click += new System.EventHandler(this.Clean_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(961, 551);
            this.Controls.Add(this.Clean);
            this.Controls.Add(this.tbguid);
            this.Controls.Add(this.txtrnc);
            this.Controls.Add(this.txtfechac);
            this.Controls.Add(this.txtfecham);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgv);
            this.Controls.Add(this.txttipocomida);
            this.Controls.Add(this.txtventas);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtpersonae);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RestaurantApp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.save)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtpersonae;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtventas;
        private System.Windows.Forms.TextBox txttipocomida;
        private System.Windows.Forms.DataGridView dtgv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.MaskedTextBox txttelefono;
        private System.Windows.Forms.MaskedTextBox txtfecham;
        private System.Windows.Forms.MaskedTextBox txtfechac;
        private System.Windows.Forms.MaskedTextBox txtrnc;
        private System.Windows.Forms.PictureBox update;
        private System.Windows.Forms.PictureBox delete;
        private System.Windows.Forms.PictureBox save;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbguid;
        private System.Windows.Forms.Button Clean;
    }
}

