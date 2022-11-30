using CitrsLite.Business.Repositories.Interfaces;
using CitrsLite.Data.Entity;
using CitrsLite.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Business.Repositories
{    
    public class UnitOfWork : IDisposable
    {
        private CitrsLiteContext _context;
        private GenericRepository<TreeType> treeTypes;


        public UnitOfWork(string connectionString)
        {
            _context = new CitrsLiteContext(connectionString);
        
        }

        private bool disposed = false;

        public IGenericRepository<TreeType> TreeTypes
        {
            get
            {
                if(this.treeTypes == null)
                {
                    this.treeTypes = new GenericRepository<TreeType>(_context);
                }

                return treeTypes;
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }    
}
