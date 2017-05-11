using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevCamp.Raffle.Models;

namespace DevCamp.Raffle.Services
{
    public class ParticipantsService : IParticipantsService
    {
        public async Task<IEnumerable<Participant>> GetAll()
        {
            await Task.Delay(TimeSpan.FromSeconds(3));
            return new List<Participant>
            {
                new Participant(1, "Janez Novak", "pixi*"),
                new Participant(4, "Miha Novak", "pixi"),
            };
        }
    }
}
