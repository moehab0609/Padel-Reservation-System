using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Padel_Reservation_system2
{
    internal class NewReservation
    {
        
        public string User { get; set; }
        public string Email { get; set; }
        public int ReservationId {
            get
            {
                return this.ReservationId;

            }
            set 
            {
                ReservationId = 1000;
            } 
        }
        public string courtNum { get; set; }
        public string time {  get; set; }
        public DateTime Date { get; set;}
        

        

        public  NewReservation(string user, string Email,string Courtnum,DateTime date)
        {
            
            this.User = user;
            this.Email = Email;
            this.courtNum = Courtnum;
            this.Date = date;
            ReservationId++;
        }

        public int ReturnReser(int reservationId)
        {
            
            return reservationId;
        }

        public void CancelReservation(int reservationId)
        {
           
        }

        
    }
}
