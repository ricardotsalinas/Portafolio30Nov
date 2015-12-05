using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConexionDatos.Entity;
using ConexionDatos.Dao;

namespace Negocio
{
    public     class NegocioRestriccion
    {

        public static NegocioRestriccion Instancia = new NegocioRestriccion();

        public int InsertarRestriccion(RESTRICCION dto)
        {
            return RestriccionDao.Instancia.Crear(dto);
        }
    }
}
