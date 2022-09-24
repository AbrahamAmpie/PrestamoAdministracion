using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace administracionPrestamo.Contracts.Sistema.Tablas
{
    public interface IRepositorioBase<T>
    {
        IQueryable<T> BuscarTodo();
        IQueryable<T> BuscarPorCondicion(Expression<Func<T, bool>> expresion);
        void Crear(T entidad);
        void Actualizar(T entidad);
        void Eliminar(T entidad);
        void EliminarFisicamente(T entidad);
    }
}
