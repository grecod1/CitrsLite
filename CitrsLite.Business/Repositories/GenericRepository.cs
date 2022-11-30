using CitrsLite.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Business.Repositories
{
    /// <summary>
    /// Generic Repository Class
    /// </summary>
    /// <typeparam name="T">Entity Object</typeparam>
    internal class GenericRepository<T> where T : class
    {
        internal CitrsLiteContext _dbContext;
        internal DbSet<T> _dbSet;

        public GenericRepository(CitrsLiteContext _dbContext)
        {
            this._dbContext = _dbContext;
            this._dbSet = _dbContext.Set<T>();

            
        }

        protected void Dispose()
        {
            _dbContext.Dispose();
        }

        /// <summary>
        /// Get a list of models from database.
        /// </summary>
        /// <param name="predicate">Condition</param>
        /// <param name="includedProperties">Included properties</param>
        /// <returns>List of models.</returns>
        public virtual IList<T> GetList(Expression<Func<T, bool>>? predicate = null,
            params string[] includedProperties)
        {
            IQueryable<T> query = _dbSet;

            if (includedProperties != null)
            {
                foreach (string includedProperty in includedProperties)
                {
                    query = query.Include(includedProperty);
                }
            }

            if (predicate != null)
            {
                //If the user includes a filter
                return query.Where(predicate).ToList<T>();
            }
            else
            {
                // In case the user wants to return all results.
                return query.ToList<T>();
            }

        }

        /// <summary>
        /// Return a list of models from the database.
        /// </summary>
        /// <param name="predicate">Condition</param>
        /// <param name="includedProperties">Included properties</param>
        /// <returns>List of models.</returns>
        public virtual async Task<IList<T>> GetListAsync(Expression<Func<T, bool>>? predicate = null,
            params string[] includedProperties)
        {
            IQueryable<T> query = _dbSet;
            
            if (includedProperties != null)
            {
                foreach (string includedProperty in includedProperties)
                {
                    query = query.Include(includedProperty);
                }

            }
            if (predicate != null)
            {
                //If the user includes a filter
                return await query.Where(predicate).ToListAsync<T>();
            }
            else
            {
                // In case the user wants to return all results.
                return await query.ToListAsync<T>();
            }
        }

        /// <summary>
        /// Creates a new Model in the Database.
        /// </summary>
        /// <param name="t">Model being Created</param>
        public virtual void Create(T t)
        {
            _dbSet.Add(t);
        }

        /// <summary>
        /// Updates an existing Model.
        /// </summary>
        /// <param name="t">Pre-existing Model in the Database</param>
        public virtual void Edit (T t)
        {
            _dbSet.Attach(t);
            _dbContext.Entry(t).State = EntityState.Modified;
        }

        /// <summary>
        /// Remove Entry from Database.
        /// </summary>
        /// <param name="t">Entry in the Database you want to Remove</param>
        public virtual void Remove(T t)
        {
            _dbSet.Remove(t);
        }
    }
}
