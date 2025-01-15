using DermatologyClinicApp.Data;
using DermatologyClinicApp.Models;

namespace DermatologyClinicApp.Views
{
    public partial class AppointmentDetailPage : ContentPage
    {
        private readonly AppDbContext _context;
        private readonly Appointment _appointment;

        public AppointmentDetailPage(AppDbContext context, Appointment appointment)
        {
            InitializeComponent();
            _context = context;
            _appointment = appointment;
            BindingContext = _appointment;
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            await _context.DeleteAppointmentAsync(_appointment);
            await Navigation.PopAsync();
        }
    }
}
