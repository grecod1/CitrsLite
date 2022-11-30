using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Business.Repositories.Interfaces
{
    internal interface IGenericRepository<T> where T : class
    {
        /// <summary>
        /// Get a list of objects.
        /// </summary>
        /// <param name="predicate">The filter condition</param>
        /// <param name="includedProperties">included propertiers</param>
        /// <returns></returns>
        public IList<T> GetList(Expression<Func<T, bool>> predicate, 
            params string[] includedProperties);
    }
}
