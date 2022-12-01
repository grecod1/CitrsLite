using CitrsLite.Business.Repositories.Interfaces;
using CitrsLite.Data.Models;

namespace CitrsLite.Business.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepository<Budwood> Budwoods { get; }
        IGenericRepository<Participant> Participants { get; }
        IGenericRepository<Registration> Registrations { get; }
        IGenericRepository<TreeLocation> TreeLocations { get; }
        IGenericRepository<Tree> Trees { get; }
        IGenericRepository<TreeType> TreeTypes { get; }
        IGenericRepository<VarietyClone> VarietyClones { get; }

    }
}