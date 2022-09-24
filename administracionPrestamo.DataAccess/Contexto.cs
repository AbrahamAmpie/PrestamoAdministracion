using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;

namespace administracionPrestamo.DataAccess
{
    public class Contexto
    {
        public IConfiguration Configuracion { get; }

        public Contexto(IConfiguration configuracion)
        {
            Configuracion = configuracion;
        }

        public void Conexion() 
        {
            Configuracion.GetConnectionString("ServidorBD");
        }
    }
}