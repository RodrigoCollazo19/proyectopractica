using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscosBusiness;
using Domaine;

namespace PrimeraConexion
{
    public partial class Form1 : Form
    {
        //Creacion de lista para usarla en (1) y (2)
        List<Discos> listaDiscos;
        List<Estilos> listaEstilos;
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
        //Carga de registros al DGV
        private void Form1_Load(object sender, EventArgs e)
        {
            DiscosDataBase DiscosDB = new DiscosDataBase();
            EstilosNegocio estilosNegocio = new EstilosNegocio();
            listaDiscos = DiscosDB.listarDiscos(); //(1)
            dgvDiscos.DataSource = listaDiscos; //(2)
            listaEstilos = estilosNegocio.listar();
            dgvEstilos.DataSource = listaEstilos;
            //Quitar la columna URL
            dgvDiscos.Columns["UrlImagen"].Visible = false;

        }
        //Puntero para seleccionar los distintos registros
        private void dgvDiscos_SelectionChanged(object sender, EventArgs e)
        {
            Discos seleccionado = (Discos)dgvDiscos.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.UrlImagen);
            

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarFrm agregarFrm = new AgregarFrm();
            agregarFrm.ShowDialog();
        }
    }
}
