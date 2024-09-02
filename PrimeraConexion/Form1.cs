using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeraConexion
{
    public partial class Form1 : Form
    {
        List<Discos> lista;
        public Form1()
        {
            InitializeComponent();
        }

        private void cargarImagen(string Imagen)
        {
            try
            {
                pboxDiscos.Load(Imagen);
            }
            catch (Exception)
            {
                pboxDiscos.Load("https://archive.org/download/placeholder-image/placeholder-image.jpg");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DiscosDataBase DiscosDB = new DiscosDataBase();
            lista = DiscosDB.listarDiscos();
            dgvDiscos.DataSource = lista;
        }

        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
        }
    }
}
