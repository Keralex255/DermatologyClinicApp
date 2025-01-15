using DermatologyClinicApp.Data;
using DermatologyClinicApp.Models;

namespace DermatologyClinicApp.Views
{
    public partial class UserDetailPage : ContentPage
    {
        private readonly AppDbContext _context;
        private readonly User _user;

        public UserDetailPage(AppDbContext context, User user)
        {
            InitializeComponent();
            _context = context;
            _user = user;
            BindingContext = _user;
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            await _context.DeleteUserAsync(_user);
            await Navigation.PopAsync();
        }
    }
}