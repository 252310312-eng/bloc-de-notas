namespace P1U62523103122APOO
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Formato();
            Apariencia();
            Diseño();

        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtArchivo.Clear();

            MessageBox.Show("Nuevo archivo creado",
                "Nuevo",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamReader leer = new StreamReader(openFileDialog1.FileName);
                txtArchivo.Text = leer.ReadToEnd();
                leer.Close();

                MessageBox.Show("Archivo abierto correctamente",
                    "Abrir",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1 == null)
                saveFileDialog1 = new SaveFileDialog();

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;

                FileStream archivo = new FileStream(path, FileMode.Create, FileAccess.Write);
                StreamWriter archivoEscribir = new StreamWriter(archivo);

                archivoEscribir.WriteLine(txtArchivo.Text);
                archivoEscribir.Close();

                MessageBox.Show("Archivo guardado correctamente",
                    "Guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se guardó el archivo",
                    "Cancelado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }



        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
           "¿Deseas salir del programa?",
           "Salir",
           MessageBoxButtons.YesNo,
           MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
       
       

        private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Block de notas\nVersión 1.0\nCreado en C#",
               "Ayuda",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void Formato()
        {
            ToolStripMenuItem menuFormato = new ToolStripMenuItem("Formato");


            ToolStripMenuItem menuFuente = new ToolStripMenuItem("Fuente");

            ToolStripMenuItem arial = new ToolStripMenuItem("Arial");
            arial.Click += (s, e) =>
            {
                txtArchivo.Font = new Font("Arial", txtArchivo.Font.Size);
            };

            ToolStripMenuItem consolas = new ToolStripMenuItem("Consolas");
            consolas.Click += (s, e) =>
            {
                txtArchivo.Font = new Font("Consolas", txtArchivo.Font.Size);
            };

            ToolStripMenuItem times = new ToolStripMenuItem("Times New Roman");
            times.Click += (s, e) =>
            {
                txtArchivo.Font = new Font("Times New Roman", txtArchivo.Font.Size);
            };

            ToolStripMenuItem comic = new ToolStripMenuItem("Comic Sans MS");
            comic.Click += (s, e) =>
            {
                txtArchivo.Font = new Font("Comic Sans MS", txtArchivo.Font.Size);
            };

            menuFuente.DropDownItems.Add(arial);
            menuFuente.DropDownItems.Add(consolas);
            menuFuente.DropDownItems.Add(times);
            menuFuente.DropDownItems.Add(comic);

            ToolStripMenuItem menuTamaño = new ToolStripMenuItem("Tamaño");

            ToolStripMenuItem tamaño12 = new ToolStripMenuItem("12");
            tamaño12.Click += (s, e) =>
            {
                txtArchivo.Font = new Font(txtArchivo.Font.FontFamily, 12);
            };

            ToolStripMenuItem tamaño18 = new ToolStripMenuItem("18");
            tamaño18.Click += (s, e) =>
            {
                txtArchivo.Font = new Font(txtArchivo.Font.FontFamily, 18);
            };

            ToolStripMenuItem tamaño24 = new ToolStripMenuItem("24");
            tamaño24.Click += (s, e) =>
            {
                txtArchivo.Font = new Font(txtArchivo.Font.FontFamily, 24);
            };

            menuTamaño.DropDownItems.Add(tamaño12);
            menuTamaño.DropDownItems.Add(tamaño18);
            menuTamaño.DropDownItems.Add(tamaño24);


            ToolStripMenuItem menuColor = new ToolStripMenuItem("Color de letra");

            ToolStripMenuItem negro = new ToolStripMenuItem("Negro");
            negro.Click += (s, e) =>
            {
                txtArchivo.ForeColor = Color.Black;
            };

            ToolStripMenuItem azul = new ToolStripMenuItem("Azul");
            azul.Click += (s, e) =>
            {
                txtArchivo.ForeColor = Color.Blue;
            };

            ToolStripMenuItem rojo = new ToolStripMenuItem("Rojo");
            rojo.Click += (s, e) =>
            {
                txtArchivo.ForeColor = Color.Red;
            };

            ToolStripMenuItem verde = new ToolStripMenuItem("Verde");
            verde.Click += (s, e) =>
            {
                txtArchivo.ForeColor = Color.Green;
            };

            menuColor.DropDownItems.Add(negro);
            menuColor.DropDownItems.Add(azul);
            menuColor.DropDownItems.Add(rojo);
            menuColor.DropDownItems.Add(verde);

            menuFormato.DropDownItems.Add(menuFuente);
            menuFormato.DropDownItems.Add(menuTamaño);
            menuFormato.DropDownItems.Add(menuColor);

            menuStrip1.Items.Add(menuFormato);
        }


        private void Apariencia()
        {
            ToolStripMenuItem menuApariencia =
                new ToolStripMenuItem("Apariencia");

            ToolStripMenuItem claro =
                new ToolStripMenuItem("Modo Claro");

            claro.Click += (s, e) =>
            {
                txtArchivo.BackColor = Color.White;
                txtArchivo.ForeColor = Color.Black;
                this.BackColor = Color.WhiteSmoke;
            };

            ToolStripMenuItem oscuro =
                new ToolStripMenuItem("Modo Oscuro");

            oscuro.Click += (s, e) =>
            {
                txtArchivo.BackColor =
                    Color.FromArgb(30, 30, 30);

                txtArchivo.ForeColor =
                    Color.WhiteSmoke;

                this.BackColor =
                    Color.FromArgb(45, 45, 48);
            };

            menuApariencia.DropDownItems.Add(claro);
            menuApariencia.DropDownItems.Add(oscuro);

            menuStrip1.Items.Add(menuApariencia);
        }


        private void Diseño()
        {
            txtArchivo.BackColor = Color.White;
            txtArchivo.ForeColor = Color.Black;
            txtArchivo.Font = new Font("Calibri", 12);
            txtArchivo.ScrollBars = ScrollBars.Vertical;

            this.BackColor = Color.WhiteSmoke;
            this.Text = "Bloc de Notas ";
        }

        
    }
}

