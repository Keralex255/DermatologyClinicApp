using DermatologyClinicApp.Data;
using DermatologyClinicApp.Models;

namespace DermatologyClinicApp.Views
{
    public partial class AppointmentListPage : ContentPage
    {
        private readonly AppDbContext _context;
        public AppointmentListPage(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            AppointmentListView.ItemsSource = await _context.GetAppointmentsAsync();
        }

        private async void OnAddAppointmentClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppointmentAddEditPage(_context));
        }

        private async void OnAppointmentSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is Appointment appointment)
            {
                await Navigation.PushAsync(new AppointmentDetailPage(_context, appointment));
            }
        }
        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}
