using DermatologyClinicApp.Data;
using DermatologyClinicApp.Models;

namespace DermatologyClinicApp.Views
{
    public partial class UserListPage : ContentPage
    {
        private readonly AppDbContext _context;
        public UserListPage(AppDbContext context)
        {
            InitializeComponent();
            _context = context;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            UserListView.ItemsSource = await _context.GetUsersAsync();
        }

        private async void OnAddUserClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new UserAddEditPage(_context));
        }

        private async void OnUserSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem is User user)
            {
                await Navigation.PushAsync(new UserDetailPage(_context, user));
            }
        }
        private async void OnBackClicked(object sender, EventArgs e)
        {
            await Navigation.PopToRootAsync();
        }
    }
}