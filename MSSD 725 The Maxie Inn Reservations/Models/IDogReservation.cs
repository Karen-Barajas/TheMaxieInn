using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSSD_725_The_Maxie_Inn_Reservations.Models
{
    public interface IDogReservation
    {
        string OwnerName { get; set; }
        string DogName { get; set; }
        DateTime CheckInDate { get; set; }
        DateTime CheckOutDate { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }

        int Duration();        
        int CalculateTotalCost();
        void Confirmation();
    }
}