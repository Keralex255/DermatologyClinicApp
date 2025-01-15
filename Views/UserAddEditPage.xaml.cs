using DermatologyClinicApp.Data;
using DermatologyClinicApp.Models;

namespace DermatologyClinicApp.Views
{
    public partial class UserAddEditPage : ContentPage
    {
        private readonly AppDbContext _context;
        private User _user;

        public UserAddEditPage(AppDbContext context, User user = null)
        {
            InitializeComponent();
            _context = context;
            _user = user ?? new User();
            BindingContext = _user;
        }

        private async void OnSaveClicked(object sender, EventArgs e)
        {
            await _context.SaveUserAsync(_user);
            await Navigation.PopAsync();
        }
        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }

    }
}
