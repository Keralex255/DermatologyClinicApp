using DermatologyClinicApp.Data;
using DermatologyClinicApp.Models;

namespace DermatologyClinicApp.Views
{
    public partial class PaginaPrincipala : ContentPage
    {
        private readonly AppDbContext _context;

        public PaginaPrincipala(AppDbContext context)
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