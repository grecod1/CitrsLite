using CitrsLite.Business.Repositories;
using CitrsLite.Business.ViewModels.ParticipantViewModels;
using CitrsLite.Data.Models;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        
        public Participant BuildParticipant(ParticipantFormViewModel formModel)
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

        public async Task<IEnumerable<Participant>> GetParticipantsAsync(ParticipantIndexViewModel model)
        {
            IEnumerable<Expression<Func<Participant, bool>>> predicates = 
                new List<Expression<Func<Participant, bool>>>()
            {
                p => model.Type == null || p.Type == model.Type,
                p => model.Name == null || p.Name == model.Name,
                p => model.City == null || p.City== model.City,
                p => model.Phone == null || p.PhoneNumber == model.Phone
            };            

            return await _data.Participants.GetListAsync(predicates);
        }

        public int Create(ParticipantFormViewModel model)
        {
            Participant participant = BuildParticipant(model);

            _data.Participants.Create(participant);
            _data.SaveChanges();

            return participant.Id;
            
        }
        
        public async Task<int> CreateAysnc(ParticipantFormViewModel model)
        {
            Participant participant = BuildParticipant(model);

            await _data.Participants.CreateAsync(participant);

            await _data.SaveChangesAsync();

            return participant.Id;
        }

        public async Task EditAsync(ParticipantFormViewModel model)
        {
            var participant = await _data.Participants
                .GetFirstAsync(p => p.Id == model.Id);

            participant.Name = model.Name;
            participant.Type = model.Type;
            participant.Description = model.Description;
            participant.PhoneNumber = model.PhoneNumber;
            participant.Address = model.Address;
            participant.City = model.City;                
            participant.State = model.State;
            participant.ModifiedBy = model.UserName;
            participant.ModificationDate = DateTime.Now;

            _data.Participants.Edit(participant);
            await _data.SaveChangesAsync();
        }
    }
}
