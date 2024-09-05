using Domaine;
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

namespace PrimeraConexion
{
    public partial class AgregarFrm : Form
    {
        //Nueva ventana para agregar
        public AgregarFrm()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Boton aceptar
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Discos discos = new Discos();
            DiscosDataBase discosbusiness = new DiscosDataBase();
            try
            {
                discos.Titulo = txtTitulo.Text;
                discos.CantidadCanciones = int.Parse(txtCanciones.Text);
                discos.Marca = txtbMarca.Text;
                discos.Tipo = (Estilos)cbEstilo.SelectedItem;
                discosbusiness.Agregar(discos);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void AgregarFrm_Load(object sender, EventArgs e)
        {
            EstilosNegocio estilosNegocio = new EstilosNegocio();
            try
            {
                cbEstilo.DataSource = estilosNegocio.listar();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
