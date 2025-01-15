using DermatologyClinicApp.Data;
using DermatologyClinicApp.Models;

namespace DermatologyClinicApp.Views
{
    public partial class AppointmentAddEditPage : ContentPage
    {
        private readonly AppDbContext _context;
        private Appointment _appointment;

        public AppointmentAddEditPage(AppDbContext context, Appointment appointment = null)
        {
            InitializeComponent();
            _context = context;
            _appointment = appointment ?? new Appointment();
            BindingContext = _appointment;
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            await _context.SaveAppointmentAsync(_appointment);
            await Navigation.PopAsync();
        }
        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

    }
}