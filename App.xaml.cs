using DermatologyClinicApp.Data;
using DermatologyClinicApp.Views;
using Microsoft.Maui.Controls;

namespace DermatologyClinicApp
{
    public partial class App : Application
    {
        public App(AppDbContext dbContext)
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}