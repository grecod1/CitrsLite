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

        public async Task<ParticipantFormViewModel> GetFormViewModelAsync(int? id = null)
        {
            if(id != null)
            {
                var participant = await _data.Participants.GetFirstAsync(x => x.Id == id);

                return new ParticipantFormViewModel()
                {
                    Id = participant.Id,
                    Name = participant.Name,
                    Type = participant.Type,
                    Description = participant.Description,
                    PhoneNumber = participant.PhoneNumber,
                    Address = participant.Address,
                    City = participant.City,
                    State = participant.State,
                    IsActive = participant.IsActive
                };

            }
            else
            {
                return new ParticipantFormViewModel();
            }
        }

        public int Create(ParticipantFormViewModel formModel)
        {
            Participant participant = GetParticipant(formModel);

            _data.Participants.Create(participant);
            _data.SaveChanges();

            return participant.Id;
            
        }
        
        public async Task<int> CreateAysnc(ParticipantFormViewModel formModel)
        {
            Participant participant = GetParticipant(formModel);

            await _data.Participants.CreateAsync(participant);

            await _data.SaveChangesAsync();

            return participant.Id;
        }
    }
}
