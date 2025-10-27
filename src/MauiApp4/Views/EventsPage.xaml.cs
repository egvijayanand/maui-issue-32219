namespace MauiApp4.Views
{
    public partial class EventsPage : ContentPage
    {
        public EventsPage()
        {
            InitializeComponent();

            Title = "Calendar";
        }

        private async void OnAddEvent(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("newevent");
        }
    }
}
