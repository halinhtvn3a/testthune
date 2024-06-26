﻿using BusinessObjects;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookingService
    {
        private readonly BookingRepository BookingRepository = null;
        public BookingService()
        {
            if (BookingRepository == null)
            {
                BookingRepository = new BookingRepository();
            }
        }
        public Booking AddBooking(Booking Booking) => BookingRepository.AddBooking(Booking);
        public void DeleteBooking(string id) => BookingRepository.DeleteBooking(id);
        public Booking GetBooking(string id) => BookingRepository.GetBooking(id);
        public List<Booking> GetBookings() => BookingRepository.GetBookings();
        //public Booking UpdateBooking(string id, Booking Booking) => BookingRepository.UpdateBooking(id, Booking);
    }
}
