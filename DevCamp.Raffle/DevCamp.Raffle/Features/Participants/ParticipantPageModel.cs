using DevCamp.Raffle.Models;
using FreshMvvm;

namespace DevCamp.Raffle.Features.Participants
{
    public class ParticipantPageModel : FreshBasePageModel
    {
        public Participant Participant { get; set; }

        public ParticipantPageModel()
        {

        }

        public override void Init(object initData)
        {
            base.Init(initData);

            Participant = initData as Participant;

        }
    }
}