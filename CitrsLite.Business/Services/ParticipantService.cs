using CitrsLite.Business.Repositories;
using CitrsLite.Business.ViewModels.ParticipantViewModels;
using CitrsLite.Data.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitrsLite.Business.Services
{
    public class ParticipantService
    {
        private IUnitOfWork _data;

        public ParticipantService(string connectionString)
        {
            _data= new UnitOfWork(connectionString);
        }

        public Participant GetParticipant(ParticipantFormViewModel formModel)
        {
            return new Participant()
            {
                Name = formModel.Name,
                Type = formModel.Type,
                Description = formModel.Description,
                PhoneNumber = formModel.PhoneNumber,
                Address = formModel.Address,
                City = formModel.City,
                State = formModel.State ?? "FL",
                IsActive = true,
                CreatedBy = formModel.UserName,
                CreationDate = DateTime.Now,
                ModifiedBy = formModel.UserName,
            };
        }

        public void Create(ParticipantFormViewModel formModel)
        {
            Participant participant = GetParticipant(formModel);

            _data.Participants.Create(participant);
            _data.SaveChanges();
            
        }

        public async void CreateAysnc(ParticipantFormViewModel formModel)
        {
            Participant participant = GetParticipant(formModel);

            await _data.Participants.CreateAsync(participant);

            await _data.SaveChangesAsync();
        }
    }
}
