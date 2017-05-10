using DevCamp.Raffle.Features.Participant;
using Xamarin.Forms;

namespace DevCamp.Raffle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new ParticipantPage();
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
    }
}
