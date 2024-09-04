using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domaine;

namespace DiscosBusiness
{
    public class EstilosNegocio
    {
        public List<Estilos> listar()
        {
            List<Estilos> lista = new List<Estilos>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("Select Id, Descripcion From ESTILOS");
                datos.executeQuery();

                while (datos.Lector.Read())
                {
                    Estilos aux = new Estilos();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
            }
            catch (Exception)
            {

                throw;
            }

            return lista;
        }
    }
}
