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
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private CitrsLiteContext _context;
        private GenericRepository<Budwood> budwoods;
        private GenericRepository<Participant> participants;
        private GenericRepository<Registration> registrations;
        private GenericRepository<Tree> trees;
        private GenericRepository<TreeLocation> treeLocations;
        private GenericRepository<TreeType> treeTypes;
        private GenericRepository<VarietyClone> varietyClones;

        public UnitOfWork(string connectionString)
        {
            _context = new CitrsLiteContext(connectionString);

        }

        private bool disposed = false;

        public IGenericRepository<Budwood> Budwoods
        {
            get
            {
                if (this.budwoods == null)
                {
                    this.budwoods = new GenericRepository<Budwood>(_context);
                }

                return budwoods;
            }
        }

        public IGenericRepository<Participant> Participants
        {
            get
            {
                if (this.participants == null)
                {
                    this.participants = new GenericRepository<Participant>(_context);
                }

                return participants;
            }
        }

        public IGenericRepository<Registration> Registrations
        {
            get
            {
                if (this.registrations == null)
                {
                    this.registrations = new GenericRepository<Registration>(_context);
                }

                return registrations;
            }
        }

        public IGenericRepository<Tree> Trees
        {
            get
            {
                if (this.trees == null)
                {
                    this.trees = new GenericRepository<Tree>(_context);
                }

                return trees;
            }
        }

        public IGenericRepository<TreeLocation> TreeLocations
        {
            get
            {
                if (this.treeLocations == null)
                {
                    this.treeLocations = new GenericRepository<TreeLocation>(_context);
                }

                return treeLocations;
            }
        }

        public IGenericRepository<TreeType> TreeTypes
        {
            get
            {
                if (this.treeTypes == null)
                {
                    this.treeTypes = new GenericRepository<TreeType>(_context);
                }

                return treeTypes;
            }
        }

        public IGenericRepository<VarietyClone> VarietyClones
        {
            get
            {
                if (this.varietyClones == null)
                {
                    this.varietyClones = new GenericRepository<VarietyClone>(_context);
                }

                return varietyClones;
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
