using Microsoft.Maui.Controls;

namespace EkandidatoAdmin
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddNewCandidates), typeof(AddNewCandidates));
            Routing.RegisterRoute(nameof(VotingPage), typeof(VotingPage));
        }

        protected override Window CreateWindow(IActivationState? activationState)
        => new Window(new AppShell());
    }
}