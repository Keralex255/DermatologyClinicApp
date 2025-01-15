using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using DermatologyClinicApp.Models;

namespace DermatologyClinicApp.Data
{
    public class AppDbContext
    {
        private readonly SQLiteAsyncConnection _database;

        public AppDbContext(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);

            // ✅ Crearea tabelelor User și Appointment
            _database.CreateTableAsync<User>().Wait();
            _database.CreateTableAsync<Appointment>().Wait();
        }

        // ✅ CRUD pentru User

        public Task<List<User>> GetUsersAsync()
        {
            return _database.Table<User>().ToListAsync();
        }

        public Task<User> GetUserAsync(int id)
        {
            return _database.Table<User>()
                            .Where(u => u.UserId == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveUserAsync(User user)
        {
            return user.UserId != 0
                ? _database.UpdateAsync(user)
                : _database.InsertAsync(user);
        }

        public Task<int> DeleteUserAsync(User user)
        {
            return _database.DeleteAsync(user);
        }

        // ✅ CRUD pentru Appointment

        public Task<List<Appointment>> GetAppointmentsAsync()
        {
            return _database.Table<Appointment>().ToListAsync();
        }

        public Task<Appointment> GetAppointmentAsync(int id)
        {
            return _database.Table<Appointment>()
                            .Where(a => a.AppointmentId == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveAppointmentAsync(Appointment appointment)
        {
            return appointment.AppointmentId != 0
                ? _database.UpdateAsync(appointment)
                : _database.InsertAsync(appointment);
        }

        public Task<int> DeleteAppointmentAsync(Appointment appointment)
        {
            return _database.DeleteAsync(appointment);
        }
    }
}
