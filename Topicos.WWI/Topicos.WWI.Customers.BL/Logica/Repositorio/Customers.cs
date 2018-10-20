using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Topicos.WWI.Customers.BL.Logica.Repositorio
{
    internal class Customers
    {
        Model.WideWorldImportersEntities _miContexto = new Model.WideWorldImportersEntities();

        public IList<Model.Customers> ListarPorNombreAproximado (string elNombreAproximado)
        {
            var elResultado = _miContexto.Customers.Where(c => c.CustomerName.Contains(elNombreAproximado)).ToList();
            return elResultado;
        }

        public IList<Model.Customers> ListarPorNombreAproximadoV2(string elNombreAproximado)
        {
            var elResultado = (from c in _miContexto.Customers
                               where c.CustomerName.Contains(elNombreAproximado)
                               select c
                               ).ToList();
            return elResultado;
        }


    }
}