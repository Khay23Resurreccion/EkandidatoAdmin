using Microsoft.Maui.Controls;
using System;
using System.Windows.Input;

namespace EkandidatoAdmin;

public partial class VotingPage : ContentPage
{
	public VotingPage()
	{
		InitializeComponent();
		BindingContext = new VotingViewModel();
    }
    private async void SubmitVote_Clicked(object sender, EventArgs e)
    {
    
        if (BindingContext is not VotingViewModel vm || !vm.IsReady)
        {
            await DisplayAlert("Incomplete", "Please pick one candidate for each position.", "OK");
            return;
        }

        // Confirmation note
        bool confirm = await DisplayAlert(
            "Note!",
            "Once you cast your vote for a candidate, you won’t be able to change it or vote for another candidate.",
            "Confirm",
            "Cancel");

        if (!confirm) return;

        // Proceed: execute your existing submit command if present
        if (vm.SubmitVoteCommand is ICommand cmd && cmd.CanExecute(null))
            cmd.Execute(null);

        // Optional success toast
        await DisplayAlert("Vote Submitted", "Thank you for voting!", "OK");
    }
}