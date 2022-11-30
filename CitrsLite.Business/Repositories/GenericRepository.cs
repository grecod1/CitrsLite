using CitrsLite.Data.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

    }
}
