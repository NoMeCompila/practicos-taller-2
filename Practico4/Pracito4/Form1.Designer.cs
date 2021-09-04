
namespace Pracito4
{
    partial class Form4
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
            this.lbl_desde = new System.Windows.Forms.Label();
            this.lbl_hasta = new System.Windows.Forms.Label();
            this.txt_desde = new System.Windows.Forms.TextBox();
            this.txt_hasta = new System.Windows.Forms.TextBox();
            this.lbl_lista = new System.Windows.Forms.Label();
            this.btn_funcion = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.btn_impares = new System.Windows.Forms.Button();
            this.btn_primos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbl_desde
            // 
            this.lbl_desde.AutoSize = true;
            this.lbl_desde.BackColor = System.Drawing.Color.Transparent;
            this.lbl_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_desde.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_desde.Location = new System.Drawing.Point(43, 85);
            this.lbl_desde.Name = "lbl_desde";
            this.lbl_desde.Size = new System.Drawing.Size(67, 22);
            this.lbl_desde.TabIndex = 0;
            this.lbl_desde.Text = "Desde:";
            this.lbl_desde.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_hasta
            // 
            this.lbl_hasta.AutoSize = true;
            this.lbl_hasta.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_hasta.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_hasta.Location = new System.Drawing.Point(43, 168);
            this.lbl_hasta.Name = "lbl_hasta";
            this.lbl_hasta.Size = new System.Drawing.Size(62, 22);
            this.lbl_hasta.TabIndex = 1;
            this.lbl_hasta.Text = "Hasta:";
            this.lbl_hasta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt_desde
            // 
            this.txt_desde.BackColor = System.Drawing.Color.SlateBlue;
            this.txt_desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_desde.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_desde.Location = new System.Drawing.Point(27, 122);
            this.txt_desde.Name = "txt_desde";
            this.txt_desde.Size = new System.Drawing.Size(100, 27);
            this.txt_desde.TabIndex = 2;
            this.txt_desde.TextChanged += new System.EventHandler(this.txt_desde_TextChanged);
            this.txt_desde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_desde_KeyPress);
            // 
            // txt_hasta
            // 
            this.txt_hasta.BackColor = System.Drawing.Color.SlateBlue;
            this.txt_hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.txt_hasta.ForeColor = System.Drawing.SystemColors.Window;
            this.txt_hasta.Location = new System.Drawing.Point(27, 204);
            this.txt_hasta.Name = "txt_hasta";
            this.txt_hasta.Size = new System.Drawing.Size(100, 27);
            this.txt_hasta.TabIndex = 3;
            this.txt_hasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_hasta_KeyPress);
            // 
            // lbl_lista
            // 
            this.lbl_lista.AutoSize = true;
            this.lbl_lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbl_lista.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbl_lista.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_lista.Location = new System.Drawing.Point(275, 9);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(150, 22);
            this.lbl_lista.TabIndex = 4;
            this.lbl_lista.Text = "Lista de Números";
            this.lbl_lista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_funcion
            // 
            this.btn_funcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_funcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btn_funcion.ForeColor = System.Drawing.Color.Yellow;
            this.btn_funcion.Location = new System.Drawing.Point(546, 80);
            this.btn_funcion.Name = "btn_funcion";
            this.btn_funcion.Size = new System.Drawing.Size(102, 33);
            this.btn_funcion.TabIndex = 6;
            this.btn_funcion.Text = "Listar";
            this.btn_funcion.UseVisualStyleBackColor = false;
            this.btn_funcion.Click += new System.EventHandler(this.btn_funcion_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.Yellow;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_limpiar.Location = new System.Drawing.Point(294, 260);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(102, 34);
            this.btn_limpiar.TabIndex = 7;
            this.btn_limpiar.Text = "Limpiar lista";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // btn_impares
            // 
            this.btn_impares.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_impares.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_impares.ForeColor = System.Drawing.Color.Yellow;
            this.btn_impares.Location = new System.Drawing.Point(546, 168);
            this.btn_impares.Name = "btn_impares";
            this.btn_impares.Size = new System.Drawing.Size(102, 34);
            this.btn_impares.TabIndex = 8;
            this.btn_impares.Text = "Impares";
            this.btn_impares.UseVisualStyleBackColor = false;
            this.btn_impares.Click += new System.EventHandler(this.btn_impares_Click);
            // 
            // btn_primos
            // 
            this.btn_primos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_primos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_primos.ForeColor = System.Drawing.Color.Yellow;
            this.btn_primos.Location = new System.Drawing.Point(546, 215);
            this.btn_primos.Name = "btn_primos";
            this.btn_primos.Size = new System.Drawing.Size(102, 34);
            this.btn_primos.TabIndex = 9;
            this.btn_primos.Text = "Primos";
            this.btn_primos.UseVisualStyleBackColor = false;
            this.btn_primos.Click += new System.EventHandler(this.btn_primos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.Location = new System.Drawing.Point(546, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Pares";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Indigo;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.listBox1.ForeColor = System.Drawing.Color.Yellow;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(234, 76);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(225, 164);
            this.listBox1.TabIndex = 11;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pracito4.Properties.Resources.lluvia_nros;
            this.ClientSize = new System.Drawing.Size(707, 320);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_primos);
            this.Controls.Add(this.btn_impares);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_funcion);
            this.Controls.Add(this.lbl_lista);
            this.Controls.Add(this.txt_hasta);
            this.Controls.Add(this.txt_desde);
            this.Controls.Add(this.lbl_hasta);
            this.Controls.Add(this.lbl_desde);
            this.Name = "Form4";
            this.Text = "Formulario 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_desde;
        private System.Windows.Forms.Label lbl_hasta;
        private System.Windows.Forms.TextBox txt_desde;
        private System.Windows.Forms.TextBox txt_hasta;
        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.Button btn_funcion;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Button btn_impares;
        private System.Windows.Forms.Button btn_primos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
    }
}

