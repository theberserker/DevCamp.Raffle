using System.Collections.Generic;
using System.Linq;
using DevCamp.Raffle.Models;
using DevCamp.Raffle.Services;
using FreshMvvm;

namespace DevCamp.Raffle.Features.Participants
{
    public class ParticipantListPageModel : FreshBasePageModel
    {
        private readonly IParticipantsService _participantsService;

        public IList<Participant> ParticipantList { get; set; }

        public Participant SelectedParticipant
        {
            get { return null; }
            set
            {
                if (value != null)
                {
                    //CoreMethods.PushPageModel<ParticipantPageModel>(value);
                    RaisePropertyChanged();
                }
            }
        }

        public ParticipantListPageModel(IParticipantsService participantsService)
        {
            this._participantsService = participantsService;
        }

        public override async void Init(object initData)
        {
            base.Init(initData);
            ParticipantList = (await _participantsService.GetAll()).ToList();
            RaisePropertyChanged(nameof(ParticipantList));
        }
    }
}
