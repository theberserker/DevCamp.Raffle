using DevCamp.Raffle.Features.Participants;
using DevCamp.Raffle.Services;
using FreshMvvm;
using Xamarin.Forms;

namespace DevCamp.Raffle
{
    public partial class App : Application
    {
        public App()
        {
            ConfigureIOC();

            var contactList = FreshPageModelResolver.ResolvePageModel<ParticipantListPageModel>();
            var navContainer = new FreshNavigationContainer(contactList);
            MainPage = navContainer;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        private void ConfigureIOC()
        {
            FreshIOC.Container.Register<IParticipantsService, ParticipantsService>();
        }
    }
}
