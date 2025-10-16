using Microsoft.Maui.Controls;
using System;
using System.Globalization;

namespace EkandidatoAdmin
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(AdminDashboard), typeof(AdminDashboard));
            Routing.RegisterRoute(nameof(VotingPage), typeof(VotingPage));
            Routing.RegisterRoute(nameof(AddNewCandidates), typeof(AddNewCandidates));
        }
    }
}
