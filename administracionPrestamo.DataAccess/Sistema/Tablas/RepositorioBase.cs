using administracionPrestamo.Contracts.Sistema.Tablas;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace administracionPrestamo.DataAccess.Sistema.Tablas
{
    public class RepositorioBase<T> : IRepositorioBase<T> where T : class
    {
        protected Contexto RepositorioContexto { get; set; }

        public RepositorioBase(Contexto repositorioContexto)
        {
            RepositorioContexto = repositorioContexto;
        }

        public IQueryable<T> BuscarTodo()
        {
            return RepositorioContexto.Set<T>().AsNoTracking();
        }

        public IQueryable<T> BuscarPorCondicion(Expression<Func<T, bool>> expresion)
        {
            return RepositorioContexto.Set<T>().Where(expresion).AsNoTracking();
        }

        public void Crear(T entidad)
        {
            RepositorioContexto.Set<T>().Add(entidad);
        }

        public void Actualizar(T entidad)
        {
            RepositorioContexto.Set<T>().Update(entidad);
        }

        public void Eliminar(T entidad)
        {
            RepositorioContexto.Set<T>().Update(entidad);
        }

        public void EliminarFisicamente(T entidad)
        {
            RepositorioContexto.Set<T>().Remove(entidad);
        }
    }
}
