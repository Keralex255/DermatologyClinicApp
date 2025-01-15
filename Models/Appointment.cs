using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;
namespace DermatologyClinicApp.Models
{
    public class Appointment
    {
        [PrimaryKey, AutoIncrement]
        public int AppointmentId { get; set; }
        public int UserId { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string Status { get; set; }

        public User User { get; set; }
    }
}
