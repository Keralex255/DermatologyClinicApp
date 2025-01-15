using DermatologyClinicApp.Data;
using DermatologyClinicApp.Views;

namespace DermatologyClinicApp
{
    public partial class MainPage : ContentPage
    {
        private readonly AppDbContext _context;

        public MainPage(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private async void OnUsersClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserListPage(_context));
        }

        private async void OnAppointmentsClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AppointmentListPage(_context));
        }
    }
}