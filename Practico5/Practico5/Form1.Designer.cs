
namespace Practico5
{
    partial class btn_guardar
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle31 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_foto = new System.Windows.Forms.Button();
            this.rbtn_mujer = new System.Windows.Forms.RadioButton();
            this.rbtn_hombre = new System.Windows.Forms.RadioButton();
            this.btn_save = new System.Windows.Forms.Button();
            this.txt_ruta = new System.Windows.Forms.TextBox();
            this.dtp_nacimiento = new System.Windows.Forms.DateTimePicker();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_saldo = new System.Windows.Forms.Label();
            this.lbl_sexo = new System.Windows.Forms.Label();
            this.lbl_fecha_nac = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.pbx_pp = new System.Windows.Forms.PictureBox();
            this.dtg_cliente = new System.Windows.Forms.DataGridView();
            this.openFileDialogArray1 = new Microsoft.VisualBasic.Compatibility.VB6.OpenFileDialogArray(this.components);
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileDialogArray1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_foto);
            this.panel1.Controls.Add(this.rbtn_mujer);
            this.panel1.Controls.Add(this.rbtn_hombre);
            this.panel1.Controls.Add(this.btn_save);
            this.panel1.Controls.Add(this.txt_ruta);
            this.panel1.Controls.Add(this.dtp_nacimiento);
            this.panel1.Controls.Add(this.txt_saldo);
            this.panel1.Controls.Add(this.txt_apellido);
            this.panel1.Controls.Add(this.txt_nombre);
            this.panel1.Controls.Add(this.lbl_saldo);
            this.panel1.Controls.Add(this.lbl_sexo);
            this.panel1.Controls.Add(this.lbl_fecha_nac);
            this.panel1.Controls.Add(this.lbl_surname);
            this.panel1.Controls.Add(this.lbl_nombre);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 348);
            this.panel1.TabIndex = 0;
            // 
            // btn_foto
            // 
            this.btn_foto.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.btn_foto.Location = new System.Drawing.Point(27, 261);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(75, 28);
            this.btn_foto.TabIndex = 16;
            this.btn_foto.Text = "Foto";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // rbtn_mujer
            // 
            this.rbtn_mujer.AutoSize = true;
            this.rbtn_mujer.Font = new System.Drawing.Font("Sitka Banner", 11F);
            this.rbtn_mujer.Location = new System.Drawing.Point(323, 152);
            this.rbtn_mujer.Name = "rbtn_mujer";
            this.rbtn_mujer.Size = new System.Drawing.Size(62, 25);
            this.rbtn_mujer.TabIndex = 15;
            this.rbtn_mujer.TabStop = true;
            this.rbtn_mujer.Text = "Mujer";
            this.rbtn_mujer.UseVisualStyleBackColor = true;
            // 
            // rbtn_hombre
            // 
            this.rbtn_hombre.AutoSize = true;
            this.rbtn_hombre.Font = new System.Drawing.Font("Sitka Banner", 11F);
            this.rbtn_hombre.Location = new System.Drawing.Point(199, 152);
            this.rbtn_hombre.Name = "rbtn_hombre";
            this.rbtn_hombre.Size = new System.Drawing.Size(62, 25);
            this.rbtn_hombre.TabIndex = 14;
            this.rbtn_hombre.TabStop = true;
            this.rbtn_hombre.Text = "Varón";
            this.rbtn_hombre.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.btn_save.Location = new System.Drawing.Point(171, 305);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 30);
            this.btn_save.TabIndex = 13;
            this.btn_save.Text = "Guardar";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txt_ruta
            // 
            this.txt_ruta.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.txt_ruta.Location = new System.Drawing.Point(199, 261);
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.Size = new System.Drawing.Size(175, 28);
            this.txt_ruta.TabIndex = 12;
            // 
            // dtp_nacimiento
            // 
            this.dtp_nacimiento.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.dtp_nacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nacimiento.Location = new System.Drawing.Point(229, 107);
            this.dtp_nacimiento.Name = "dtp_nacimiento";
            this.dtp_nacimiento.Size = new System.Drawing.Size(108, 28);
            this.dtp_nacimiento.TabIndex = 10;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.txt_saldo.Location = new System.Drawing.Point(199, 202);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(175, 28);
            this.txt_saldo.TabIndex = 8;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.txt_apellido.Location = new System.Drawing.Point(199, 60);
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(175, 28);
            this.txt_apellido.TabIndex = 6;
            this.txt_apellido.TextChanged += new System.EventHandler(this.txt_apellido_TextChanged);
            // 
            // txt_nombre
            // 
            this.txt_nombre.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.txt_nombre.Location = new System.Drawing.Point(199, 17);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(175, 28);
            this.txt_nombre.TabIndex = 5;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // lbl_saldo
            // 
            this.lbl_saldo.AutoSize = true;
            this.lbl_saldo.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lbl_saldo.Location = new System.Drawing.Point(35, 207);
            this.lbl_saldo.Name = "lbl_saldo";
            this.lbl_saldo.Size = new System.Drawing.Size(44, 23);
            this.lbl_saldo.TabIndex = 4;
            this.lbl_saldo.Text = "Saldo";
            this.lbl_saldo.Click += new System.EventHandler(this.lbl_saldo_Click);
            // 
            // lbl_sexo
            // 
            this.lbl_sexo.AutoSize = true;
            this.lbl_sexo.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lbl_sexo.Location = new System.Drawing.Point(35, 154);
            this.lbl_sexo.Name = "lbl_sexo";
            this.lbl_sexo.Size = new System.Drawing.Size(39, 23);
            this.lbl_sexo.TabIndex = 3;
            this.lbl_sexo.Text = "Sexo";
            this.lbl_sexo.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_fecha_nac
            // 
            this.lbl_fecha_nac.AutoSize = true;
            this.lbl_fecha_nac.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lbl_fecha_nac.Location = new System.Drawing.Point(35, 112);
            this.lbl_fecha_nac.Name = "lbl_fecha_nac";
            this.lbl_fecha_nac.Size = new System.Drawing.Size(124, 23);
            this.lbl_fecha_nac.TabIndex = 2;
            this.lbl_fecha_nac.Text = "Fecha Nacimiento:";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lbl_surname.Location = new System.Drawing.Point(35, 65);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(61, 23);
            this.lbl_surname.TabIndex = 1;
            this.lbl_surname.Text = "Apellido";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Font = new System.Drawing.Font("Sitka Banner", 12F);
            this.lbl_nombre.Location = new System.Drawing.Point(35, 20);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(64, 23);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre:";
            // 
            // pbx_pp
            // 
            this.pbx_pp.Image = global::Practico5.Properties.Resources.perfil;
            this.pbx_pp.Location = new System.Drawing.Point(526, 62);
            this.pbx_pp.Name = "pbx_pp";
            this.pbx_pp.Size = new System.Drawing.Size(249, 206);
            this.pbx_pp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_pp.TabIndex = 1;
            this.pbx_pp.TabStop = false;
            // 
            // dtg_cliente
            // 
            this.dtg_cliente.AllowUserToDeleteRows = false;
            this.dtg_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_cliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Fecha,
            this.sexo,
            this.Saldo,
            this.Ruta,
            this.Foto,
            this.Eliminar});
            this.dtg_cliente.Location = new System.Drawing.Point(12, 366);
            this.dtg_cliente.Name = "dtg_cliente";
            this.dtg_cliente.ReadOnly = true;
            this.dtg_cliente.RowTemplate.Height = 100;
            this.dtg_cliente.Size = new System.Drawing.Size(848, 134);
            this.dtg_cliente.TabIndex = 2;
            this.dtg_cliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_cliente_CellClick);
            this.dtg_cliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_cliente_CellContentClick);
            this.dtg_cliente.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtg_cliente_CellFormatting);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha Nac.";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "sexo";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // Saldo
            // 
            this.Saldo.HeaderText = "Saldo";
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            // 
            // Ruta
            // 
            this.Ruta.HeaderText = "Ruta";
            this.Ruta.Name = "Ruta";
            this.Ruta.ReadOnly = true;
            // 
            // Foto
            // 
            dataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Foto.DefaultCellStyle = dataGridViewCellStyle31;
            this.Foto.HeaderText = "Foto";
            this.Foto.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Foto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.Foto.Width = 101;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.ToolTipText = "Eliminar";
            this.Eliminar.UseColumnTextForButtonValue = true;
            // 
            // btn_guardar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(872, 512);
            this.Controls.Add(this.dtg_cliente);
            this.Controls.Add(this.pbx_pp);
            this.Controls.Add(this.panel1);
            this.Name = "btn_guardar";
            this.Text = "Apellido";
            this.Load += new System.EventHandler(this.btn_guardar_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.openFileDialogArray1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_saldo;
        private System.Windows.Forms.Label lbl_sexo;
        private System.Windows.Forms.Label lbl_fecha_nac;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.RadioButton rbtn_mujer;
        private System.Windows.Forms.RadioButton rbtn_hombre;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txt_ruta;
        private System.Windows.Forms.DateTimePicker dtp_nacimiento;
        private System.Windows.Forms.TextBox txt_saldo;
        private System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.PictureBox pbx_pp;
        private System.Windows.Forms.DataGridView dtg_cliente;
        private System.Windows.Forms.Button btn_foto;
        private Microsoft.VisualBasic.Compatibility.VB6.OpenFileDialogArray openFileDialogArray1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ruta;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}

