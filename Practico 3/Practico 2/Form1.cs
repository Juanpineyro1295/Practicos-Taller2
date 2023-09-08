using Microsoft.VisualBasic;

namespace Practico_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult ask;
            if (TNombre.Text != "" && TApellido.Text != "" && TDni.Text != "")
            {
                ask = MessageBox.Show("Seguro que desea insertar un nuveo cliente?", "Confirmar Insercion", MessageBoxButtons.YesNo);

                if (ask == DialogResult.Yes)
                {
                    LModificar.Text = TNombre.Text + " " + TApellido.Text;
                    MessageBox.Show("El Cliente: " + TNombre.Text + " " + TApellido.Text + " se insertó Correctamente", "Guardar", MessageBoxButtons.OK);

                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Alerta");
            }

        }

        private void TDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 95) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 95) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Ingrese solamente letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void TDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void BGuardar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (TNombre.Text != " " && TApellido.Text != " " && TDni.Text != " ")
            {
                LModificar.Text = TNombre.Text + " " + TApellido.Text;
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos", "Alerta");
            }
        }

        private void BGuardar_Validated(object sender, EventArgs e)
        {

        }

        private void TDni_Validated(object sender, EventArgs e)
        {

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show("Estas apunto de eliminar el Cliente: " + TNombre.Text + " " + TApellido.Text, "Confirmar Eliminacion", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                TNombre.Clear();
                TApellido.Clear();
                TDni.Clear();
                LModificar.Text = " ";
                MessageBox.Show("El Cliente: " + LModificar.Text + " se eliminó correctamente", "Eliminar", MessageBoxButtons.OK);

            }
        }
    }
}