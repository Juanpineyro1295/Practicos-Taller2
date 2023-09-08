using System.Diagnostics;
using System.Globalization;

namespace Practico_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BFoto_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Archivos de imágenes|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                String rutaImagen = dialog.FileName;
                pictureBox1.Image = Image.FromFile(rutaImagen);
                TFoto.Text = rutaImagen;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TFoto_TextChanged(object sender, EventArgs e)
        {

        }

        private void TNombre_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TNombre.Text))
            {
                return;
            }
            TNombre.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TNombre.Text.ToLower());
            TNombre.Select(TNombre.Text.Length, 0);
        }

        private void TApellido_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TApellido.Text))
            {
                return;
            }
            TApellido.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(TApellido.Text.ToLower());
            TApellido.Select(TApellido.Text.Length, 0);
        }

        private void BAgregar_Click(object sender, EventArgs e)
        {
            //Obtener valores de los TextBoxs
            String nombre = TNombre.Text;
            String apellido = TApellido.Text;
            DateTime fechaNac = dateTimePicker1.Value;
            String ruta = TFoto.Text;
            Image imagen = Image.FromFile(ruta);
            String sexo = "";
            if (RMujer.Checked)
            {
                sexo = "Mujer";
            }
            else
            {
                sexo = "Hombre";
            }

            Decimal saldo = Convert.ToDecimal(TSaldo.Text);

            //Agregar una nueva fila al DataGridView con los Valores ingresados

            var fila = new DataGridViewRow();
            fila.CreateCells(dataGridView, nombre, apellido, fechaNac, sexo, "", saldo, "", ruta);

            //Cargar la Imagen dsde la ruta y asignarla a la columna de imagen

            fila.Cells[6].Value = imagen;
            if (saldo < 50)
            {
                fila.DefaultCellStyle.BackColor = Color.Red;
            }
            dataGridView.Rows.Add(fila);

            //Limpiar los TextBoxes después de guardar

            TNombre.Clear();
            TApellido.Clear();
            dateTimePicker1.Value = DateTime.Now;
            RMujer.Checked = false;
            RHombre.Checked = false;
            TSaldo.Clear();
            CargarImagenPorDefecto();
            ruta = "";
        }

        private void CargarImagenPorDefecto()
        {
            String rutaPorDefecto = "C:/Users/Juanma/source/repos/Prácticos/Practico 5/Practico 5/bin/Debug/Fotos/avatar.h.png";
            Image imagenPorDefecto = Image.FromFile(rutaPorDefecto);
            pictureBox1.Image = imagenPorDefecto;
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataGridView.Columns("Eliminar").Index && e.RowIndex >= 0)
            {
                if (MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DataGridViewRow row = dataGridView.Rows(e.RowIndex);
                    dataGridView.Rows.Remove(row);
                }
                //Elimina la Fila
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            Debug.Print("Evento SelectionChanged se ha disparado.");

            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.SelectedRows[0];
                String leyendaSexo = selectedRow.Cells("Sexo").Value.ToString();

                Debug.Print("Leyenda del sexo:" + leyendaSexo);

                if (leyendaSexo == "Hombre")
                {
                    Debug.Print("Seleccionado RadioButton Masculino.");
                    RHombre.Checked = true;
                    RMujer.Checked = false;
                }
                else
                {
                    if (leyendaSexo == "Mujer")
                    {
                        Debug.Print("Seleccionado RadioButton Femenino.");
                        RHombre.Checked = false;
                        RMujer.Checked = true;
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}