using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using DevCamp.Raffle.Models;
using DevCamp.Raffle.Services;
using FreshMvvm;
using Xamarin.Forms;

namespace DevCamp.Raffle.Features.Participants
{
    public class ParticipantListPageModel : FreshBasePageModel
    {
        private readonly IParticipantsService _participantsService;
        private ICommand _raffleCommand;

        public IList<Participant> ParticipantList { get; set; }

        public Participant SelectedParticipant
        {
            get { return null; }
            set
            {
                if (value != null)
                {
                    CoreMethods.PushPageModel<ParticipantPageModel>(value);
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

            // this is required in order to notify the UI for the changes. 
            // it is a bit of workaround-ish soloution and if done properly, we'd use the ObservableCollection<Participant>, 
            // however then the propagation to UI would be done for each item added (for each participant).
            RaisePropertyChanged(nameof(ParticipantList));
        }

        public ICommand RaffleCommand
        {
            get { return _raffleCommand ?? (_raffleCommand = new Command(async arg => await Raffle(arg))); }
        }

        private async Task Raffle(object arg)
        {
            var random = new Random();
            int winnerIndex = random.Next(0, ParticipantList.Count);
            var winner = ParticipantList[winnerIndex];
            await CoreMethods.DisplayAlert("And the winner is....", winner.ToString(), "Ok");
        }
    }
}
