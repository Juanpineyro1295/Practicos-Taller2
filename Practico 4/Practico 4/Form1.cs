using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practico_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BFuncion_Click(object sender, EventArgs e)
        {
            if ((TDesde.Text != "")&&(THasta.Text != "")) 
            {
                int desde = Convert.ToInt32(TDesde.Text);   
                int hasta = Convert.ToInt32(THasta.Text);
                if (desde >= hasta) 
                {
                    MessageBox.Show("El valor inicial debe ser menor que el valor final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LBNum.Items.Clear();
                    int [] resultado = new int[hasta - desde + 1] ;
                    for (int i = 0; i < resultado.Length; i++)
                    {
                        resultado[i] = desde + i;
                        LBNum.Items.Add(resultado[i]);  
                    }                                         
                }
            }
            else
            { 
                MessageBox.Show("No hay Números", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void THasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void LBNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BPares_Click(object sender, EventArgs e)
        {
            try
            {
                if ((TDesde.Text != "") && (THasta.Text != ""))
                {
                    int desde = Convert.ToInt32(TDesde.Text);
                    int hasta = Convert.ToInt32(THasta.Text);
                    if (desde >= hasta)
                    {
                        MessageBox.Show("El valor inicial debe ser menor que el valor final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        LBNum.Items.Clear();
                        for (int i = desde; i <= hasta; i++)
                        {
                            int b = i % 2;
                            if (b == 0)
                            {
                                LBNum.Items.Add(i);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No hay núneros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch(Exception error ) {MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
            
        }

        private void BImpares_Click(object sender, EventArgs e)
        {
            if ((TDesde.Text != null || TDesde.Text != "") && (THasta.Text != null || THasta.Text != ""))
            {
                int desde = Convert.ToInt32(TDesde.Text);
                int hasta = Convert.ToInt32(THasta.Text);
                if (desde >= hasta)
                {
                    MessageBox.Show("El valor inicial debe ser menor que el valor final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LBNum.Items.Clear();
                    for (int i = desde; i <= hasta; i++)
                    {
                        int b = i % 2;
                        if (b != 0)
                        {
                            LBNum.Items.Add(i);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay núneros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BPrimos_Click(object sender, EventArgs e)
        {
            if ((TDesde.Text != null || TDesde.Text != " ") && (THasta.Text != null || THasta.Text != " "))
            {
                int desde = Convert.ToInt32(TDesde.Text);
                int hasta = Convert.ToInt32(THasta.Text);
                if (desde >= hasta)
                {
                    MessageBox.Show("El valor inicial debe ser menor que el valor final.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LBNum.Items.Clear();
                    for (int i = desde; i <= hasta; i++)
                    {
                        
                        if (Primo(i))
                        {
                            LBNum.Items.Add(i);
                        }
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("No hay núneros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        static bool Primo(int i)
        {
            for (int a = 2; a <= Math.Sqrt(i); a++)
            {
                if (i % a == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
