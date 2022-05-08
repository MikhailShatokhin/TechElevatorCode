﻿using System;
using System.ComponentModel.DataAnnotations;

namespace HotelReservations.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public int HotelId { get; set; }

        public string FullName { get; set; }

        public DateTime CheckinDate { get; set; }
        [Range (1,99)]
        public int Nights { get; set; }
        [Range (1,20, ErrorMessage = "You may only register up to 20 guests. Please resubmit.")]
        public int Guests { get; set; }

        public Reservation()
        {
            //must have parameterless constructor to deserialize
        }

        public Reservation(int id, int hotelId, string fullName, DateTime checkinDate, int nights, int guests)
        {
            Id = id;
            HotelId = hotelId;
            FullName = fullName;
            CheckinDate = checkinDate;
            Nights = nights;
            Guests = guests;
        }
    }
}
