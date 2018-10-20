using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topicos.WWI.Customers.BL.Logica.Accion
{
    public class Customers
    {
        public IList<Model.Customers> ListarPorNombreAproximado(string elNombreAproximado)
        {
            var elRepositorio = new Logica.Repositorio.Customers();
            var elResultado = elRepositorio.ListarPorNombreAproximado(elNombreAproximado);
            return elResultado;
        }

    }
}