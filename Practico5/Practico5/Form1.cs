using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico5
{
    public partial class btn_guardar : Form
    {
        public btn_guardar()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_guardar_Load(object sender, EventArgs e)
        {

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {
            txt_nombre.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_nombre.Text);
            txt_nombre.SelectionStart = txt_nombre.Text.Length;
        }

        private void lbl_saldo_Click(object sender, EventArgs e)
        {

        }

        //Código que sirve para seleccionar una imen de una carpeta y capturar su ruta en un textbox
        private void btn_foto_Click(object sender, EventArgs e)
        {
            OpenFileDialog getImage = new OpenFileDialog();
            getImage.InitialDirectory = "C:\\Users\\Fer\\source\\repos\\Practico5\\Practico5\\bin\\Debug\\Fotos";
            getImage.Filter = "Archivos de imagen: (*.jpg)(*.jpeg)|*.jpg;*.jpeg|PNG (*.png)|*.png";

            if (getImage.ShowDialog() == DialogResult.OK)
            {
                pbx_pp.ImageLocation = getImage.FileName;
                txt_ruta.Text = getImage.FileName;
            }
            else
            {
                MessageBox.Show("No se selecciono ninguna imagen", "Sin seleccion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_apellido_TextChanged(object sender, EventArgs e)
        {
            txt_apellido.Text = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(txt_apellido.Text);
            txt_apellido.SelectionStart = txt_apellido.Text.Length;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int writeRow = dtg_cliente.Rows.Count - 1;
            dtg_cliente.Rows.Add(1);

            dtg_cliente.Rows[writeRow].Cells[0].Value = txt_nombre.Text;
            dtg_cliente.Rows[writeRow].Cells[1].Value = txt_apellido.Text;
            dtg_cliente.Rows[writeRow].Cells[2].Value = dtp_nacimiento.Text;
            string sex;
            if(rbtn_hombre.Checked == true) { sex = "Varon"; } else { sex = "Mujer"; }
            dtg_cliente.Rows[writeRow].Cells[3].Value = sex;
            dtg_cliente.Rows[writeRow].Cells[4].Value = txt_saldo.Text;
            dtg_cliente.Rows[writeRow].Cells[5].Value = txt_ruta.Text;
            dtg_cliente.Rows[writeRow].Cells[6].Value = pbx_pp.Image;
        }

        private void dtg_cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Eliminar.Text = "Eliminar";
            int posicion=dtg_cliente.CurrentRow.Index;
            if (dtg_cliente.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                if (MessageBox.Show("¿Seguro que quiere eliminar?","Message",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    dtg_cliente.Rows.RemoveAt(posicion);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dtg_cliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtg_cliente_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dtg_cliente.Columns[e.ColumnIndex].Name=="Saldo")
            {
                if (Convert.ToInt32(e.Value) <= 50)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.Yellow;
                    
                }
            }
        }
    }
}
