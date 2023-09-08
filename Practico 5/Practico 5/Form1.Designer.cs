namespace Practico_5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            TFoto = new TextBox();
            TSaldo = new TextBox();
            TApellido = new TextBox();
            TNombre = new TextBox();
            BAgregar = new Button();
            BFoto = new Button();
            RHombre = new RadioButton();
            RMujer = new RadioButton();
            label5 = new Label();
            label1 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            dataGridView = new DataGridView();
            Apellido = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            FechaNac = new DataGridViewTextBoxColumn();
            Sexo = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewButtonColumn();
            Saldo = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewImageColumn();
            Ruta = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(TFoto);
            panel1.Controls.Add(TSaldo);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(BAgregar);
            panel1.Controls.Add(BFoto);
            panel1.Controls.Add(RHombre);
            panel1.Controls.Add(RMujer);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(119, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 282);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(231, 99);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // TFoto
            // 
            TFoto.Location = new Point(125, 207);
            TFoto.Name = "TFoto";
            TFoto.Size = new Size(251, 23);
            TFoto.TabIndex = 12;
            TFoto.TextChanged += TFoto_TextChanged;
            // 
            // TSaldo
            // 
            TSaldo.Location = new Point(125, 172);
            TSaldo.Name = "TSaldo";
            TSaldo.Size = new Size(251, 23);
            TSaldo.TabIndex = 11;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(125, 58);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(251, 23);
            TApellido.TabIndex = 10;
            TApellido.TextChanged += TApellido_TextChanged;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(125, 23);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(251, 23);
            TNombre.TabIndex = 9;
            TNombre.TextChanged += TNombre_TextChanged;
            // 
            // BAgregar
            // 
            BAgregar.Image = (Image)resources.GetObject("BAgregar.Image");
            BAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BAgregar.Location = new Point(165, 233);
            BAgregar.Name = "BAgregar";
            BAgregar.Size = new Size(92, 40);
            BAgregar.TabIndex = 8;
            BAgregar.Text = "Agregar";
            BAgregar.TextAlign = ContentAlignment.MiddleRight;
            BAgregar.UseVisualStyleBackColor = true;
            BAgregar.Click += BAgregar_Click;
            // 
            // BFoto
            // 
            BFoto.Location = new Point(26, 206);
            BFoto.Name = "BFoto";
            BFoto.Size = new Size(75, 23);
            BFoto.TabIndex = 7;
            BFoto.Text = "Foto";
            BFoto.UseVisualStyleBackColor = true;
            BFoto.Click += BFoto_Click;
            // 
            // RHombre
            // 
            RHombre.AutoSize = true;
            RHombre.BackColor = Color.Transparent;
            RHombre.Font = new Font("Ink Free", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            RHombre.ForeColor = SystemColors.ControlLightLight;
            RHombre.Location = new Point(238, 135);
            RHombre.Name = "RHombre";
            RHombre.Size = new Size(79, 24);
            RHombre.TabIndex = 6;
            RHombre.TabStop = true;
            RHombre.Text = "Hombre";
            RHombre.UseVisualStyleBackColor = false;
            // 
            // RMujer
            // 
            RMujer.AutoSize = true;
            RMujer.BackColor = Color.Transparent;
            RMujer.Font = new Font("Ink Free", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            RMujer.ForeColor = SystemColors.ControlLightLight;
            RMujer.Location = new Point(132, 135);
            RMujer.Name = "RMujer";
            RMujer.Size = new Size(65, 24);
            RMujer.TabIndex = 5;
            RMujer.TabStop = true;
            RMujer.Text = "Mujer";
            RMujer.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(26, 133);
            label5.Name = "label5";
            label5.Size = new Size(55, 26);
            label5.TabIndex = 4;
            label5.Text = "Sexo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(26, 19);
            label1.Name = "label1";
            label1.Size = new Size(85, 26);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(26, 168);
            label4.Name = "label4";
            label4.Size = new Size(62, 26);
            label4.TabIndex = 3;
            label4.Text = "Saldo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(26, 96);
            label3.Name = "label3";
            label3.Size = new Size(199, 26);
            label3.TabIndex = 2;
            label3.Text = "Fecha de Nacimiento:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Ink Free", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(26, 54);
            label2.Name = "label2";
            label2.Size = new Size(82, 26);
            label2.TabIndex = 1;
            label2.Text = "Apellido:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(608, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(192, 190);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { Apellido, Nombre, FechaNac, Sexo, Eliminar, Saldo, Foto, Ruta });
            dataGridView.Location = new Point(12, 322);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(876, 223);
            dataGridView.TabIndex = 2;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // FechaNac
            // 
            FechaNac.HeaderText = "Fecha Nacimiento";
            FechaNac.Name = "FechaNac";
            // 
            // Sexo
            // 
            Sexo.HeaderText = "Sexo";
            Sexo.Name = "Sexo";
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Name = "Eliminar";
            Eliminar.Text = "Eliminar";
            // 
            // Saldo
            // 
            Saldo.HeaderText = "Saldo";
            Saldo.Name = "Saldo";
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.Name = "Foto";
            // 
            // Ruta
            // 
            Ruta.HeaderText = "Ruta";
            Ruta.Name = "Ruta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(880, 569);
            Controls.Add(dataGridView);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Formulario con DataGrid";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
        }

        private void DataGridView_SelectionChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private RadioButton RHombre;
        private RadioButton RMujer;
        private Button BFoto;
        private Button BAgregar;
        private TextBox TFoto;
        private TextBox TSaldo;
        private TextBox TApellido;
        private TextBox TNombre;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn FechaNac;
        private DataGridViewTextBoxColumn Sexo;
        private DataGridViewButtonColumn Eliminar;
        private DataGridViewTextBoxColumn Saldo;
        private DataGridViewImageColumn Foto;
        private DataGridViewTextBoxColumn Ruta;
    }
}