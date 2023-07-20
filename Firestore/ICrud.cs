using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firestore
{
    public interface ICrud<T> where T : class
    {
        /// <summary>
        /// Crea una entidad en la base de datos.
        /// </summary>
        Task Create(T entity, string id);

        /// <summary>
        /// Elimina una entidad en la base de datos.
        /// </summary>
        Task Delete(string id);

        /// <summary>
        /// Actaiza una entidad en la base de datos.
        /// </summary>
        Task Update(T entity, string id);

        /// <summary>
        /// Obtiene una entidad en la base de datos.
        /// </summary>
        Task<T> Get(string id);

        /// <summary>
        /// Obtiene todas las entidades de una coleccion en la base de datos.
        /// </summary>
        Task<List<T>> GetAll();

        /// <summary>
        /// Verifica si existe un campo con un valor específico en la base de datos.
        /// </summary>
        Task<bool> FieldExists(string field, string value);
    }
}