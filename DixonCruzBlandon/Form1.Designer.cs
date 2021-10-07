
namespace DixonCruzBlandon
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
            this.dgvclientes = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbcliente = new System.Windows.Forms.GroupBox();
            this.txtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtidentificacion = new System.Windows.Forms.TextBox();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbselecciondirecta = new System.Windows.Forms.RadioButton();
            this.rdbquicksort = new System.Windows.Forms.RadioButton();
            this.rdbshell = new System.Windows.Forms.RadioButton();
            this.rdbburbuja = new System.Windows.Forms.RadioButton();
            this.btnordenar = new System.Windows.Forms.Button();
            this.rdbHeapshort = new System.Windows.Forms.RadioButton();
            this.rdbbaraja = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbintercalacion = new System.Windows.Forms.RadioButton();
            this.rdbequilibrada = new System.Windows.Forms.RadioButton();
            this.button4 = new System.Windows.Forms.Button();
            this.rdbMezcla = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btntransformacion = new System.Windows.Forms.Button();
            this.btnsecuencial = new System.Windows.Forms.Button();
            this.txtbusqueda = new System.Windows.Forms.TextBox();
            this.btnbusqueda = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gbcliente.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvclientes
            // 
            this.dgvclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvclientes.Location = new System.Drawing.Point(0, 248);
            this.dgvclientes.Name = "dgvclientes";
            this.dgvclientes.Size = new System.Drawing.Size(558, 271);
            this.dgvclientes.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nombres Cliente";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Identificacion";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Dias de Estancia";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.HeaderText = "Fecha Reservacion";
            this.Column4.Name = "Column4";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.gbcliente);
            this.groupBox1.Controls.Add(this.btncontinuar);
            this.groupBox1.Controls.Add(this.txtcant);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 215);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DixonCruzBlandon.Properties.Resources.motelimar;
            this.pictureBox1.Location = new System.Drawing.Point(336, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // gbcliente
            // 
            this.gbcliente.Controls.Add(this.txtfecha);
            this.gbcliente.Controls.Add(this.txtnombres);
            this.gbcliente.Controls.Add(this.label5);
            this.gbcliente.Controls.Add(this.label2);
            this.gbcliente.Controls.Add(this.label3);
            this.gbcliente.Controls.Add(this.btnguardar);
            this.gbcliente.Controls.Add(this.txtidentificacion);
            this.gbcliente.Controls.Add(this.txtdias);
            this.gbcliente.Controls.Add(this.label4);
            this.gbcliente.Enabled = false;
            this.gbcliente.Location = new System.Drawing.Point(18, 52);
            this.gbcliente.Name = "gbcliente";
            this.gbcliente.Size = new System.Drawing.Size(467, 162);
            this.gbcliente.TabIndex = 23;
            this.gbcliente.TabStop = false;
            // 
            // txtfecha
            // 
            this.txtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtfecha.Location = new System.Drawing.Point(120, 109);
            this.txtfecha.Name = "txtfecha";
            this.txtfecha.Size = new System.Drawing.Size(200, 20);
            this.txtfecha.TabIndex = 30;
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(121, 12);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(169, 20);
            this.txtnombres.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Fecha Reservacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nombres del Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Identificacion:";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(365, 118);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 25);
            this.btnguardar.TabIndex = 28;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtidentificacion
            // 
            this.txtidentificacion.Location = new System.Drawing.Point(121, 41);
            this.txtidentificacion.Name = "txtidentificacion";
            this.txtidentificacion.Size = new System.Drawing.Size(120, 20);
            this.txtidentificacion.TabIndex = 25;
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(121, 74);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(100, 20);
            this.txtdias.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Dias de estancia:";
            // 
            // btncontinuar
            // 
            this.btncontinuar.Location = new System.Drawing.Point(229, 19);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(75, 25);
            this.btncontinuar.TabIndex = 12;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = true;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // txtcant
            // 
            this.txtcant.Location = new System.Drawing.Point(138, 19);
            this.txtcant.Multiline = true;
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(74, 25);
            this.txtcant.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cantidad de Clientes:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbselecciondirecta);
            this.groupBox2.Controls.Add(this.rdbquicksort);
            this.groupBox2.Controls.Add(this.rdbshell);
            this.groupBox2.Controls.Add(this.rdbburbuja);
            this.groupBox2.Controls.Add(this.btnordenar);
            this.groupBox2.Controls.Add(this.rdbHeapshort);
            this.groupBox2.Controls.Add(this.rdbbaraja);
            this.groupBox2.Location = new System.Drawing.Point(569, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 195);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = " ";
            // 
            // rdbselecciondirecta
            // 
            this.rdbselecciondirecta.AutoSize = true;
            this.rdbselecciondirecta.Location = new System.Drawing.Point(27, 165);
            this.rdbselecciondirecta.Name = "rdbselecciondirecta";
            this.rdbselecciondirecta.Size = new System.Drawing.Size(109, 17);
            this.rdbselecciondirecta.TabIndex = 17;
            this.rdbselecciondirecta.TabStop = true;
            this.rdbselecciondirecta.Text = "Seleccion Directa";
            this.rdbselecciondirecta.UseVisualStyleBackColor = true;
            // 
            // rdbquicksort
            // 
            this.rdbquicksort.AutoSize = true;
            this.rdbquicksort.Location = new System.Drawing.Point(27, 140);
            this.rdbquicksort.Name = "rdbquicksort";
            this.rdbquicksort.Size = new System.Drawing.Size(72, 17);
            this.rdbquicksort.TabIndex = 16;
            this.rdbquicksort.TabStop = true;
            this.rdbquicksort.Text = "QuickSort";
            this.rdbquicksort.UseVisualStyleBackColor = true;
            // 
            // rdbshell
            // 
            this.rdbshell.AutoSize = true;
            this.rdbshell.Location = new System.Drawing.Point(27, 117);
            this.rdbshell.Name = "rdbshell";
            this.rdbshell.Size = new System.Drawing.Size(48, 17);
            this.rdbshell.TabIndex = 15;
            this.rdbshell.TabStop = true;
            this.rdbshell.Text = "Shell";
            this.rdbshell.UseVisualStyleBackColor = true;
            // 
            // rdbburbuja
            // 
            this.rdbburbuja.AutoSize = true;
            this.rdbburbuja.Location = new System.Drawing.Point(27, 94);
            this.rdbburbuja.Name = "rdbburbuja";
            this.rdbburbuja.Size = new System.Drawing.Size(160, 17);
            this.rdbburbuja.TabIndex = 14;
            this.rdbburbuja.TabStop = true;
            this.rdbburbuja.Text = "Intercambio directo (Burbuja)";
            this.rdbburbuja.UseVisualStyleBackColor = true;
            // 
            // btnordenar
            // 
            this.btnordenar.Location = new System.Drawing.Point(150, 164);
            this.btnordenar.Name = "btnordenar";
            this.btnordenar.Size = new System.Drawing.Size(75, 25);
            this.btnordenar.TabIndex = 13;
            this.btnordenar.Text = "Ordenar";
            this.btnordenar.UseVisualStyleBackColor = true;
            this.btnordenar.Click += new System.EventHandler(this.btnordenar_Click);
            // 
            // rdbHeapshort
            // 
            this.rdbHeapshort.AutoSize = true;
            this.rdbHeapshort.Location = new System.Drawing.Point(27, 68);
            this.rdbHeapshort.Name = "rdbHeapshort";
            this.rdbHeapshort.Size = new System.Drawing.Size(76, 17);
            this.rdbHeapshort.TabIndex = 1;
            this.rdbHeapshort.TabStop = true;
            this.rdbHeapshort.Text = "HeapShort";
            this.rdbHeapshort.UseVisualStyleBackColor = true;
            // 
            // rdbbaraja
            // 
            this.rdbbaraja.AutoSize = true;
            this.rdbbaraja.Location = new System.Drawing.Point(27, 41);
            this.rdbbaraja.Name = "rdbbaraja";
            this.rdbbaraja.Size = new System.Drawing.Size(144, 17);
            this.rdbbaraja.TabIndex = 0;
            this.rdbbaraja.TabStop = true;
            this.rdbbaraja.Text = "Insercion Directa (Baraja)";
            this.rdbbaraja.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbintercalacion);
            this.groupBox3.Controls.Add(this.rdbequilibrada);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.rdbMezcla);
            this.groupBox3.Location = new System.Drawing.Point(569, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(231, 136);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Metodos de Ordenamiento Externo";
            // 
            // rdbintercalacion
            // 
            this.rdbintercalacion.AutoSize = true;
            this.rdbintercalacion.Location = new System.Drawing.Point(27, 87);
            this.rdbintercalacion.Name = "rdbintercalacion";
            this.rdbintercalacion.Size = new System.Drawing.Size(144, 17);
            this.rdbintercalacion.TabIndex = 15;
            this.rdbintercalacion.TabStop = true;
            this.rdbintercalacion.Text = "Intercalacion de archivos";
            this.rdbintercalacion.UseVisualStyleBackColor = true;
            // 
            // rdbequilibrada
            // 
            this.rdbequilibrada.AutoSize = true;
            this.rdbequilibrada.Location = new System.Drawing.Point(27, 64);
            this.rdbequilibrada.Name = "rdbequilibrada";
            this.rdbequilibrada.Size = new System.Drawing.Size(114, 17);
            this.rdbequilibrada.TabIndex = 14;
            this.rdbequilibrada.TabStop = true;
            this.rdbequilibrada.Text = "Mezcla Equilibrada";
            this.rdbequilibrada.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(150, 111);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 25);
            this.button4.TabIndex = 13;
            this.button4.Text = "Abrir";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // rdbMezcla
            // 
            this.rdbMezcla.AutoSize = true;
            this.rdbMezcla.Location = new System.Drawing.Point(27, 41);
            this.rdbMezcla.Name = "rdbMezcla";
            this.rdbMezcla.Size = new System.Drawing.Size(96, 17);
            this.rdbMezcla.TabIndex = 0;
            this.rdbMezcla.TabStop = true;
            this.rdbMezcla.Text = "Mezcla Directa";
            this.rdbMezcla.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btntransformacion);
            this.groupBox4.Controls.Add(this.btnsecuencial);
            this.groupBox4.Controls.Add(this.txtbusqueda);
            this.groupBox4.Controls.Add(this.btnbusqueda);
            this.groupBox4.Location = new System.Drawing.Point(572, 360);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(231, 149);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda Interna";
            // 
            // btntransformacion
            // 
            this.btntransformacion.Location = new System.Drawing.Point(48, 112);
            this.btntransformacion.Name = "btntransformacion";
            this.btntransformacion.Size = new System.Drawing.Size(134, 37);
            this.btntransformacion.TabIndex = 21;
            this.btntransformacion.Text = "Transformacion de clave";
            this.btntransformacion.UseVisualStyleBackColor = true;
            // 
            // btnsecuencial
            // 
            this.btnsecuencial.Location = new System.Drawing.Point(48, 78);
            this.btnsecuencial.Name = "btnsecuencial";
            this.btnsecuencial.Size = new System.Drawing.Size(134, 37);
            this.btnsecuencial.TabIndex = 20;
            this.btnsecuencial.Text = "Busqueda Secuencial";
            this.btnsecuencial.UseVisualStyleBackColor = true;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.Location = new System.Drawing.Point(6, 19);
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.Size = new System.Drawing.Size(219, 20);
            this.txtbusqueda.TabIndex = 19;
            // 
            // btnbusqueda
            // 
            this.btnbusqueda.Location = new System.Drawing.Point(48, 45);
            this.btnbusqueda.Name = "btnbusqueda";
            this.btnbusqueda.Size = new System.Drawing.Size(134, 37);
            this.btnbusqueda.TabIndex = 13;
            this.btnbusqueda.Text = "Busqueda Binaria";
            this.btnbusqueda.UseVisualStyleBackColor = true;
            this.btnbusqueda.Click += new System.EventHandler(this.btnbusqueda_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Location = new System.Drawing.Point(572, 515);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(231, 99);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Acciones";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(50, 34);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(134, 37);
            this.button6.TabIndex = 13;
            this.button6.Text = "Salir";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(815, 626);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvclientes);
            this.Name = "Form1";
            this.Text = "..:::Clientes Motelimar:::..";
            ((System.ComponentModel.ISupportInitialize)(this.dgvclientes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gbcliente.ResumeLayout(false);
            this.gbcliente.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvclientes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnordenar;
        private System.Windows.Forms.RadioButton rdbHeapshort;
        private System.Windows.Forms.RadioButton rdbbaraja;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton rdbMezcla;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtbusqueda;
        private System.Windows.Forms.Button btnbusqueda;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox gbcliente;
        private System.Windows.Forms.DateTimePicker txtfecha;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtidentificacion;
        private System.Windows.Forms.TextBox txtdias;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbquicksort;
        private System.Windows.Forms.RadioButton rdbshell;
        private System.Windows.Forms.RadioButton rdbburbuja;
        private System.Windows.Forms.RadioButton rdbintercalacion;
        private System.Windows.Forms.RadioButton rdbequilibrada;
        private System.Windows.Forms.Button btntransformacion;
        private System.Windows.Forms.Button btnsecuencial;
        private System.Windows.Forms.RadioButton rdbselecciondirecta;
    }
}

