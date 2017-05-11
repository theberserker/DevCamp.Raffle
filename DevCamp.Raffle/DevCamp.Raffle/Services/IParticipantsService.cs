using System.Collections.Generic;
using System.Threading.Tasks;
using DevCamp.Raffle.Models;

namespace DevCamp.Raffle.Services
{
    public interface IParticipantsService
    {
        Task<IEnumerable<Participant>> GetAll();
    }
}