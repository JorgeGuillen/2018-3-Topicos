using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topicos.WWI.Customers.BL.Logica.Especificacion
{
    public class Customers
    {
        public IList<Model.Customers> ListarPorNombreAproximado(string elNombreAproximado)
        {
            var laAccion = new Logica.Accion.Customers();
            var elResultado = laAccion.ListarPorNombreAproximado(elNombreAproximado);
            return elResultado;
        }

    }
}