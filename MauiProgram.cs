using DermatologyClinicApp.Data;
using DermatologyClinicApp.Views;

namespace DermatologyClinicApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            // ✅ Înregistrare AppDbContext ca serviciu singleton
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "clinic.db3");
            builder.Services.AddSingleton(new AppDbContext(dbPath));

            // ✅ Înregistrare pagini
            builder.Services.AddTransient<UserListPage>();
            builder.Services.AddTransient<UserAddEditPage>();
            builder.Services.AddTransient<UserDetailPage>();
            builder.Services.AddTransient<AppointmentListPage>();
            builder.Services.AddTransient<AppointmentAddEditPage>();
            builder.Services.AddTransient<AppointmentDetailPage>();

            return builder.Build();
        }
    }
}