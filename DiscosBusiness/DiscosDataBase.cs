using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Domaine;

namespace DiscosBusiness
{
    //Clase para generar metodos de acceso a datos
    public class DiscosDataBase
    {
        public List<Discos> listarDiscos()
        {
            List<Discos> listaDiscos = new List<Discos>();
            try
            {
                //Para conectarse a la BD
                SqlConnection conexion = new SqlConnection();

                //Para realizar acciones sobre la BD
                SqlCommand comando = new SqlCommand();

                //Para capturar los datos
                SqlDataReader lector;

                //Condfiguraciones de los objetos
                //Cadena de string para definir el servidor, la BD y el usuario.
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=DISCOS_DB; integrated security=true";

                //Para definir el tipo de comando para las consultas SQL
                comando.CommandType = System.Data.CommandType.Text;

                //Definir consultas SQL
                comando.CommandText = "SELECT D.Titulo, D.UrlImagenTapa, D.CantidadCanciones, D.Marca FROM DISCOS D";

                //Configurar que ese comando lo realice en esa conexion
                comando.Connection = conexion;
                conexion.Open();

                //Ejecuto la lecutra
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Discos aux = new Discos();
                    aux.Titulo = (string)lector["Titulo"];
                    aux.UrlImagen = (string)lector["UrlImagenTapa"];
                    aux.CantidadCanciones = (int)lector["CantidadCanciones"];
                    aux.Marca = (string)lector["Marca"];
                    //Creacion de la asignacion
                    //aux.Tipo = new Estilos();
                    //aux.Tipo.Descripcion = (string)lector["Tipo"];
                    //aux.Edicion = new Seccion();
                    //aux.Edicion.Descripcion = (string)lector["Edicion"];
                    listaDiscos.Add(aux);
                }

                conexion.Close();
                return listaDiscos;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //Agregamos metodo "agregar" para el AgregarFrm
        public void Agregar(Discos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("INSERT INTO DISCOS (Titulo, CantidadCanciones, Marca) VALUES ('" + nuevo.Titulo + "','" + nuevo.CantidadCanciones + "','" + nuevo.Marca + "')");
                datos.executeAction();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.close();
            }
        }
    }
}
