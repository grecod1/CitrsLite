using CitrsLite.Data.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Business.Repositories
{    
    public class UnitOfWork
    {
        private CitrsLiteContext _context;

        public UnitOfWork(string connectionString)
        {
            _context = new CitrsLiteContext(connectionString);
        }

    }    
}
