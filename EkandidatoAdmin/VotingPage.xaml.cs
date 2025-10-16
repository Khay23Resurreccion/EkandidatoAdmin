using Microsoft.Maui.Controls;

namespace EkandidatoAdmin;

public partial class VotingPage : ContentPage
{
	public VotingPage()
	{
		InitializeComponent();
		BindingContext = new VotingViewModel();
    }
}