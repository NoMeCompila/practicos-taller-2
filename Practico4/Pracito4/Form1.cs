using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracito4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void txt_desde_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void txt_desde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_hasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }



        private void btn_funcion_Click(object sender, EventArgs e)
        {
            if (txt_desde.Text == "" || txt_hasta.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!",
                                "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txt_desde.Clear();
                txt_hasta.Clear();

            }
            else
            {
                int num1 = Int32.Parse(txt_desde.Text);
                int num2 = Int32.Parse(txt_hasta.Text);


                for (int i = num1; i <= num2; i++)
                {
                    //list_numeros.Items.Add(i);
                    listBox1.Items.Add(i);
                    
                }


                txt_desde.Clear();
                txt_hasta.Clear();
            }
            

             
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_desde.Text == "" || txt_hasta.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!",
                                "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txt_desde.Clear();
                txt_hasta.Clear();

            }
            else
            {
                int num1 = Int32.Parse(txt_desde.Text);
                int num2 = Int32.Parse(txt_hasta.Text);


                for (int i = num1; i <= num2; i++)
                {
                    if (i % 2 == 0)
                    {
                        listBox1.Items.Add(i);
                    }
                    
                }


                txt_desde.Clear();
                txt_hasta.Clear();
            }
        }

        private void btn_impares_Click(object sender, EventArgs e)
        {
            if (txt_desde.Text == "" || txt_hasta.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!",
                                "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txt_desde.Clear();
                txt_hasta.Clear();

            }
            else
            {
                int num1 = Int32.Parse(txt_desde.Text);
                int num2 = Int32.Parse(txt_hasta.Text);


                for (int i = num1; i <= num2; i++)
                {
                    if (i % 2 != 0)
                    {
                        listBox1.Items.Add(i);
                    }

                }


                txt_desde.Clear();
                txt_hasta.Clear();
            }
        }

        private void btn_primos_Click(object sender, EventArgs e)
        {
            if (txt_desde.Text == "" || txt_hasta.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!",
                                "ERROR!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                txt_desde.Clear();
                txt_hasta.Clear();

            }
            else
            {
                int num1 = Int32.Parse(txt_desde.Text);
                int num2 = Int32.Parse(txt_hasta.Text);

                
                for (int i = num1; i <= num2; i++)
                {
                    int conta = 0;
                    for (int j=1; j<=i;j++)
                        if (i % j == 0)
                        {
                            conta++;
                        }
                    if (conta == 2)
                    {
                        listBox1.Items.Add(i);
                    }
                }


                txt_desde.Clear();
                txt_hasta.Clear();
            }
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

       
    }
}
